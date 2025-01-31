﻿namespace SpaceWarp.API.Logging
{
    public abstract class BaseModLogger
    {
        public abstract void Log(LogLevel level, string message);

        public void Trace(string message) => Log(LogLevel.Trace, message);
        public void Debug(string message) => Log(LogLevel.Debug, message);
        public void Info(string message) => Log(LogLevel.Info, message);
        public void Warn(string message) => Log(LogLevel.Warn, message);
        public void Error(string message) => Log(LogLevel.Error, message);
        public void Critical(string message) => Log(LogLevel.Critical, message);
    }
}