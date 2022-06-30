using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (GGSClient.client.defaultC.func.getAdminRights())
            {
                GGSClient.client.startLaunching.run();

                //Load Application
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (GGSClient.client.backend.reg.checkRegistry())
                {
                    Application.Run(new Client.Login());
                }
                else
                {
                    MessageBox.Show("That is the first start of this client, please wait a second to install the client services and assets!", "VPN Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GGSClient.client.backend.reg.setRegistry();
                    Application.Run(new GGSClient.SplashScreen());
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
