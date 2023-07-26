namespace BasicInfo.Infra.Data.Sql.Command.Context;

using Microsoft.EntityFrameworkCore;
using Sky.App.Infra.Data.Sql.Command;
using Core.Domain.Keywords.Aggregate.Entity;

public class BasicInfoCommandDbContext : CommandDbContext
{
    public DbSet<Keyword> Keyword => Set<Keyword>();

    private BasicInfoCommandDbContext() { }
    public BasicInfoCommandDbContext(DbContextOptions<BasicInfoCommandDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}
