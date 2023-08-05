namespace BasicInfo.Core.Application.Command.Keywords;

using Sky.App.Core.Service.Command;
using Sky.App.Core.Contract.Services.Command;
using Contract.Infra.Command;
using Contract.Service.Command.Keywords;

public class KeywordRemoveCommandHandler : CommandHandler<KeywordRemoveCommand>
{
    private readonly IKeywordCommandRepository _repository;

    public KeywordRemoveCommandHandler(IKeywordCommandRepository repository)
    {
        _repository = repository;
    }

    public override async Task<CommandResult> HandleAsync(KeywordRemoveCommand Source)
    {
        var model = await _repository.GetGraphAsync(Source.Code);
        if (model is null) Result = await NotFound();
        else
        {
            _repository.Remove(model);
            await _repository.SaveAsync();
            Result = await OK();
        }
        return Result;
    }
}
