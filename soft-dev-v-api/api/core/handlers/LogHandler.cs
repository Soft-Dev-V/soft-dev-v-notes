using Handlers;
using log4net;

public class LogHandler
{
  private readonly ILog _logger;
  private static LogHandler instance;

  public static LogHandler Instance => instance ?? (instance = new LogHandler());

  private LogHandler()
  {
    _logger = LogManager.GetLogger(typeof(LogHandler));
  }
  
  public void Log(Severity severity, string message)
  {
    switch (severity)
    {
      case Severity.DEBUG:
        _logger.Debug(message);
        break;
      case Severity.INFO:
        _logger.Info(message);
        break;
      case Severity.WARNING:
        _logger.Warn(message);
        break;
      case Severity.ERROR:
        _logger.Error(message);
        break;
      case Severity.FATAL:
        _logger.Fatal(message);
        break;
    }
  }
}