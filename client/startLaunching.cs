using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

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
            //GGSClient.client.startLaunching.checkFileSys();
            Thread wss = new Thread(backend.ws.runWSClient("ws://localhost:8080"));
            wss.Start();
        }

        public static void checkFileSys()
        {
            if (GGSClient.client.backend.reg.checkRegistry())
            {
            }
            else
            {
                MessageBox.Show("That is the first start of this client, please wait a second to install the client services and assets!", "VPN Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GGSClient.client.backend.reg.setRegistry();
            }
        }
    }
}
