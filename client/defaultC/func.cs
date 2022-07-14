using GGSClient.client.backend.proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Security.ExchangeActiveSyncProvisioning;

namespace GGSClient.client.defaultC
{
    internal class func
    {

        public static readonly ProxyTestController controller = new ProxyTestController(); // Proxy controller

        public static WebClient webClient = new WebClient();

        //Random Char Gen
        private static Random random = new Random();

        public static Boolean getAdminRights()
        {
            if (WindowsIdentity.GetCurrent().Owner == WindowsIdentity.GetCurrent().User)   // Check for Admin privileges   
            {
                try
                {
                    ProcessStartInfo info = new ProcessStartInfo(GGSClient.client.defaultC.values.sysExec); // my own .exe
                    info.UseShellExecute = true;
                    info.Verb = "runas";   // invoke UAC prompt
                    Process.Start(info);
                }
                catch (Win32Exception ex)
                {
                    if (ex.NativeErrorCode == 1223) //The operation was canceled by the user.
                    {
                        MessageBox.Show("Why did you not selected Yes?");
                        Application.Exit();
                    }
                    else
                        throw new Exception("Something went wrong :-(");
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GetDeviceID()
        {
            var deviceInformation = new EasClientDeviceInformation();
            return deviceInformation.Id.ToString();
        }
    }
}
