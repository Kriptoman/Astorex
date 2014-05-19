using System;

namespace TaskManager.Infrastructure.Logging
{
    public interface ILogger
    {
        void LogError(Exception exception);

        void LogInfo(string message, params object[] args);
    }
}