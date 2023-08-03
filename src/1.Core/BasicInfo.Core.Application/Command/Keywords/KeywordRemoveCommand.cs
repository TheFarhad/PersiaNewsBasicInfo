namespace BasicInfo.Core.Application.Command.Keywords;

using System;
using Sky.App.Core.Domain.Aggregate;
using Sky.App.Core.Service.Command;
using Sky.App.Core.Contract.Application.Command;
using Contract.Application.Command;

public class KeywordRemoveCommand : ICommand
{
    public Guid Code { get; set; }
}

public class KeywordRemoveCommandHandler : CommandHandler<KeywordRemoveCommand>
{
    private readonly IKeywordCommandRepository _repository;

    public KeywordRemoveCommandHandler(IKeywordCommandRepository repository)
    {
        _repository = repository;
    }

    public override async Task<CommandResult> HandleAsync(KeywordRemoveCommand Source)
    {
        var model = await _repository.GetAsync(Code.Instance(Source.Code));
        _repository.Remove(model);
        await _repository.SaveAsync();
        return OK();
    }
}
