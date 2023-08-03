namespace BasicInfo.Infra.Data.Sql.Command.Context;

using Microsoft.EntityFrameworkCore;
using Sky.App.Infra.Data.Sql.Command;
using Core.Domain.Keywords.Aggregate.Entity;

public class BasicInfoCommandDbContext : EventSourcingCommandDbContext
{
    public DbSet<Keyword> Keywords => Set<Keyword>();

    private BasicInfoCommandDbContext() { }
    public BasicInfoCommandDbContext(DbContextOptions<BasicInfoCommandDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
    }
}
