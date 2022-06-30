//External NuGet
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GGSClient.client.backend.db
{
    internal class json
    {
        //read account.json from %appdata%/GGS-Network/account.json
        public static string readUsername(string path)
        {
            string json = File.ReadAllText(path);
            dynamic outputJson = JsonConvert.DeserializeObject(json);
            return outputJson.username;
        }
        public static string readToken(string path)
        {
            string json = File.ReadAllText(path);
            dynamic outputJson = JsonConvert.DeserializeObject(json);
            return outputJson.token;
        }
        public static string readEmail(string path)
        {
            string json = File.ReadAllText(path);
            dynamic outputJson = JsonConvert.DeserializeObject(json);
            return outputJson.email;
        }
    }
}
