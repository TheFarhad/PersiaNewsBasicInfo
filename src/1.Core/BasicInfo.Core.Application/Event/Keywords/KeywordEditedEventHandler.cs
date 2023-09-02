namespace BasicInfo.Core.Application.Event.Keywords;

using Sky.App.Core.Contract.Services.Event;
using Domain.Keywords.Aggregate.Event;

public class KeywordEditedEventHandler : IEventHandler<KeywordEditedEvent>
{
    public Task HandleAsync(KeywordEditedEvent Source)
    {

        return Task.CompletedTask;
    }
}


