namespace BasicInfo.Core.Application.Command.Keywords;

using System;
using System.Threading.Tasks;
using Sky.App.Core.Contract.Application.Command;

public class KeywordCreateCommand : ICommand<KeywordCreateData>
{
    public string Title { get; set; }
    public string Description { get; set; }
}

public class KeywordCreateCommandHandler : ICommandHandler<KeywordCreateCommand, KeywordCreateData>
{

    public KeywordCreateCommandHandler()
    {

    }

    public Task<CommandResult<KeywordCreateData>> HandleAsync(KeywordCreateCommand Source)
    {
        throw new NotImplementedException();
    }
}

public class KeywordCreateData
{
    public long Id { get; set; }
}