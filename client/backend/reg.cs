using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSClient.client.backend
{
    internal class reg
    {
        public static RegistryKey regkeyRoot = Registry.ClassesRoot;
        public static RegistryKey regkeyUser = Registry.CurrentUser;
        public static void setRegistry()
        {
            try
            {
                regkeyUser = regkeyUser.CreateSubKey(@"GGS-Client");
                regkeyRoot = regkeyRoot.CreateSubKey(@"GGS-Client");
                regkeyRoot.SetValue(@"", "URL:GGS-Client Protocol", RegistryValueKind.String);
                regkeyRoot.SetValue(@"URL Protocol", "GGS-Client Protocol", RegistryValueKind.String);
                regkeyRoot.SetValue(@"LicenceAgreed", "no", RegistryValueKind.String);
                regkeyRoot = regkeyRoot.CreateSubKey(@"shell");
                regkeyRoot = regkeyRoot.CreateSubKey(@"open");
                regkeyRoot = regkeyRoot.CreateSubKey(@"command");
                regkeyRoot.SetValue("", $"\"{GGSClient.client.defaultC.values.sysExec}\" \"%1\" \"%2\" \"%3\" \"%4\" \"%5\" \"%6\" \"%7\" \"%8\" \"%9\"", RegistryValueKind.String);
            }
            catch (Exception ex)
            {
            }
        }

        public static Boolean checkRegistry()
        {
            var registry = Registry.ClassesRoot.OpenSubKey(@"GGS-Client");

            if (registry == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void rmRegistry()
        {
            regkeyUser.CreateSubKey(@"GGS-Client");
            regkeyRoot.DeleteSubKeyTree(@"GGS-Client");
        }
    }
}
