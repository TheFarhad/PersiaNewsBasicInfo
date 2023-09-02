namespace BasicInfo.Infra.Data.Sql.Query.DbSets;

public class Category
{
    public long Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
