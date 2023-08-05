namespace BasicInfo.Core.Contract.Service.Query.Keywords;

using System;
using System.Collections.Generic;
using Sky.App.Core.Contract.Services.Query;

public class KeywordSearchByTitleAndStatusQuery : PageQuery<KeywordSearchResult>
{
    public string Title { get; set; }
    public string Status { get; set; }
}

public class KeywordSearchResult
{
    public List<KeywordSearchItem> Items { get; set; } = new();
}

public class KeywordSearchItem
{
    public long Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}
