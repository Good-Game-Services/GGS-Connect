//External NuGet
using DiscordRPC;
using DiscordRPC.Events;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSClient.client.backend.API
{
    internal class auth
    {
        public static Boolean authDiscord(string token)
        {
            string DiscordDEVJson = File.ReadAllText(GGSClient.client.defaultC.values.AppDataPath + "/DiscordDEV.json");
            dynamic DiscordDEVoutputJson = JsonConvert.DeserializeObject(DiscordDEVJson);
            //GGSClient.client.backend.DiscordRPC.client.ApplicationID;
            var request = (HttpWebRequest)WebRequest.Create("https://connect.ggs-network.de/ajax/request/account/change_name.php");
            var postData = "client_id=" + Uri.EscapeDataString(DiscordDEVoutputJson.client_id);
            postData += "&client_secret=" + Uri.EscapeDataString(DiscordDEVoutputJson.client_secret);
            postData += "&grant_type=" + Uri.EscapeDataString("authorization_code");
            postData += "&code=" + Uri.EscapeDataString(GGSClient.client.defaultC.values.DiscordAuth_token);
            postData += "&redirect_uri=" + Uri.EscapeDataString("http://localhost:1337/auth");
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
                    
                if (outputJson.success == true)
                {
                    MessageBox.Show($"{outputJson.message}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                if (outputJson.success == false)
                {
                    MessageBox.Show($"{outputJson.message}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - handler_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - handler_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
