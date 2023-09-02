namespace BasicInfo.Core.Application.Event.Categories;

using Sky.App.Core.Contract.Services.Event;
using Domain.Categories.Events;

public class CategoryRemovedEventHandler : IEventHandler<CategoryRemovedEvent>
{
    public Task HandleAsync(CategoryRemovedEvent Source)
    {

        return Task.CompletedTask;
    }
}

