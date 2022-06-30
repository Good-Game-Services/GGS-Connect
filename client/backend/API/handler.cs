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
    internal class handler
    {
        // change firstname and lastname
        public static void changeName(string firstname, string lastname)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://connect.ggs-network.de/ajax/request/account/change_name.php");
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("user_session", $"{GGSClient.client.defaultC.values.user_session}", "/", "connect.ggs-network.de"));
            var postData = "firstName=" + Uri.EscapeDataString(firstname);
            postData += "&lastName=" + Uri.EscapeDataString(lastname);
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

        // change password
        public static void changePassord(string cr_password, string nw_password)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://connect.ggs-network.de/ajax/request/account/change_password.php");
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("user_session", $"{GGSClient.client.defaultC.values.user_session}", "/", "connect.ggs-network.de"));
            var postData = "cr_password=" + Uri.EscapeDataString(cr_password);
            postData += "&nw_password=" + Uri.EscapeDataString(nw_password);
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
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - handlers_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - handler_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
