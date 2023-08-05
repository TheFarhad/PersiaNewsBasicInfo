namespace BasicInfo.Core.Application.Event;

using Domain.Keywords.Aggregate.Event;
using Sky.App.Core.Contract.Services.Event;

public class KeywordEditedEventHandler : IEventHandler<KeywordEditedEvent>
{
    public Task HandleAsync(KeywordEditedEvent Source)
    {

        return Task.CompletedTask;
    }
}


