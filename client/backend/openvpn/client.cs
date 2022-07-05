using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSClient.client.backend.openvpn
{
    public class client : IDisposable
    {
        public enum Signal
        {
            Hup,
            Term,
            Usr1,
            Usr2
        }
        private static Socket socket;
        private static int bufferSize = 1024;
        private static string ovpnFileName;
        private static string eventName = "GGS-ConnectVPN";
        private static readonly Process prc = new Process();
        private static string openVpnExePath;

        public static void RunOpenVpnProcess()
        {
            prc.StartInfo.CreateNoWindow = false;
            prc.EnableRaisingEvents = true;
            prc.StartInfo.Arguments = string.Format($"--config {ovpnFileName} --service {eventName} 0");
            prc.StartInfo.FileName = openVpnExePath;
            prc.Start();
        }
        public static void Manager(string host, int port, string ovpnFileName, string userName = null, string password = null, string openVpnExeFileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe")
        {
            openVpnExePath = openVpnExeFileName;
            if (!string.IsNullOrEmpty(ovpnFileName))
            {
                if (!Path.IsPathRooted(ovpnFileName))
                {
                    ovpnFileName = Path.Combine(Directory.GetCurrentDirectory(), ovpnFileName);
                }

                var ovpnFileContent = File.ReadAllLines(ovpnFileName);

                //management
                var idx = Array.FindIndex(ovpnFileContent, x => x.StartsWith("management"));
                if (idx >= 0)
                {
                    ovpnFileContent[idx] = string.Format("management {0} {1}", host, port);
                }
                else
                {
                    var lastIdx = ovpnFileContent.Length - 1;
                    var lastLine = ovpnFileContent[lastIdx];
                    ovpnFileContent[lastIdx] = string.Format("{0}{1}management {2} {3}", lastLine, Environment.NewLine, host, port);
                }

                //auto login
                var idx2 = Array.FindIndex(ovpnFileContent, x => x.StartsWith("auth-user-pass"));
                if (idx2 >= 0)
                {
                    if (userName == null || password == null)
                    {
                        throw new ArgumentException("Username or password cannot be null");
                    }

                    // create a credentials file
                    var passFileName = Path.Combine(Path.GetTempPath(), "ovpnpass.txt").Replace(@"\", @"\\");
                    File.WriteAllLines(passFileName, new string[] { userName, password });

                    // add its path the ovpn file and write it back to the ovpn file
                    ovpnFileContent[idx2] = string.Format("auth-user-pass {0}", passFileName);
                }
                else
                {
                    if (userName != null || password != null)
                    {
                        throw new ArgumentException("Username or password are provided but the *.ovpn file doesn't have the line 'auth-user-pass'");
                    }
                }

                File.WriteAllLines(ovpnFileName, ovpnFileContent);
                RunOpenVpnProcess();
            }

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(host, port);
            SendGreeting();
        }

        #region Commands
        public static string GetStatus()
        {
            return SendCommand("status");
        }

        public static string GetState()
        {
            return SendCommand("state");
        }

        public static string GetState(int n = 1)
        {
            return SendCommand(string.Format("state {0}", n));
        }

        public static string GetStateAll()
        {
            return SendCommand("state all");
        }

        public static string SetStateOn()
        {
            return SendCommand("state on");
        }

        public static string SetStateOnAll()
        {
            return SendCommand("state on all");
        }

        public static string GetStateOff()
        {
            return SendCommand("state off");
        }

        public static string GetVersion()
        {
            return SendCommand("version");
        }

        public static string GetPid()
        {
            return SendCommand("pid");
        }

        public static string SendSignal(Signal sgn)
        {
            return SendCommand(string.Format("signal SIG{0}", sgn.ToString().ToUpper()));
        }

        public static string Mute()
        {
            return SendCommand("pid");
        }

        public static string GetEcho()
        {
            return SendCommand("echo");
        }

        public static string GetHelp()
        {
            return SendCommand("help");
        }

        public static string Kill(string name)
        {
            return SendCommand(string.Format("kill {0}", name));
        }

        public static string Kill(string host, int port)
        {
            return SendCommand(string.Format("kill {0}:{1}", host, port));
        }

        public static string GetNet()
        {
            return SendCommand("net");
        }

        public static string GetLogAll()
        {
            return SendCommand("state off");
        }

        public static string SetLogOn()
        {
            return SendCommand("log on");
        }

        public static string SetLogOnAll()
        {
            return SendCommand("log on all");
        }

        public static string SetLogOff()
        {
            return SendCommand("log off");
        }

        public static string GetLog(int n = 1)
        {
            return SendCommand(string.Format("log {0}", n));
        }

        public static string SendMalCommand()
        {
            return SendCommand("fdsfds");
        }

        private static string TreamRetrievedString(string s)
        {
            return s.Replace("\0", "");
        }

        private static void SendGreeting()
        {
            var bf = new byte[bufferSize];
            int rb = socket.Receive(bf, 0, bf.Length, SocketFlags.None);
            if (rb < 1)
            {
                throw new SocketException();
            }
        }
        #endregion

        private static string SendCommand(String cmd)
        {
            socket.Send(Encoding.Default.GetBytes(cmd + "\r\n"));
            var bf = new byte[bufferSize];
            var sb = new System.Text.StringBuilder();
            int rb;
            string str = "";
            while (true)
            {
                Thread.Sleep(100);
                rb = socket.Receive(bf, 0, bf.Length, 0);
                str = Encoding.UTF8.GetString(bf).Replace("\0", "");
                if (rb < bf.Length)
                {
                    if (str.Contains("\r\nEND"))
                    {
                        var a = str.Substring(0, str.IndexOf("\r\nEND"));
                        sb.Append(a);
                    }
                    else if (str.Contains("SUCCESS: "))
                    {
                        var a = str.Replace("SUCCESS: ", "").Replace("\r\n", "");
                        sb.Append(a);
                    }
                    else if (str.Contains("ERROR: "))
                    {
                        var msg = str.Replace("ERROR: ", "").Replace("\r\n", "");
                        throw new ArgumentException(msg);
                    }
                    else
                    {
                        //todo
                        continue;
                    }

                    break;
                }
                else
                {
                    sb.Append(str);
                }
            }

            return sb.ToString();
        }

        public void Dispose()
        {
            if (socket != null)
            {
                if (ovpnFileName != null)
                {
                    SendSignal(Signal.Term);
                }
            }

            socket.Dispose();
            prc.Close();
        }
    }
}
