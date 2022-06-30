//External
using SimpleHttp;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GGSClient.client.backend
{
    internal class http
    {
        //string
        static string success = "\nsucces\n";
        static string left = "{";
        static string right = "}";
        public static void httpServer(int port)
        {
            GGSClient.client.backend.log.Logger.Info("HTTP SERVER running on " + port.ToString());
            // run http server
            Route.Add("/client/wallpaper", (req, res, props) =>
            {
                GGSClient.client.backend.log.Logger.Info("HTTP SERVER /client/wallpaper");
                //use net or local file
                if (GGSClient.client.defaultC.values.useNet == true)
                {
                    res.AsText(GGSClient.client.defaultC.func.webClient.DownloadString("https://assets.ggs-network.de/client-assets/wwwroot/client.html"));
                }
                if (GGSClient.client.defaultC.values.useNet == false)
                {
                    string html = File.ReadAllText($@"{GGSClient.client.defaultC.values.AppDataPath}\wwwroot\client.html");
                    res.AsText(html);
                }

            }, "GET");
            HttpServer.ListenAsync(port, CancellationToken.None, Route.OnHttpRequestAsync);
        }

        //WEB GUI
        public static void WebGUI(int port)
        {
            GGSClient.client.backend.log.Logger.Info("HTTP SERVER running on " + port.ToString());
            Route.Add("/", (req, res, props) =>
            {
                GGSClient.client.backend.log.Logger.Info("HTTP SERVER /");
                if (GGSClient.client.defaultC.values.connected == true)
                {
                    //use net or local file
                    if (GGSClient.client.defaultC.values.useNet == true)
                    {
                        res.AsText(GGSClient.client.defaultC.func.webClient.DownloadString("https://assets.ggs-network.de/client-assets/wwwroot/webgui/connected.html"));
                    }
                    if (GGSClient.client.defaultC.values.useNet == false)
                    {
                        string html = File.ReadAllText($@"{GGSClient.client.defaultC.values.AppDataPath}\wwwroot\connected.html");
                        res.AsText(html);
                    }
                }
                if(GGSClient.client.defaultC.values.connected == false)
                {
                    //use net or local file
                    if (GGSClient.client.defaultC.values.useNet == true)
                    {
                        res.AsText(GGSClient.client.defaultC.func.webClient.DownloadString("https://assets.ggs-network.de/client-assets/wwwroot/webgui/disconnected.html"));
                    }
                    if (GGSClient.client.defaultC.values.useNet == false)
                    {
                        string html = File.ReadAllText($@"{GGSClient.client.defaultC.values.AppDataPath}\wwwroot\disconnected.html");
                        res.AsText(html);
                    }
                }
            }, "GET");

            Route.Add("/api/v1/connect", (req, res, props) =>
            {
                GGSClient.client.backend.log.Logger.Info("HTTP SERVER /api/v1/connect");
                GGSClient.client.defaultC.values.connected = true;
                GGSClient.client.backend.openvpn.client.connectVPN();
                res.AsText($"{left} \n{success}\n: true {right}");
            }, "GET");
            Route.Add("/api/v1/disconnect", (req, res, props) =>
            {
                GGSClient.client.backend.log.Logger.Info("HTTP SERVER /api/v1/disconnect");
                GGSClient.client.defaultC.values.connected = false;
                GGSClient.client.backend.openvpn.client.disconnect();
                res.AsText($"{left} \n{success}\n: true {right}");
            }, "GET");
            Route.Add("/api/v1/close", (req, res, props) =>
            {
                GGSClient.client.backend.log.Logger.Info("HTTP SERVER /api/v1/close");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"taskkill";
                startInfo.Arguments = "/F /IM \nGGS Connect.exe\n";
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.Verb = "runas";
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
                res.AsText($"{left} \n{success}\n: true {right}");
            }, "GET");

            HttpServer.ListenAsync(port, CancellationToken.None, Route.OnHttpRequestAsync);
        }

        //Web Auth Server
        public static void authServer(int port)
        {
            GGSClient.client.backend.log.Logger.Info("HTTP SERVER running on " + port.ToString());
            Route.Add("/auth/{token}", (req, res, props) =>
            {
                GGSClient.client.defaultC.values.user_session = props["token"];
                GGSClient.client.backend.log.Logger.Info($"HTTP SERVER /auth/{GGSClient.client.defaultC.values.user_session}");
                //use net or local file
                if (GGSClient.client.defaultC.values.useNet == true)
                {
                    res.AsText(GGSClient.client.defaultC.func.webClient.DownloadString("https://assets.ggs-network.de/client-assets/wwwroot/webgui/success.html"));
                }
                if (GGSClient.client.defaultC.values.useNet == false)
                {
                    string html = File.ReadAllText($@"{GGSClient.client.defaultC.values.AppDataPath}\wwwroot\success.html");
                    res.AsText(html);
                }
            }, "GET");
            HttpServer.ListenAsync(port, CancellationToken.None, Route.OnHttpRequestAsync);
        }
    }
}
