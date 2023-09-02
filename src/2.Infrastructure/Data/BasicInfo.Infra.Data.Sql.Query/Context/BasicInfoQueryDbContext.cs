namespace BasicInfo.Infra.Data.Sql.Query.Context;

using Microsoft.EntityFrameworkCore;
using Sky.App.Infra.Data.Sql.Query;
using DbSets;
using Core.Contract.Infra.Query.Keywords;

public class BasicInfoQueryDbContext : QueryDbContext
{
    public DbSet<Keyword> Keywords => Set<Keyword>();
    public DbSet<Category> Categories => Set<Category>();

    public BasicInfoQueryDbContext(DbContextOptions<BasicInfoQueryDbContext> options) : base(options) { }
}

