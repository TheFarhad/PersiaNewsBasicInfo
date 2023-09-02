namespace BasicInfo.Core.Contract.Service.Command.Categories;

using Sky.App.Core.Contract.Services.Command;

public class CategoryRemoveCommand : ICommand<CategoryRemovePayload>
{
    public Guid Code { get; set; }
}

public class CategoryRemovePayload
{

}
