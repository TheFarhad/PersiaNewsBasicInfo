namespace BasicInfo.Core.Contract.Service.Command.Categories;

using Sky.App.Core.Contract.Services.Command;

public class CategoryCreateCommand : ICommand<CategoryCreatePayload>
{
    public string Title { get; set; }
    public string Description { get; set; }
}

public class CategoryCreatePayload
{
    public long Id { get; set; }
}