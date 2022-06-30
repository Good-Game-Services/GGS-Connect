//External
using NLog;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGSClient.client.backend
{
    internal class log
    {
        public static readonly NLog.Logger Logger = NLog.LogManager.GetLogger("GGS-Connect");

        public static void runConfig()
        {
            GGSClient.client.backend.log.Logger.Info("Logger File was succesfull injected!");
            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = GGSClient.client.defaultC.values.logPath };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            // Apply config           
            NLog.LogManager.Configuration = config;
        }
    }
}
