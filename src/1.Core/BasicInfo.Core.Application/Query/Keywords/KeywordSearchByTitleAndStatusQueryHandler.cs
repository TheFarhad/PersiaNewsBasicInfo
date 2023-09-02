namespace BasicInfo.Core.Application.Query.Keywords;

using Sky.App.Core.Service.Query;
using Sky.App.Core.Contract.Services.Query;
using Contract.Infra.Query;
using Contract.Service.Query.Keywords;

public class KeywordSearchByTitleAndStatusQueryHandler : QueryHandler<KeywordSearchByTitleAndStatusQuery, KeywordSearchByTitleAndStatusPayload>
{
    private readonly IKeywordQueryRepository _repository;

    public KeywordSearchByTitleAndStatusQueryHandler(IKeywordQueryRepository repository) =>
            _repository = repository;

    public override async Task<QueryResult<KeywordSearchByTitleAndStatusPayload>> HandleAsync(KeywordSearchByTitleAndStatusQuery source)
    {
        var payload = await _repository.ListAsync(source);
        Result = payload.Items.Any() ? await OK(payload) : await NotFound();
        return Result;
    }
}
