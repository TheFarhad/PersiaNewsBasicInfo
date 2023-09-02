namespace BasicInfo.Core.Application.Event.Categories;

using Sky.App.Core.Contract.Services.Event;
using Domain.Categories.Events;

public class CategoryEditedEventHandler : IEventHandler<CategoryEditedEvent>
{
    public Task HandleAsync(CategoryEditedEvent Source)
    {

        return Task.CompletedTask;
    }
}

