namespace BasicInfo.Core.Application.Command.Categories;

using Sky.App.Core.Service.Command;
using Sky.App.Core.Contract.Services.Command;
using Contract.Infra.Command;
using Contract.Service.Command.Categories;

public class CategoryRemoveCommandHandler : CommandHandler<CategoryRemoveCommand, CategoryRemovePayload>
{
    private readonly ICategoryCommandRepository _repository;

    public CategoryRemoveCommandHandler(ICategoryCommandRepository repository) =>
        _repository = repository;

    public override async Task<CommandResult<CategoryRemovePayload>> HandleAsync(CategoryRemoveCommand source)
    {
        var model = await _repository.GetAsync(source.Code);
        if (model is null) Result = await NotFound();
        else
        {
            _repository.Remove(model);
            await _repository.SaveAsync();
            Result = await OK(null);
        }
        return Result;
    }
}
