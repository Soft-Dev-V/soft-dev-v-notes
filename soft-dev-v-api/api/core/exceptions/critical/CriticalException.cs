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
      current = current.InnerException;
    } while (current != null);
  }
}
