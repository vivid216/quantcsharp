using System;
using System.Collections.Generic;
using System.Text;
using Disruptor;
using Disruptor.Dsl;

namespace QuantCSharp.Utilities
{
    public class LogManager : Disruptor.IEventHandler<LogEvent>
    {
        readonly static string _Repository = nameof(LogManager);
        readonly static Disruptor.RingBuffer<LogEvent> ringBuffer;
        readonly static Disruptor<LogEvent> disruptor;
        readonly log4net.ILog _logger;
        private LogManager() {
            _logger = log4net.LogManager.GetLogger(_Repository, typeof(LogManager));
        }
        static LogManager()
        {
            var repo1 = log4net.LogManager.CreateRepository(_Repository);
            var fileInfo = new System.IO.FileInfo(System.IO.Path.Combine(AppContext.BaseDirectory, "Log4net.config"));
            log4net.Config.XmlConfigurator.Configure(repo1, fileInfo);
            //log4net.Config.BasicConfigurator.Configure(repository);

            disruptor = new Disruptor<LogEvent>(() => new LogEvent(), 512, System.Threading.Tasks.TaskScheduler.Default,
                  ProducerType.Multi, new Disruptor.BlockingWaitStrategy());
            disruptor.HandleEventsWith(new LogManager());
            ringBuffer = disruptor.Start();
        }

        /// <summary>
        /// 获取基于log4net的日志实例
        /// </summary>
        /// <returns></returns>
        public static IAsyncLog GetLogger(Type type)
        {
            IAsyncLog _log = new LogEventProducer(ringBuffer, type);
            return _log;
        }

        void IEventHandler<LogEvent>.OnEvent(LogEvent data, long sequence, bool endOfBatch)
        {
            switch (data.Level)
            {
                case LogLevel.INFO:
                    _logger.Info($"{new DateTime(data.UtcTime, DateTimeKind.Utc).ToLocalTime().ToString("HH:mm:ss,ffffff")} --- {data.Message}");
                    break;
                case LogLevel.WARN:
                    _logger.Warn($"{new DateTime(data.UtcTime, DateTimeKind.Utc).ToLocalTime().ToString("HH:mm:ss,ffffff")} --- {data.Message}");
                    break;
                case LogLevel.ERROR:
                    _logger.Error($"{new DateTime(data.UtcTime, DateTimeKind.Utc).ToLocalTime().ToString("HH:mm:ss,ffffff")} --- {data.Message}");
                    break;
                default:
                    _logger.Debug($"{new DateTime(data.UtcTime, DateTimeKind.Utc).ToLocalTime().ToString("HH:mm:ss,ffffff")} --- {data.Message}");
                    break;
            }

        }

        public static void Shutdown()
        {
            disruptor?.Shutdown(TimeSpan.FromSeconds(3));
        }

    }

    public interface IAsyncLog
    {
        void Info(object message, Exception exception);
       
        void Info(object message);

        void InfoFormat(string format, params object[] args);

        void Warn(object message);

        void Warn(object message, Exception exception);

        void WarnFormat(string format, params object[] args);

        void Error(object message);

        void Error(object message, Exception exception);

        void ErrorFormat(string format, params object[] args);
    }

    internal class LogEventProducer : IAsyncLog
    {
        private readonly RingBuffer<LogEvent> ringBuffer;
        private readonly string proTypeName;
        public LogEventProducer(RingBuffer<LogEvent> ringBuffer, Type loggerType)
        {
            this.ringBuffer = ringBuffer;
            proTypeName = loggerType.FullName;
        }

        private void LogDisruptor(LogLevel level,string source, string message)
        {
            long sequence = ringBuffer.Next();
            try
            {
                //用上面的索引取出一个空的事件用于填充 
                LogEvent _event = ringBuffer[sequence];
                _event.UtcTime = DateTime.UtcNow.Ticks;
                _event.Message = $"{source}:{message}";
                _event.Level = level;
            }
            finally
            {
                //发布事件 
                ringBuffer.Publish(sequence);
            }
        }

        void IAsyncLog.Error(object message)
        {
            LogDisruptor(LogLevel.ERROR, proTypeName, $"{message}");
        }

        void IAsyncLog.Error(object message, Exception exception)
        {
            LogDisruptor(LogLevel.ERROR, proTypeName, $"{message} {exception.Message} {exception.StackTrace}");
        }

        void IAsyncLog.ErrorFormat(string format, params object[] args)
        {
            LogDisruptor(LogLevel.ERROR, proTypeName, string.Format(format,args));
        }

        void IAsyncLog.Info(object message, Exception exception)
        {
            LogDisruptor(LogLevel.INFO, proTypeName, $"{message} {exception.Message} {exception.StackTrace}");
        }

        void IAsyncLog.Info(object message)
        {
            LogDisruptor(LogLevel.INFO, proTypeName, $"{message}");
        }

        void IAsyncLog.InfoFormat(string format, params object[] args)
        {
            LogDisruptor(LogLevel.INFO, proTypeName, string.Format(format, args));
        }

        void IAsyncLog.Warn(object message)
        {
            LogDisruptor(LogLevel.WARN, proTypeName, $"{message}");
        }

        void IAsyncLog.Warn(object message, Exception exception)
        {
            LogDisruptor(LogLevel.WARN, proTypeName, $"{message} {exception.Message} {exception.StackTrace}");
            //
        }

        void IAsyncLog.WarnFormat(string format, params object[] args)
        {
            LogDisruptor(LogLevel.WARN, proTypeName, string.Format(format, args));
        }
    }

    internal enum LogLevel : sbyte
    {
        INFO = 0, WARN, ERROR, FATAL
    }

    internal class LogEvent
    {
        internal long UtcTime { get; set; }

        internal LogLevel Level { get; set; }

        internal string Message { get; set; }
    }

}
