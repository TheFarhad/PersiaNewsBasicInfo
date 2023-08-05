namespace BasicInfo.Core.Contract.Infra.Query;

using Sky.App.Core.Contract.Infra.Query;
using Service.Query.Keywords;

public interface IKeywordQueryRepository : IQueryRepository
{
    Task<KeywordSearchResult> ListAsync(KeywordSearchByTitleAndStatusQuery source);
}
