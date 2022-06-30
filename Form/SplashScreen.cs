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
