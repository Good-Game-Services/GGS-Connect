using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSClient.client.backend.download
{
    internal class download
    {
        static WebClient webClient = new WebClient();

        public static void downloadFile(string url, string path)
        {
            try
            {
                webClient.DownloadFile(url, path);
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.download.download", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.download.download", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void unzipFile(string zipPath, string extractPath)
        {
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.download.download", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.download.download", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void zipFile(string startPath, string zipPath)
        {
            try
            {
                System.IO.Compression.ZipFile.CreateFromDirectory(startPath, zipPath);
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.download.download", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.download.download", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Download Scripts
        public static void downloadOpenVPNModule()
        {
            download.downloadFile("https://assets.ggs-network.de/client-assets/download/openvpn.comprimessed.zip", $@"{GGSClient.client.defaultC.values.AppDataPath}");
            download.unzipFile($@"{GGSClient.client.defaultC.values.AppDataPath}/client.comprimessed.zip", $@"{GGSClient.client.defaultC.values.AppDataPath}/client");
            File.Delete($@"{GGSClient.client.defaultC.values.AppDataPath}/client.comprimessed.zip");
        }
        public static void downloadWWWROOT()
        {
            download.downloadFile("https://assets.ggs-network.de/client-assets/download/wwwroot.comprimessed.zip", $@"{GGSClient.client.defaultC.values.AppDataPath}");
            download.unzipFile($@"{GGSClient.client.defaultC.values.AppDataPath}/wwwroot.comprimessed.zip", $@"{GGSClient.client.defaultC.values.AppDataPath}/wwwroot");
            File.Delete($@"{GGSClient.client.defaultC.values.AppDataPath}/wwwroot.comprimessed.zip");
        }
        public static void downloadClouadflared()
        {
            download.downloadFile("https://assets.ggs-network.de/client-assets/download/cloudflared.comprimessed.zip", $@"{GGSClient.client.defaultC.values.AppDataPath}");
            download.unzipFile($@"{GGSClient.client.defaultC.values.AppDataPath}/cloudflared.comprimessed.zip", $@"{GGSClient.client.defaultC.values.AppDataPath}/cloudflared");
            File.Delete($@"{GGSClient.client.defaultC.values.AppDataPath}/cloudflared.comprimessed.zip");
        }
    }
}
