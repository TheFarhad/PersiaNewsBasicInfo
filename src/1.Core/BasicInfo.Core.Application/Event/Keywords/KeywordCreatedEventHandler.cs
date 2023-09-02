namespace BasicInfo.Core.Application.Event.Keywords;

using Sky.App.Core.Contract.Services.Event;
using Domain.Keywords.Aggregate.Event;

public class KeywordCreatedEventHandler : IEventHandler<KeywordCreatedEvent>
{
    public Task HandleAsync(KeywordCreatedEvent Source)
    {

        return Task.CompletedTask;
    }
}
