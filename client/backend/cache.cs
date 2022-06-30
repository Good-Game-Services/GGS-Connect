using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GGSClient.client.backend
{
    internal class cache
    {
        public static void rmCache()
        {
            Directory.Delete(GGSClient.client.defaultC.values.AppDataPath);
        }
    }
}
