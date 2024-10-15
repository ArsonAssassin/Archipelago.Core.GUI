using Serilog;
using Serilog.Configuration;
using Serilog.Events;
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
        private static Action<string> _outputAction;

        public static void Initialize(Action<string> mainFormWriter)
        {
            _outputAction = mainFormWriter;
            var loggerConfiguration = new LoggerConfiguration()
                .WriteTo.ArchipelagoGuiSink(_outputAction);

            _logger = loggerConfiguration.CreateLogger();
            Log.Logger = _logger;
        }
        public static void SetLogLevel(LogEventLevel level)
        {
            var loggerConfiguration = new LoggerConfiguration()
                .WriteTo.ArchipelagoGuiSink(_outputAction, level);
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
