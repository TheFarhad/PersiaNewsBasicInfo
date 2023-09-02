namespace BasicInfo.Infra.Data.Sql.Command.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sky.App.Infra.Data.Sql.Command.Configuration;
using Converters.Keywords;
using Core.Domain.Keywords.Aggregate.Entity;

public class KeywordConfig : IEntityConfig<Keyword>
{
    public void Configure(EntityTypeBuilder<Keyword> builder)
    {
        builder
            .ToTable("Keywords");

        builder
            .HasKey(_ => _.Id);

        builder
            .Property(_ => _.Title)
            .HasMaxLength(100)
             .HasConversion<KeywordTitleConverter>()
            .IsRequired();

        builder
            .Property(_ => _.Description)
            .HasMaxLength(500)
            .HasConversion<KeywordDescriptionConverter>();

        builder
            .Property(_ => _.Status)
            .HasMaxLength(30)
            .HasConversion<KeywordStatusConverter>();

        builder
            .HasIndex(_ => _.Title)
            .IsUnique();
    }
}