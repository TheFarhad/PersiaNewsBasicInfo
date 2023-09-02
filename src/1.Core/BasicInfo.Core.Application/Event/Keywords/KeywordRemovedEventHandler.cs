namespace BasicInfo.Core.Application.Event.Keywords;

using Sky.App.Core.Contract.Services.Event;
using Domain.Keywords.Aggregate.Event;

public class KeywordRemovedEventHandler : IEventHandler<KeywordRemovedEvent>
{
    public Task HandleAsync(KeywordRemovedEvent Source)
    {

        return Task.CompletedTask;
    }
}


