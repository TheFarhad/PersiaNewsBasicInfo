namespace BasicInfo.Infra.Data.Sql.Command.Context;

using Microsoft.EntityFrameworkCore;
using Sky.App.Infra.Data.Sql.Command;
using Core.Domain.Categories.Source;
using Core.Domain.Keywords.Aggregate.Entity;
using Sky.App.Core.Domain.Shared.ValueObjects;
using Sky.App.Infra.Data.Sql.Command.ValueConversion;
using BasicInfo.Infra.Data.Sql.Command.Converters.Keywords;
using BasicInfo.Core.Domain.Keywords.Aggregate.ValueObject;
using BasicInfo.Core.Domain.Keywords.Aggregate.Enumers;

public class BasicInfoCommandDbContext : EventSourcingCommandDbContext
{
    public DbSet<Keyword> Keywords => Set<Keyword>();
    public DbSet<Category> Categories => Set<Category>();

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
        configurationBuilder.Properties<KeywordDescription>().HaveConversion<KeywordDescriptionConverter>();
        configurationBuilder.Properties<KeywordStatus>().HaveConversion<KeywordStatusConverter>();
        configurationBuilder.Properties<KeywordTitle>().HaveConversion<KeywordTitleConverter>();
    }
}
