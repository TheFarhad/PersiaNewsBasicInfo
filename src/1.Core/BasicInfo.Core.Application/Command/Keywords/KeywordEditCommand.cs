namespace BasicInfo.Core.Application.Command.Keywords;

using System.Threading.Tasks;
using Sky.App.Core.Domain.Shared;
using Sky.App.Core.Service.Command;
using Sky.App.Core.Contract.Application.Command;
using Core.Contract.Application.Command;
using Domain.Keywords.Aggregate.Enumers;

public class KeywordEditCommand : ICommand<KeywordEditData>
{
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}

public class KeywordEditCommandHandler : CommandHandler<KeywordEditCommand, KeywordEditData>
{
    private readonly IKeywordCommandRepository _repository;

    public KeywordEditCommandHandler(IKeywordCommandRepository repository)
    {
        _repository = repository;
    }

    public override async Task<CommandResult<KeywordEditData>> HandleAsync(KeywordEditCommand source)
    {
        var model = await _repository.GetAsync(source.Code);
        model?.Edit(Title.Instance(source.Title), Description.Instance(source.Description), KeywordStatus.Instance(source.Status));
        await _repository.SaveAsync();

        return await OK(new KeywordEditData());
    }
}

public class KeywordEditData : KeywordCreateData
{

}