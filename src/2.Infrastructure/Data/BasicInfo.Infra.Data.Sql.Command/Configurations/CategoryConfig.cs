namespace BasicInfo.Infra.Data.Sql.Command.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sky.App.Infra.Data.Sql.Command.Configuration;
using Core.Domain.Categories.Source;
using Converters.Categories;

public class CategoryConfig : IEntityConfig<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
         .ToTable("Categories");

        builder
          .HasKey(_ => _.Id);

        builder
         .Property(_ => _.Title)
         .HasMaxLength(100)
         .HasConversion<CategoryTitleConverter>()
         .IsRequired();

        builder
         .Property(_ => _.Description)
         .HasMaxLength(500)
         .HasConversion<CategoryDescriptionConverter>();

        builder
         .HasIndex(_ => _.Title)
         .IsUnique();
    }
}
