using Handlers;

public abstract class AbstractException : Exception
{
  public new Exception InnerException { get; set; }

  public string FriendlyMessage { get; set; }

  public Severity Severity { get; protected set; }

  public AbstractException(string friendlyMessage, Severity severity) 
  : base(friendlyMessage)
  {
    FriendlyMessage = friendlyMessage;
    Severity = severity;
  }

  public AbstractException(Exception innerException, string friendlyMessage, Severity severity)
  : this(friendlyMessage, severity)
  {
    InnerException = innerException;
  }

  public abstract void LogMessages();
}
