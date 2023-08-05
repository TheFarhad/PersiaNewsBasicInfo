namespace BasicInfo.Core.Contract.Infra.Query.Keywords;

public class Keyword
{
    public long Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}
