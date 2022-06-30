using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace GGSClient.client.backend
{
    internal class services
    {
        public static void checkServices()
        {
            if (GGSClient.client.backend.services.checkOpenVPN())
            {

            }
            else
            {
                GGSClient.client.backend.services.installOpenVPN();
            }
        }

        //services check

        //Check OpenVPN
        public static Boolean checkOpenVPN()
        {
            var registry = Registry.ClassesRoot.OpenSubKey(@"Computer\HKEY_CLASSES_ROOT\Installer\Features\0F31296F927CCB1C2643B728B4A62476"); //OpenVPN GUI 

            if (registry == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Install OpenVPN
        public static void installOpenVPN()
        {
            GGSClient.client.defaultC.func.webClient.DownloadFile($@"https://swupdate.openvpn.org/community/releases/OpenVPN-2.5.7-I602-amd64.msi", $@"{GGSClient.client.defaultC.values.sysTmp}\openvpn-client.msi");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = $@"cmd.exe";
            startInfo.Arguments = $@"start {GGSClient.client.defaultC.values.sysTmp}\openvpn-client.msi";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        //Check wwwroot
        //public static Boolean checkWWWROOT() 
        //{ 
           
        //}
        public static void installWWWROOT()
        {

        }
    }
}
