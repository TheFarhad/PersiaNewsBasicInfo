namespace BasicInfo.Core.Domain.Keywords.Aggregate.Event;

using Sky.App.Core.Domain.Aggregate;

public class KeywordCreated : IEvent
{
    public Guid Code { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    private KeywordCreated(Guid code, string title, string description)
    {
        Code = code;
        Title = title;
        Description = description;
    }

    public static KeywordCreated Instance(Guid code, string title, string description) =>
        new KeywordCreated(code, title, description);
}