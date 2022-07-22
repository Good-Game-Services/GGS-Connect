using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Threading;
using Microsoft.VisualBasic;
using System.IO;

namespace GGSClient
{
    public partial class SplashScreen : MetroFramework.Forms.MetroForm
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            GGSClient.client.defaultC.values.DiscordApp_client_id = Interaction.InputBox("Discord Client ID:", "Discord DEV", "");
            GGSClient.client.defaultC.values.DiscordApp_client_secret = Interaction.InputBox("Discord Client Secret:", "Discord DEV", "");

            string[] DiscordDEVJson = { "{", $"\"client_id\": \"{GGSClient.client.defaultC.values.DiscordApp_client_id}\",", $"\"client_secret\": \"{GGSClient.client.defaultC.values.DiscordApp_client_secret}\"", "}" };
            File.WriteAllLines(GGSClient.client.defaultC.values.AppDataPath + "/DiscordDEV.json", DiscordDEVJson);
            SplashPlayer.Ctlcontrols.play();
        }

        private void SplashPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                Thread.Sleep(400);
                this.Hide();
                int num = (int)new Client.Login().ShowDialog();
                this.Close();
            }
        }
    }
}
