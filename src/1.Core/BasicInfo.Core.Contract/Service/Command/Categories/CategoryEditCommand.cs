namespace BasicInfo.Core.Contract.Service.Command.Categories;

using Sky.App.Core.Contract.Services.Command;

public class CategoryEditCommand : ICommand<CategoryEditPayload>
{
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}

public class CategoryEditPayload
{
    public long Id { get; set; }
}

