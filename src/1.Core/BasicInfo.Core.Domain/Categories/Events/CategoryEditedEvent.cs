namespace BasicInfo.Core.Domain.Categories.Events;

using Sky.App.Core.Domain.Aggregate;

public class CategoryEditedEvent : IEvent
{
    public Guid Code { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    private CategoryEditedEvent(Guid code, string title, string dexcription)
    {
        Code = code;
        Title = title;
        Description = dexcription;
    }

    public static CategoryEditedEvent Instance(Guid code, string title, string dexcription) => new(code, title, dexcription);
}
