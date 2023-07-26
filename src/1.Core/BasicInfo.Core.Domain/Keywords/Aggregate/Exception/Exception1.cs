namespace BasicInfo.Core.Domain.Keywords.Aggregate.Exception;

using Sky.App.Core.Domain.Aggregate;

public class Exception1 : InvalidEntityStateException
{

    public Exception1(string message, params string[] args) : base(message, args) { }
}
