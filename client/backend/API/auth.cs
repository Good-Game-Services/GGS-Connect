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
            var request = (HttpWebRequest)WebRequest.Create("https://ggs-net.herokuapp.com/api/v2/auth/client/token");

            var postData = "token=" + Uri.EscapeDataString(token);
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
                    GGSClient.client.defaultC.values.user_id = outputJson.user.id;
                    GGSClient.client.defaultC.values.user_username = outputJson.user.username + outputJson.user.discriminator;
                    GGSClient.client.defaultC.values.user_email = outputJson.user.email;

                    string[] authJson = { "{", $"    \"username\": \"{GGSClient.client.defaultC.values.user_username}\",", $"    \"email\": \"{GGSClient.client.defaultC.values.user_email}\",", $"    \"token\": \"{GGSClient.client.defaultC.values.token}\"", "}" };
                    File.WriteAllLines($@"{GGSClient.client.defaultC.values.AppDataPath}\account.json", authJson);
                    return true;
                }
                if (outputJson.success == false)
                {

                    if (outputJson.msg == "You got Banned!")
                    {
                        MessageBox.Show($"{outputJson.msg} --- Reason {outputJson.reason}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show($"{outputJson.msg}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - Login.cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - Login.cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return false;
        }
    }
}
