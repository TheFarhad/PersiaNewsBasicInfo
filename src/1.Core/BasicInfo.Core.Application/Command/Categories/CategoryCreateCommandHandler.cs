namespace BasicInfo.Core.Application.Command.Categories;

using Sky.App.Core.Service.Command;
using Sky.App.Core.Contract.Services.Command;
using Contract.Infra.Command;
using Domain.Categories.Source;
using Contract.Service.Command.Categories;

public class CategoryCreateCommandHandler : CommandHandler<CategoryCreateCommand, CategoryCreatePayload>
{
    private readonly ICategoryCommandRepository _repository;

    public CategoryCreateCommandHandler(ICategoryCommandRepository repository) =>
        _repository = repository;

    public override async Task<CommandResult<CategoryCreatePayload>> HandleAsync(CategoryCreateCommand source)
    {
        var model = Category.Instance(source.Title, source.Description);
        await _repository.AddAsync(model);
        await _repository.SaveAsync();
        return await OK(new CategoryCreatePayload { Id = model.Id });
    }
}