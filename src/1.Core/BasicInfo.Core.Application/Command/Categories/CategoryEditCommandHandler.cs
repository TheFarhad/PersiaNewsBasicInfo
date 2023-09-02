namespace BasicInfo.Core.Application.Command.Categories;

using Sky.App.Core.Service.Command;
using Sky.App.Core.Contract.Services.Command;
using Contract.Infra.Command;
using Contract.Service.Command.Categories;

public class CategoryEditCommandHandler : CommandHandler<CategoryEditCommand, CategoryEditPayload>
{
    private readonly ICategoryCommandRepository _repository;

    public CategoryEditCommandHandler(ICategoryCommandRepository repository) =>
        _repository = repository;

    public override async Task<CommandResult<CategoryEditPayload>> HandleAsync(CategoryEditCommand source)
    {
        var model = await _repository.GetAsync(source.Code);
        if (model is null) Result = await NotFound();
        else
        {
            model.Edit(source.Title, source.Description);
            await _repository.SaveAsync();
            Result = await OK(new CategoryEditPayload { Id = model.Id });
        }
        return Result;
    }
}
