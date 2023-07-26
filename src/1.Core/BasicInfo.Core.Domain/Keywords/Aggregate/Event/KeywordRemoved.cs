namespace BasicInfo.Core.Domain.Keywords.Aggregate.Event;

using Sky.App.Core.Domain.Aggregate;

public class KeywordRemoved : IEvent
{
    public string Code { get; private set; }

    private KeywordRemoved(string code) => Code = code;

    public static KeywordRemoved Instance(string code) => new KeywordRemoved(code);
}