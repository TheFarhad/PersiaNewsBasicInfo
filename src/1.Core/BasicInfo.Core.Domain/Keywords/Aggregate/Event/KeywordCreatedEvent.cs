namespace BasicInfo.Core.Domain.Keywords.Aggregate.Event;

using Sky.App.Core.Domain.Aggregate;

public class KeywordCreatedEvent : IEvent
{
    public Guid Code { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Status { get; private set; }

    private KeywordCreatedEvent(Guid code, string title, string description, string status)
    {
        Code = code;
        Title = title;
        Description = description;
        Status = status;
    }

    public static KeywordCreatedEvent Instance(Guid code, string title, string description, string status) =>
        new KeywordCreatedEvent(code, title, description, status);
}