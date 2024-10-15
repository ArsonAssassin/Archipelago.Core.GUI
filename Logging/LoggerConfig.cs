using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archipelago.Core.GUI.Logging
{
    public static class LoggerConfig
    {
        private static ILogger _logger;

        public static void Initialize(Action<string> mainFormWriter)
        {
            var loggerConfiguration = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.ArchipelagoGuiSink(mainFormWriter);

            _logger = loggerConfiguration.CreateLogger();
            Log.Logger = _logger;
        }

        public static LoggerConfiguration GetLoggerConfiguration(Action<string> mainFormWriter)
        {
            return new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.ArchipelagoGuiSink(mainFormWriter);
        }
    }
}
