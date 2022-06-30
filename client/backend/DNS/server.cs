//External NuGet
using DNS.Server;
using DNS.Client;
using DNS.Protocol;

//System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGSClient.client.backend.DNS
{
    internal class server
    {
        static Request request = new Request();
        public async static Task runServer()
        {
            // Proxy to google's DNS
            MasterFile masterFile = new MasterFile();
            DnsServer server = new DnsServer(masterFile, "localhost");

            // Resolve these domain to localhost
            masterFile.AddIPAddressResourceRecord("google.com", "127.0.0.1");
            masterFile.AddIPAddressResourceRecord("github.com", "127.0.0.1");

            // Log every request
            server.Requested += (sender, e) => Console.WriteLine(e.Request);
            // On every successful request log the request and the response
            server.Responded += (sender, e) => Console.WriteLine("{0} => {1}", e.Request, e.Response);
            // Log errors
            server.Errored += (sender, e) => Console.WriteLine(e.Exception.Message);

            // Start the server (by default it listens on port 53)
            await server.Listen(54);
        }
    }
}
