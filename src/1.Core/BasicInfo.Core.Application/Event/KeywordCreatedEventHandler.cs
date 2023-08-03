namespace BasicInfo.Core.Application.Event;

using Domain.Keywords.Aggregate.Event;
using Sky.App.Core.Contract.Application.Event;

public class KeywordCreatedEventHandler : IEventHandler<KeywordCreatedEvent>
{
    public Task HandleAsync(KeywordCreatedEvent Source)
    {

        return Task.CompletedTask;
    }
}
