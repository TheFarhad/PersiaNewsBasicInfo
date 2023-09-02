namespace BasicInfo.Core.Application.Query.Categories;

using Sky.App.Core.Service.Query;
using Sky.App.Core.Contract.Services.Query;
using Contract.Infra.Query;
using Contract.Service.Query.Categories;

public class CategorySearchByTitleQueryHandler : QueryHandler<CategorySearchByTitleQuery, CategorySearchByTitlePayload>
{
    private readonly ICategoryQueryRepository _repository;

    public CategorySearchByTitleQueryHandler(ICategoryQueryRepository repository) =>
        _repository = repository;

    public override async Task<QueryResult<CategorySearchByTitlePayload>> HandleAsync(CategorySearchByTitleQuery source)
    {
        var payload = await _repository.ListAsync(source);
        Result = payload.Items.Any() ? await OK(payload) : await NotFound();
        return Result;
    }
}
