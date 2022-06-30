using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSClient.client.backend.DNS
{
    internal class cloudflared
    {
        public static void startDNSoH()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = $@"{GGSClient.client.defaultC.values.AppDataPath}\cloudflared\cloudflared-windows-amd64.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = " proxy-dns";
                startInfo.Verb = "runas";
                startInfo.UseShellExecute = true;
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.cloudflared", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.cloudflared", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        public static void stopDNSoH()
        {
            Process[] procs = Process.GetProcessesByName("cloudflared-windows-amd64.exe");
            foreach (Process p in procs) { p.Kill(); }
        }
        public static void serviceInstall()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = $@"{GGSClient.client.defaultC.values.AppDataPath}\cloudflared\cloudflared-windows-amd64.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = " services install";
                startInfo.Verb = "runas";
                startInfo.UseShellExecute = true;
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.cloudflared", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.cloudflared", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void serviceUninstall()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = $@"{GGSClient.client.defaultC.values.AppDataPath}\cloudflared\cloudflared-windows-amd64.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = " services unintsall";
                startInfo.Verb = "runas";
                startInfo.UseShellExecute = true;
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.cloudflared", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.cloudflared", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
