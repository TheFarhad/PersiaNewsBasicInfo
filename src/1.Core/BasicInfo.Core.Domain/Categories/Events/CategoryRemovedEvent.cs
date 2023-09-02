namespace BasicInfo.Core.Domain.Categories.Events;

using Sky.App.Core.Domain.Aggregate;

public class CategoryRemovedEvent : IEvent
{
    public Guid Code { get; private set; }

    private CategoryRemovedEvent(Guid code) => Code = code;

    public static CategoryRemovedEvent Instance(Guid code) => new(code);
}