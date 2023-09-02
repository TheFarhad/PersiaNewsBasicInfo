namespace BasicInfo.Core.Contract.Service.Query.Categories;

using Sky.App.Core.Contract.Services.Query;

public class CategorySearchByTitleQuery : PageQuery<CategorySearchByTitlePayload>
{
    public string Title { get; set; }
}

public class CategorySearchByTitlePayload
{
    public List<CategorySearchItem> Items { get; set; }
    public int Total { get; set; }

    public CategorySearchByTitlePayload()
    {
        Items = new();
    }
}

public class CategorySearchItem
{
    public long Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}


