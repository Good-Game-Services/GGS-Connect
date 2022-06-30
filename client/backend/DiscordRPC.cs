//External NuGet
using DiscordRPC;
using DiscordRPC.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGSClient.client.backend
{
    internal class DiscordRPC
    {
        public static DiscordRpcClient client; //DiscordRPC in C#
											   //Initialize DiscordRPC
		public static void Initialize()
		{
			/*
			Create a Discord client
			NOTE: 	If you are using Unity3D, you must use the full constructor and define
					 the pipe connection.
			*/
			client = new DiscordRpcClient(GGSClient.client.defaultC.values.DiscordRPCClientID);

			//Set the logger
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

			//Subscribe to events
			client.OnReady += (sender, e) =>
			{
				GGSClient.client.defaultC.values.DiscordUserName = e.User.Username;
				GGSClient.client.defaultC.values.DiscordUserID = e.User.ID.ToString();
				Console.WriteLine("Username: " + GGSClient.client.defaultC.values.DiscordUserName);
				GGSClient.client.backend.log.Logger.Info("Discord RPC connected to " + GGSClient.client.defaultC.values.DiscordUserName);
			};

			client.OnPresenceUpdate += (sender, e) =>
			{
				Console.WriteLine("Received Update! {0}", e.Presence);
				GGSClient.client.defaultC.values.DiscordRPCCreated = e.TimeCreated.ToString();
				GGSClient.client.backend.log.Logger.Info("Received Update! " + e.Presence);
			};

			//Connect to the RPC
			client.Initialize();

			//Set the rich presence
			//Call this as many times as you want and anywhere in your code.
			client.SetPresence(new RichPresence()
			{
				Details = "GGS Connect",
				State = "Using the Client",
				Assets = new Assets()
				{
					LargeImageKey = "icon",
					LargeImageText = "GGS-Network",
					SmallImageKey = "1024x1024",
					SmallImageText = "GGS Connect Client"
				}
			});
		}

		//The main loop of your application, or some sort of timer. Literally the Update function in Unity3D
		public static void Update()
		{
			client.SetPresence(new RichPresence()
			{
				Details = "Example Project",
				State = "csharp example",
				Assets = new Assets()
				{
					LargeImageKey = "image_large",
					LargeImageText = "Lachee's Discord IPC Library",
					SmallImageKey = "image_small"
				}
			});
			//Invoke all the events, such as OnPresenceUpdate
			client.Invoke();
		}
	}
}
