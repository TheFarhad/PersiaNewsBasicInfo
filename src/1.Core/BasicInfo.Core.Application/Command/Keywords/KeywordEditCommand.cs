namespace BasicInfo.Core.Application.Command.Keywords;

using System.Threading.Tasks;
using Sky.App.Core.Contract.Application.Command;

public class KeywordEditCommand : ICommand<KeywordEditData>
{
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}

public class KeywordEditCommandHandler : ICommandHandler<KeywordEditCommand, KeywordEditData>
{

    public KeywordEditCommandHandler()
    {

    }

    public Task<CommandResult<KeywordEditData>> HandleAsync(KeywordEditCommand Source)
    {
        throw new NotImplementedException();
    }
}

public class KeywordEditData : KeywordCreateData
{

}