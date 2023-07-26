namespace BasicInfo.Core.Domain.Keywords.Aggregate.Event;

using Sky.App.Core.Domain.Aggregate;

public class KeywordEdited : IEvent
{
    public Guid Code { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    private KeywordEdited(Guid code, string title, string description)
    {
        Code = code;
        Title = title;
        Description = description;
    }

    public static KeywordEdited Instance(Guid code, string title, string description) =>
        new KeywordEdited(code, title, description);
}
