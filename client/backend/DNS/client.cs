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
using System.Net;

namespace GGSClient.client.backend.DNS
{
    internal class client
    {
        public async static Task MainAsync(string[] args)
        {
            DnsClient client = new DnsClient("8.8.8.8");

            foreach (string domain in args)
            {
                IList<IPAddress> ips = await client.Lookup(domain).ConfigureAwait(false);
                Console.WriteLine("{0} => {1}", domain, string.Join(", ", ips));
            }
        }
    }
}
