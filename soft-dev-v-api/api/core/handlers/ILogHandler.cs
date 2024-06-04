using Handlers;

public interface ILogHandler : IDisposable
{
  void Log(Severity severity, string message);
}
