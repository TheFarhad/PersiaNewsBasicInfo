namespace BasicInfo.Core.Application.Command.Keywords;

using Sky.Kernel.Extentions;
using System.Threading.Tasks;
using Sky.App.Core.Service.Command;
using Sky.App.Core.Contract.Services.Shared;
using Sky.App.Core.Contract.Services.Command;
using Contract.Infra.Command;
using Contract.Service.Command.Keywords;
using Domain.Keywords.Aggregate.Enumers;

public class KeywordEditCommandHandler : CommandHandler<KeywordEditCommand, KeywordEditPayload>
{
    private readonly IKeywordCommandRepository _repository;

    public KeywordEditCommandHandler(IKeywordCommandRepository repository) =>
        _repository = repository;

    public override async Task<CommandResult<KeywordEditPayload>> HandleAsync(KeywordEditCommand source)
    {
        var model = await _repository.GetGraphAsync(source.Code);
        if (model is null) Result = await NotFound();
        else
        {
            model.Edit(source.Title, source.Description, KeywordStatus.Instance(source.Status));
            await _repository.SaveAsync();
            Result = await OK(new KeywordEditPayload { Id = model.Id });
        }
        return Result;
    }
}