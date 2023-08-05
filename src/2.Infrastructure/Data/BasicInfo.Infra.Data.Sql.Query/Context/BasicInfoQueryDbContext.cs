namespace BasicInfo.Infra.Data.Sql.Query.Context;

using Microsoft.EntityFrameworkCore;
using Sky.App.Infra.Data.Sql.Query;
using Core.Contract.Infra.Query.Keywords;

public class BasicInfoQueryDbContext : QueryDbContext
{
    public DbSet<Keyword> Keywords => Set<Keyword>();

    public BasicInfoQueryDbContext(DbContextOptions<BasicInfoQueryDbContext> options) : base(options) { }
}

