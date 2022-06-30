using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSClient
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("http://localhost:1338/client/wallpaper"); //Set Wallpaper
        }

        private void btn_refresh_log_Click(object sender, EventArgs e)
        {
            richTextBox_log.Text = "";
            NLog.LogManager.Shutdown();
            try
            {
                TextReader reader = new StreamReader(GGSClient.client.defaultC.values.logPath);
                richTextBox_log.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception ex)
            {
                richTextBox_log.Text = "ERROR: " + ex;
            }

            GGSClient.client.backend.log.runConfig();
        }
        private void btn_reset_log_Click(object sender, EventArgs e)
        {
            NLog.LogManager.Shutdown();
            File.Delete(GGSClient.client.defaultC.values.logPath);
            GGSClient.client.backend.log.runConfig();
            GGSClient.client.backend.log.Logger.Warn("Logger was reseted!");
        }

        private void btn_change_name_Click(object sender, EventArgs e)
        {
            try
            {
                GGSClient.client.backend.API.handler.changeName(txt_firstname.Text, txt_lastname.Text);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Handler");
            }
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_new_password_confirm.Text == txt_new_password.Text)
                {
                    GGSClient.client.backend.API.handler.changePassord(txt_new_password.Text, txt_old_password.Text);
                }
                else
                {
                    MessageBox.Show("Pasword not same!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Handler");
            }
        }

        private void switch_DoH_CheckedChanged(object sender, EventArgs e)
        {
            if (switch_DoH.Checked == true)
            {
                GGSClient.client.backend.DNS.cloudflared.startDNSoH();
                GGSClient.client.defaultC.values.connected = true;
                label_doh_status.LinkColor = Color.Green;
                label_doh_status.Text = "Connected";
            }
            else
            {
                GGSClient.client.backend.DNS.cloudflared.stopDNSoH();
                GGSClient.client.defaultC.values.connected = false;
                label_doh_status.LinkColor = Color.Red;
                label_doh_status.Text = "Disconnected";
            }
        }
    }
}
