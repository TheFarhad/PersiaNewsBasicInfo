namespace BasicInfo.Core.Domain.Keywords.Aggregate.Event;

using Sky.App.Core.Domain.Aggregate.Event;

public class KeywordEditedEvent : IEvent
{
    public Guid Code { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Status { get; private set; }

    private KeywordEditedEvent(Guid code, string title, string description, string status)
    {
        Code = code;
        Title = title;
        Description = description;
        Status = status;
    }

    public static KeywordEditedEvent Instance(Guid code, string title, string description, string status) =>
        new KeywordEditedEvent(code, title, description, status);
}
