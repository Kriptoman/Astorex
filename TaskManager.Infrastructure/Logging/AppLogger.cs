using System;
using NLog;

namespace TaskManager.Infrastructure.Logging
{
    public class AppLogger : ILogger
    {
        private const string LoggerName = "AppLogger";
        private readonly Logger _logger;

        public AppLogger()
        {
            _logger = LogManager.GetLogger(LoggerName);
        }

        public void LogInfo(string message, params object[] args)
        {
            if (args != null && args.Length > 0)
            {
                message = string.Format(message, args);
            }

            _logger.Info(message);
        }

        public void LogError(Exception exception)
        {
            if (exception != null )
            {
                _logger.Error(exception.Message);
            }
        }
    }
}