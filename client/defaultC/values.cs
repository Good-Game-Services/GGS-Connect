using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGSClient.client.defaultC
{
    internal class values
    {
        //Pathes
        public static string AppDataPath = $@"C:\Users\{Environment.UserName}\AppData\Roaming\GGS-Network";
        public static string sysUsername = Environment.UserName;
        public static string sysPath = Directory.GetCurrentDirectory();
        public static string sysExec = Application.ExecutablePath;
        public static string sysTmp = $@"C:\Users\{GGSClient.client.defaultC.values.sysUsername}\AppData\Local\Temp";

        //account
        //Put json ouput in strings
        public static string auth;
        public static string method;
        public static string authOver;
        public static string token;

        //user table
        public static int user_id;
        public static string user_firstName;
        public static string user_lastName;
        public static string user_profilePicture;
        public static string user_username;
        public static string user_email;
        public static string user_password;
        public static string user_session;
        public static int user_admin;
        public static int user_verified;
        public static int user_vpn;
        public static string user_join_time;

        //DiscordRPC
        public static string DiscordUserName;
        public static string DiscordUserID;

        public static string DiscordRPCCreated;

        public static string DiscordRPCClientID = "863063471151513640";

        //openvpn
        public static bool connected = false;
        public static string netAdapters = "tap-windows6";

        //Local DNS Server
        public static bool DNS = false;

        //API URL / MODULE
        public static string apiURL_clientAuth = "https://api.ggs-network.de/client/online";
        public static string apiURL_clientConfig = "https://assets.ggs-network.de/config.json";
        public static string apiURL_clientLogin = "https://api.ggs-network.de/client/auth/login";
        public static string apiURL_clientGetUser = "https://api.ggs-network.de/client/auth/get-user";

        public static string apiURL_clientGetUserSession = "https://api.ggs-network.de/client/auth/session";

        public static string apiURL_clientGetVPN = "https://api.ggs-network.de/client/auth/openvpn/get";
        public static string apiURL_clientGenVPN = "https://api.ggs-network.de/client/auth/openvpn/gen";

        //SQLite3 db
        public static string sqlite3_db = $@"{GGSClient.client.defaultC.values.AppDataPath}\client.db";

        //Services URL
        public static string servicesURL_opevpnsetup = "https://swupdate.openvpn.org/community/releases/OpenVPN-2.5.6-I601-amd64.msi";

        //Client default
        public static bool useNet = false;
        public static string logPath = $@"{GGSClient.client.defaultC.values.AppDataPath}\logfile.log";
        public static bool DemoMode = true;

        //GET CLIENT ID
        private static Random random = new Random();
        public static string ClientID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 16)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
