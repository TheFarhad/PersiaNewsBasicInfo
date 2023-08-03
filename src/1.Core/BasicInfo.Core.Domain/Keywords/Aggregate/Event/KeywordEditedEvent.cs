namespace BasicInfo.Core.Domain.Keywords.Aggregate.Event;

using Sky.App.Core.Domain.Aggregate;

public class KeywordEditedEvent : IEvent
{
    public Guid Code { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    private KeywordEditedEvent(Guid code, string title, string description)
    {
        Code = code;
        Title = title;
        Description = description;
    }

    public static KeywordEditedEvent Instance(Guid code, string title, string description) =>
        new KeywordEditedEvent(code, title, description);
}
