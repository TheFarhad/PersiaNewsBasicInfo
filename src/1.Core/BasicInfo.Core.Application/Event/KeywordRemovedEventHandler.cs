namespace BasicInfo.Core.Application.Event;

using Domain.Keywords.Aggregate.Event;
using Sky.App.Core.Contract.Services.Event;

public class KeywordRemovedEventHandler : IEventHandler<KeywordRemovedEvent>
{
    public Task HandleAsync(KeywordRemovedEvent Source)
    {

        return Task.CompletedTask;
    }
}


