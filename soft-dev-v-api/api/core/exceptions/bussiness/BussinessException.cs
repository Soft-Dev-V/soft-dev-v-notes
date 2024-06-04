using Handlers;

public class BussinessException : AbstractException
{
  public BussinessException(string message)
  : base(message, Severity.WARNING)
  { }

  public override void LogMessages()
  {
    // TODO : LogFriendly Message
    _logHandler.Log(Severity, FriendlyMessage);
  }
}
