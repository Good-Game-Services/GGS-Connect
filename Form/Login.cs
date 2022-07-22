using MaterialSkin;
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
