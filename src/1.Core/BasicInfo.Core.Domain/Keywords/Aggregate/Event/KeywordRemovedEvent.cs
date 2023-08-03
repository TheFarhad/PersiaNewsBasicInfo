namespace BasicInfo.Core.Domain.Keywords.Aggregate.Event;

using Sky.App.Core.Domain.Aggregate;

public class KeywordRemovedEvent : IEvent
{
    public string Code { get; private set; }

    private KeywordRemovedEvent(string code) => Code = code;

    public static KeywordRemovedEvent Instance(string code) => new KeywordRemovedEvent(code);
}