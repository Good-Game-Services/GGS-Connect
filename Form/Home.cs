using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSClient
{
    public partial class Home : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        internal static extern bool SendMessage(IntPtr hWnd, Int32 msg, Int32 wParam, Int32 lParam);
        static Int32 WM_SYSCOMMAND = 0x0112;
        static Int32 SC_RESTORE = 0xF120;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("http://localhost:1338/client/wallpaper"); //Set Wallpaper
            GGSClient.client.backend.http.WebGUI(187); // Start WebGUI
            vpn_status.Enabled = true;

            //Label
            lable_username.Text = "Welcome back " + GGSClient.client.defaultC.values.user_username;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void vpn_status_Tick(object sender, EventArgs e)
        {
            //VPN MODULE
            if (GGSClient.client.defaultC.values.connected == true)
            {
            }
            if (GGSClient.client.defaultC.values.connected == false)
            {
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            int num = (int)new GGSClient.Settings().ShowDialog();
        }

        private void switch_VPN_State_CheckedChanged(object sender, EventArgs e)
        {
            if (switch_VPN_State.Checked == true)
            {
                GGSClient.client.backend.openvpn.client.Manager("ggs-network.de", 3306, $@"{GGSClient.client.defaultC.values.AppDataPath}\client.ovpn");
                GGSClient.client.defaultC.values.connected = true;
                label_vpn_status.LinkColor = Color.Green;
                label_vpn_status.Text = "Connected";
            }
            else
            {
                GGSClient.client.backend.openvpn.client.Kill("GGS-ConnectVPN");
                GGSClient.client.defaultC.values.connected = false;
                label_vpn_status.LinkColor = Color.Red;
                label_vpn_status.Text = "Disonnected";
            }
        }
    }
}
