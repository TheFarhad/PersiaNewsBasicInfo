namespace BasicInfo.Core.Contract.Service.Command.Keywords;

using Sky.App.Core.Contract.Services.Command;

public class KeywordEditCommand : ICommand<KeywordEditPayload>
{
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}

public class KeywordEditPayload : KeywordCreatePayload
{

}