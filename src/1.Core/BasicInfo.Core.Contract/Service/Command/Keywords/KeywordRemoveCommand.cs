namespace BasicInfo.Core.Contract.Service.Command.Keywords;

using System;
using Sky.App.Core.Contract.Services.Command;

public class KeywordRemoveCommand : ICommand
{
    public Guid Code { get; set; }
}
