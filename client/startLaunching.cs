using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

//VS Basic
using Microsoft.VisualBasic;

namespace GGSClient.client
{
    internal class startLaunching
    {
        public static void run()
        {
            GGSClient.client.backend.http.httpServer(1338); //run HTTP Server
            GGSClient.client.backend.DiscordRPC.Initialize(); //run DiscordRPC
            GGSClient.client.backend.log.runConfig(); //run log config

            GGSClient.client.backend.log.Logger.Info("Start Application with code 0x0");
            //Thread wss = new Thread(backend.ws.runWSClient("ws://localhost:8080"));
            //wss.Start();

        }

        public static void firstStart()
        {
            if (GGSClient.client.backend.reg.checkRegistry())
            {
            }
            else
            {
                MessageBox.Show("That is the first start of this client, please wait a second to install the client services and assets!", "VPN Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GGSClient.client.backend.reg.setRegistry();

                try
                {
                    Directory.CreateDirectory(GGSClient.client.defaultC.values.AppDataPath);
                    Directory.CreateDirectory(GGSClient.client.defaultC.values.AppDataPath + "/logs");
                    Directory.CreateDirectory(GGSClient.client.defaultC.values.AppDataPath + "/wwwroot");
                    Directory.CreateDirectory(GGSClient.client.defaultC.values.AppDataPath + "/cloudflared");

                    //GGSClient.client.defaultC.func.webClient.DownloadFile("https://github.com/Good-Game-Services/assets.ggs-network.de.github.io/raw/main/client-assets/download/wwwroot.comprimessed.zip", GGSClient.client.defaultC.values.AppDataPath + "/wwwroot");
                    //GGSClient.client.defaultC.func.webClient.DownloadFile("https://github.com/Good-Game-Services/assets.ggs-network.de.github.io/raw/main/client-assets/download/cloudflared.comprimessed.zip", GGSClient.client.defaultC.values.AppDataPath + "/cloudflared");

                    //ZipFile.ExtractToDirectory(GGSClient.client.defaultC.values.AppDataPath + "/wwwroot/wwwroot.comprimessed.zip", GGSClient.client.defaultC.values.AppDataPath + "/wwwroot");
                    //ZipFile.ExtractToDirectory(GGSClient.client.defaultC.values.AppDataPath + "/wwwroot/cloudflared.comprimessed.zip", GGSClient.client.defaultC.values.AppDataPath + "/cloudflared");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "checkFileSys");
                }

            }
        }
    }
}
