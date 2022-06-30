using WebSocketSharp;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GGSClient.client.backend
{
    internal class ws
    {
        public static void runWSClient(string url)
        {
            try
            {
                using (var wsclient = new WebSocket(url))
                {
                    wsclient.OnMessage += (sender, e) =>
                        ws.wsScript(e.Data);

                    wsclient.Connect();
                    wsclient.Send("CLIENT=" + GGSClient.client.defaultC.values.ClientID());

                }
            }
            catch(Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.ws_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.ws_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void wsScript(string message)
        {
            GGSClient.client.backend.log.Logger.Info("WS Client recieve Message: " + message);
            if (message == "BanAllClient")
            {
                MessageBox.Show("ALL CLIENTS TAKE DOWN BY THE ADMIN", "WS CLIENT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            if (message == "BanAllVPN")
            {
                MessageBox.Show("ALL VPNS TAKE DOWN BY THE ADMIN", "WS CLIENT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
    }
}
