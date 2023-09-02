namespace BasicInfo.Infra.Data.Sql.Query.Repositories;

using Microsoft.EntityFrameworkCore;
using Sky.Kernel.Extentions;
using Sky.App.Infra.Data.Sql.Query;
using Data.Sql.Query.Context;
using Core.Contract.Infra.Query;
using Core.Contract.Service.Query.Categories;

public class CategoryQueryRepository : QueryRepository<BasicInfoQueryDbContext>, ICategoryQueryRepository
{
    public CategoryQueryRepository(BasicInfoQueryDbContext context) : base(context) { }

    public async Task<CategorySearchByTitlePayload> ListAsync(CategorySearchByTitleQuery source)
    {
        var result = new CategorySearchByTitlePayload();
        var query = Context.Categories.AsNoTracking();

        if (source.NeededTotalCount) result.Total = await query.CountAsync();
        if (source.Title.IsNotEmpty())
            query = query
                .Where(_ => _.Title.Contains(source.Title))
                .OrderBy(source.SortBy, source.SortAscending);

        result.Items = await query
        .Select(_ => new CategorySearchItem
        {
            Id = _.Id,
            Code = _.Code,
            Title = _.Title,
            Description = _.Description
        })
        .ToListAsync();
        return result;
    }
}
