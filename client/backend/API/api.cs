//External NuGet
using Newtonsoft.Json;

//System
using System;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Timers;

namespace GGSClient.client.backend.API
{
    internal class api
    {
        private static System.Timers.Timer aTimer;
        public static void runClient()
        {
            SetTimer();
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedloginClient;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        public static void OnTimedloginClient(Object source, ElapsedEventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create(GGSClient.client.defaultC.values.apiURL_clientAuth);

            var postData = "session=" + Uri.EscapeDataString("");
            postData += "&clientID=" + Uri.EscapeDataString("");
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            try
            {
                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                dynamic outputJson = JsonConvert.DeserializeObject(responseString);

                // Bann Client
                if (outputJson.BannClient.Enable == true)
                {
                    MessageBox.Show($"{outputJson.BannClient.Reason}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - client_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - client_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
