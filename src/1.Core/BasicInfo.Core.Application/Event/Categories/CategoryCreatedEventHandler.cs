namespace BasicInfo.Core.Application.Event.Categories;

using Sky.App.Core.Contract.Services.Event;
using Domain.Categories.Events;

public class CategoryCreatedEventHandler : IEventHandler<CategoryCreatedEvent>
{
    public Task HandleAsync(CategoryCreatedEvent Source)
    {

        return Task.CompletedTask;
    }
}