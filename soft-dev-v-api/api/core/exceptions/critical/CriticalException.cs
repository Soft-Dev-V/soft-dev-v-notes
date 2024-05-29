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
      LogHandler.Instance.Log(Severity, current.Message);
      LogHandler.Instance.Log(Severity, current.StackTrace);
      current = current.InnerException;
    } while (current != null);
  }
}
