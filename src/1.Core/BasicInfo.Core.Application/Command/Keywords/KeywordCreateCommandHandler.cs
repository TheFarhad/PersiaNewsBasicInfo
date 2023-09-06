namespace BasicInfo.Core.Application.Command.Keywords;

using System.Threading.Tasks;
using Sky.App.Core.Service.Command;
using Sky.App.Core.Contract.Services.Command;
using Core.Contract.Infra.Command;
using Domain.Keywords.Aggregate.Entity;
using Contract.Service.Command.Keywords;
using Domain.Keywords.Aggregate.Enumers;
using Sky.App.Core.Domain.Shared.ValueObjects;

public class KeywordCreateCommandHandler : CommandHandler<KeywordCreateCommand, KeywordCreatePayload>
{
    private readonly IKeywordCommandRepository _repository;

    public KeywordCreateCommandHandler(IKeywordCommandRepository repository) =>
        _repository = repository;

    public override async Task<CommandResult<KeywordCreatePayload>> HandleAsync(KeywordCreateCommand source)
    {
        var model = Keyword.Instnce(source.Title, source.Description, KeywordStatus.Instance(source.Status));
        await _repository.AddAsync(model);
        await _repository.SaveAsync();
        return await OK(new KeywordCreatePayload { Id = model.Id });
    }
}