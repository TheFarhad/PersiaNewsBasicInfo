namespace BasicInfo.Infra.Data.Sql.Query.Context;

using Microsoft.EntityFrameworkCore;
using Sky.App.Infra.Data.Sql.Query;

public class BasicInfoQueryDbContext : QueryDbContext
{

    public BasicInfoQueryDbContext(DbContextOptions<BasicInfoQueryDbContext> options) : base(options) { }
}

