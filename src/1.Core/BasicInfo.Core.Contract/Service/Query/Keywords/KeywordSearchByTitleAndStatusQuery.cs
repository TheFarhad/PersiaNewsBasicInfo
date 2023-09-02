namespace BasicInfo.Core.Contract.Service.Query.Keywords;

using System;
using System.Collections.Generic;
using Sky.App.Core.Contract.Services.Query;

public class KeywordSearchByTitleAndStatusQuery : PageQuery<KeywordSearchByTitleAndStatusPayload>
{
    public string Title { get; set; }
    public string Status { get; set; }
}

public class KeywordSearchByTitleAndStatusPayload
{
    public List<KeywordSearchItem> Items { get; set; } = new();
    public int Total { get; set; }
}

public class KeywordSearchItem
{
    public long Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}
