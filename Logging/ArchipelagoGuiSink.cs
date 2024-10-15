using Serilog.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archipelago.Core.GUI.Logging
{
    public class ArchipelagoGuiSink : ILogEventSink
    {
        private LogEventLevel _logLevel;
        private Action<string> _outputEvent;
        public ArchipelagoGuiSink(Action<string> outputEvent, LogEventLevel level = LogEventLevel.Information)
        {
            _logLevel = level;
            _outputEvent = outputEvent;
        }
        public void Emit(LogEvent logEvent)
        {
            if(logEvent.Level <= _logLevel)
            {
                _outputEvent?.Invoke(logEvent.RenderMessage());
            }
        }
    }
    public static class ArchipelagoGuiSinkExtensions
    {
        public static LoggerConfiguration ArchipelagoGuiSink(
                  this LoggerSinkConfiguration loggerConfiguration, Action<string> outputEvent, LogEventLevel level = LogEventLevel.Information)
        {
            return loggerConfiguration.Sink(new ArchipelagoGuiSink(outputEvent, level));
        }
    }
}
