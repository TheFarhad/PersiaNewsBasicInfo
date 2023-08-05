namespace BasicInfo.Core.Contract.Service.Command.Keywords;

using Sky.App.Core.Contract.Services.Command;

public class KeywordCreateCommand : ICommand<KeywordCreatePayload>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}

public class KeywordCreatePayload
{
    public long Id { get; set; }
}