using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GGSClient.client.backend
{
    internal class shell
    {
        static string output = "";
        //deafult pwsh
        public static void runPWSH(string arg1, string arg2, string arg3, string arg4)
        {
            GGSClient.client.backend.shell.output = "";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"powershell.exe";
            startInfo.Arguments = $@"& '{GGSClient.client.defaultC.values.AppDataPath}\pwsh.ps1' {arg1} {arg2} {arg3} {arg4}";
            startInfo.Verb = "runas";
            startInfo.UseShellExecute = true;
            startInfo.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            GGSClient.client.backend.shell.output = process.StandardOutput.ReadToEnd();
        }

        //pwsh scripts
        public static void netAdapter_disable(string name)
        {
            GGSClient.client.backend.shell.runPWSH("NetAdapter", "Disable", name, "");
        }
        public static void netAdapter_enable(string name)
        {
            GGSClient.client.backend.shell.runPWSH("NetAdapter", "Enable", name, "");
        }
        public static void netAdapter_restart(string name)
        {
            GGSClient.client.backend.shell.runPWSH("NetAdapter", "Restart", name, "");
        }
        public static void netAdapter_rename(string oldname, string newname)
        {
            GGSClient.client.backend.shell.runPWSH("NetAdapter", "Rename", oldname, newname);
        }
        public static string netAdapter_get_adapter()
        {
            GGSClient.client.backend.shell.runPWSH("NetAdapter", "GET_NetAdapter", "", "");

            return GGSClient.client.backend.shell.output;
        }
        public static string netAdapter_get_adapter_hardwareinfo()
        {
            GGSClient.client.backend.shell.runPWSH("NetAdapter", "GET_NetAdapter_HardwareInfo", "", "");

            return GGSClient.client.backend.shell.output;
        }

        public static void killOpenVPN()
        {
            GGSClient.client.backend.shell.runPWSH("VPN", "kill", "", "");
        }

        public static void VirtualAdapter_installTAP()
        {
            GGSClient.client.backend.shell.runPWSH("VirtualAdapter", "Install_TAP", "", "");
        }
        public static void VirtualAdapter_installTUN()
        {
            GGSClient.client.backend.shell.runPWSH("VirtualAdapter", "Install_TAP", "", "");
        }
        public static string VirtualAdapter_GET()
        {
            GGSClient.client.backend.shell.runPWSH("VirtualAdapter", "GET", "", "");

            return GGSClient.client.backend.shell.output;
        }
    }
}
