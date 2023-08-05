namespace BasicInfo.Core.Application.Command.Keywords;

using System.Threading.Tasks;
using Sky.App.Core.Service.Command;
using Sky.App.Core.Contract.Services.Command;
using Core.Contract.Infra.Command;
using Domain.Keywords.Aggregate.Entity;
using Contract.Service.Command.Keywords;
using Domain.Keywords.Aggregate.Enumers;

public class KeywordCreateCommandHandler : CommandHandler<KeywordCreateCommand, KeywordCreatePayload>
{
    private readonly IKeywordCommandRepository _repository;

    public KeywordCreateCommandHandler(IKeywordCommandRepository repository) =>
        _repository = repository;

    public override async Task<CommandResult<KeywordCreatePayload>> HandleAsync(KeywordCreateCommand Source)
    {
        var keyword = Keyword.Instnce(Source.Title, Source.Description, KeywordStatus.Instance(Source.Status));
        await _repository.AddAsync(keyword);
        await _repository.SaveAsync();
        return await OK(new KeywordCreatePayload { Id = keyword.Id });
    }
}