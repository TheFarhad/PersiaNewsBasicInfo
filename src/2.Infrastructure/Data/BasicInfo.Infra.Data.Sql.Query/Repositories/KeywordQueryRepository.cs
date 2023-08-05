namespace BasicInfo.Infra.Data.Sql.Query.Repositories;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sky.Kernel.Extentions;
using Sky.App.Infra.Data.Sql.Query;
using Context;
using Core.Contract.Infra.Query;
using Core.Contract.Service.Query.Keywords;

public class KeywordQueryRepository : QueryRepository<BasicInfoQueryDbContext>, IKeywordQueryRepository
{
    public KeywordQueryRepository(BasicInfoQueryDbContext context) : base(context) { }

    public async Task<KeywordSearchResult> ListAsync(KeywordSearchByTitleAndStatusQuery source)
    {
        var query = Context.Keywords.AsNoTracking();
        if (source.Title.IsNotEmpty()) query = query.Where(_ => _.Title.Contains(source.Title));
        if (source.Status.IsNotEmpty()) query = query.Where(_ => _.Status == source.Status);

        var result = new KeywordSearchResult();
        result.Items = await query
            .OrderBy(source.SortBy, source.SortAscending)
            .Skip(source.Skip)
            .Take(source.Size)
            .Select(_ => new KeywordSearchItem
            {
                Id = _.Id,
                Code = _.Code,
                Title = _.Title,
                Description = _.Description,
                Status = _.Status
            })
            .ToListAsync();

        return result;
    }
}
