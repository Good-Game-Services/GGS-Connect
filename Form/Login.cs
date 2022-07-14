﻿using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        internal static extern bool SendMessage(IntPtr hWnd, Int32 msg, Int32 wParam, Int32 lParam);
        static Int32 WM_SYSCOMMAND = 0x0112;
        static Int32 SC_RESTORE = 0xF120;
        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.BLACK);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("http://localhost:1338/client/wallpaper"); //Set Wallpaper

            GGSClient.client.backend.http.authServer(1337);

            sessionLogin.Enabled = true;
            //MessageBox.Show(GGSClient.client.defaultC.values.ClientIDPublic);

            if (GGSClient.client.defaultC.values.onlyDiscord)
            {
                btn_Login.Visible = false;
                txt_Username.Visible = false;
                txt_Password.Visible = false;
            }
            else
            {
                btn_login_with_discord.Visible = false;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (GGSClient.client.defaultC.values.DemoMode == true)
            {
                sessionLogin.Enabled = false;
                GGSClient.client.defaultC.values.user_firstName = "Emre";
                GGSClient.client.defaultC.values.user_lastName = "Seher";
                GGSClient.client.defaultC.values.user_profilePicture = "";
                GGSClient.client.defaultC.values.user_username = "GGS3rvic3s";
                this.Hide();
                int num = (int)new GGSClient.Home().ShowDialog();
                this.Close();
            }
            if (GGSClient.client.defaultC.values.DemoMode == false)
            {
                sessionLogin.Enabled = false;
                var request = (HttpWebRequest)WebRequest.Create("https://api.ggs-network.de/client/auth/login");

                var postData = "username=" + Uri.EscapeDataString(txt_Username.Text);
                postData += "&password=" + Uri.EscapeDataString(txt_Password.Text);
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
                        GGSClient.client.defaultC.values.user_firstName = outputJson.user.firstName;
                        GGSClient.client.defaultC.values.user_lastName = outputJson.user.lastName;
                        GGSClient.client.defaultC.values.user_profilePicture = outputJson.user.profilePicture;
                        GGSClient.client.defaultC.values.user_username = outputJson.user.username;
                        GGSClient.client.defaultC.values.user_password = outputJson.user.password;
                        GGSClient.client.defaultC.values.user_email = outputJson.user.email;
                        GGSClient.client.defaultC.values.user_session = outputJson.user.session;
                        GGSClient.client.defaultC.values.user_admin = outputJson.user.admin;
                        GGSClient.client.defaultC.values.user_verified = outputJson.user.verified;
                        GGSClient.client.defaultC.values.user_vpn = outputJson.user.vpn;
                        GGSClient.client.defaultC.values.user_join_time = outputJson.user.joinned_time;


                        string[] authJson = { "{", $"    \"username\": \"{GGSClient.client.defaultC.values.user_username}\",", $"    \"email\": \"{GGSClient.client.defaultC.values.user_email}\",", $"    \"token\": \"{GGSClient.client.defaultC.values.token}\"", "}" };
                        //File.WriteAllLines($@"{GGSClient.client.defaultC.values.AppDataPath}\account.json", authJson);
                        if (GGSClient.client.defaultC.values.user_session == "")
                        {
                            MessageBox.Show($"Invalid Session! Please login on https://account.ggs-network.de and try again", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            this.Hide();
                            int num = (int)new GGSClient.Home().ShowDialog();
                            this.Close();
                        }
                    }
                    if (outputJson.success == false)
                    {
                        sessionLogin.Enabled = true;
                        if (outputJson.msg == "You got Banned!")
                        {
                            MessageBox.Show($"{outputJson.msg} --- Reason {outputJson.reason}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            MessageBox.Show($"{outputJson.msg}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
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
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Auth via Browser
        private void sessionLogin_Tick(object sender, EventArgs e)
        {
            if (GGSClient.client.defaultC.values.token == null || GGSClient.client.defaultC.values.token == "")
            {

            }
            else
            {
                sessionLogin.Enabled = false;
                if (GGSClient.client.backend.API.auth.authDiscord(GGSClient.client.defaultC.values.token))
                {
                    this.Hide();
                    int num = (int)new GGSClient.Home().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Not valid!");
                }
            }
        }

        private void btn_login_with_discord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/api/oauth2/authorize?client_id=863063471151513640&redirect_uri=https%3A%2F%2Fggs-net.herokuapp.com%2Fapi%2Fv2%2Fauth%2Fdiscord%2Fredirect%2Fclient&response_type=code&scope=identify%20email%20connections");
        }
    }
}
