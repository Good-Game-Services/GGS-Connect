//External NuGet
using DotNetEnv;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGSClient.client.backend.db
{
    internal class env
    {
        public static string setDotEnvString(string path, string name)
        {
            using (var stream = File.OpenRead(path))
            {
                DotNetEnv.Env.Load(stream);
            }
            return DotNetEnv.Env.GetString(name);
        }

        public static bool setDotEnvBool(string path, string name)
        {
            using (var stream = File.OpenRead(path))
            {
                DotNetEnv.Env.Load(stream);
            }
            return DotNetEnv.Env.GetBool(name);
        }

        public static int setDotEnvInt(string path, string name)
        {
            using (var stream = File.OpenRead(path))
            {
                DotNetEnv.Env.Load(stream);
            }
            return DotNetEnv.Env.GetInt(name);
        }
    }
}
