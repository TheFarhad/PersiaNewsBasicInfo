namespace BasicInfo.Core.Application.Query.Keywords;

using Sky.App.Core.Service.Query;
using Sky.App.Core.Contract.Services.Query;
using Contract.Infra.Query;
using Contract.Service.Query.Keywords;
using Sky.App.Core.Contract.Services.Shared;

public class KeywordSearchByTitleAndStatusQueryHandler : QueryHandler<KeywordSearchByTitleAndStatusQuery, KeywordSearchByTitleAndStatusPayload>
{
    private readonly IKeywordQueryRepository _repository;

    public KeywordSearchByTitleAndStatusQueryHandler(IKeywordQueryRepository repository) =>
            _repository = repository;

    public override async Task<QueryResult<KeywordSearchByTitleAndStatusPayload>> HandleAsync(KeywordSearchByTitleAndStatusQuery source)
    {
        var payload = await _repository.ListAsync(source);
        if (payload.Items.Any()) Result = await OK(payload);
        else
        {
            Result.Status = ServiceStatus.NotFound;
            Result.SetError("...");
        }
        return Result;
    }
}
