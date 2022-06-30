using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSClient.client.backend.openvpn
{
    internal class client
    {
        public static void connectVPN()
        {
            string dns = "";
            try
            {
                if (GGSClient.client.defaultC.values.DNS == true)
                {
                    dns = "--push \nlocalhost\n"; 
                }
                File.Copy($@"{GGSClient.client.defaultC.values.AppDataPath}\client.ovpn", $@"{GGSClient.client.defaultC.values.sysPath}\client.ovpn");
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = $"--config client.ovpn --windows-driver {GGSClient.client.defaultC.values.netAdapters} {dns} --block-outside-dns --http-proxy 127.0.0.1 652";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                Thread.Sleep(200);
                try
                {
                    File.Delete($@"{GGSClient.client.defaultC.values.sysPath}\client.ovpn");
                    File.Delete($@"{GGSClient.client.defaultC.values.AppDataPath}\client.ovpn");
                }
                catch (Exception ex)
                {
                    if (File.Exists("debug"))
                    {
                        MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void connectDNS()
        {
            string adapter = "tapX";
            if ((GGSClient.client.defaultC.values.netAdapters == "tap-windows6"))
            {
                adapter = "tapX";
            }
            if ((GGSClient.client.defaultC.values.netAdapters == "wintun"))
            {
                adapter = "tunX";
            }
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = $" --push \nlocalhost\n --dev {adapter} --block-outside-dns";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                Thread.Sleep(200);
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void disconnect()
        {
            try
            {
                Process[] procs = Process.GetProcessesByName("openvpn.exe");
                foreach (Process p in procs) { p.Kill(); }
                try
                {
                    File.Delete($@"{GGSClient.client.defaultC.values.sysPath}\client.ovpn");
                    File.Delete($@"{GGSClient.client.defaultC.values.AppDataPath}\client.ovpn");
                }
                catch (Exception ex)
                {
                    if (File.Exists("debug"))
                    {
                        MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.openvpn.client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
