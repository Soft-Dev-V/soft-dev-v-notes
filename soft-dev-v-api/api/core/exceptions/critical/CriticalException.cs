using Handlers;

public class CriticalException : AbstractException
{
  public CriticalException(Exception exception)
  : base(exception,
        "Something wrong happen. Please contact your System Administrator",
        Severity.ERROR)
  {

  }

  public override void LogMessages()
  {
    var current = InnerException;
    do
    {
      // TODO : LogMessage
      _logHandler.Log(Severity, current.Message);
      _logHandler.Log(Severity, current.StackTrace);
      current = current.InnerException;
    } while (current != null);
  }
}
