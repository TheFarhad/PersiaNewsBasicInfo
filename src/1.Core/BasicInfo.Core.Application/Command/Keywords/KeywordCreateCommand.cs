namespace BasicInfo.Core.Application.Command.Keywords;

using System.Threading.Tasks;
using Sky.App.Core.Contract.Application.Command;
using Sky.App.Core.Domain.Shared;
using Sky.App.Core.Service.Command;
using Contract.Application.Command;
using Domain.Keywords.Aggregate.Entity;

public class KeywordCreateCommand : ICommand<KeywordCreateData>
{
    public string Title { get; set; }
    public string Description { get; set; }
}

public class KeywordCreateCommandHandler : CommandHandler<KeywordCreateCommand, KeywordCreateData>
{
    private readonly IKeywordCommandRepository _repository;

    public KeywordCreateCommandHandler(IKeywordCommandRepository repository)
    {
        _repository = repository;
    }

    public override async Task<CommandResult<KeywordCreateData>> HandleAsync(KeywordCreateCommand Source)
    {
        var keyword = Keyword.Instnce(Title.Instance(Source.Title), Description.Instance(Source.Description));
        await _repository.AddAsync(keyword);
        await _repository.SaveAsync();
        return await OK(new KeywordCreateData());
    }
}

public class KeywordCreateData
{
    public long Id { get; set; }
}