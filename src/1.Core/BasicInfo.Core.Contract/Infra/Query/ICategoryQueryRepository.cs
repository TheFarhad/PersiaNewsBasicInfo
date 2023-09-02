namespace BasicInfo.Core.Contract.Infra.Query;

using Sky.App.Core.Contract.Infra.Query;
using Service.Query.Categories;

public interface ICategoryQueryRepository : IQueryRepository
{
    Task<CategorySearchByTitlePayload> ListAsync(CategorySearchByTitleQuery source);
}
