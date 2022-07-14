using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titanium.Web.Proxy.EventArguments;

namespace GGSClient.client.backend.proxy
{
    public static class ProxyEventArgsBaseExtensions
    {
        public static ClientState GetState(this ProxyEventArgsBase args)
        {
            if (args.ClientUserData == null)
            {
                args.ClientUserData = new ClientState();
            }

            return (ClientState)args.ClientUserData;
        }
    }
}
