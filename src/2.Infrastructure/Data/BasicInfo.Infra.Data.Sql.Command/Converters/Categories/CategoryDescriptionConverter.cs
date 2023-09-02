namespace BasicInfo.Infra.Data.Sql.Command.Converters.Categories;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Core.Domain.Categories.Elements;

public class CategoryDescriptionConverter : ValueConverter<CategoryDescription, string>
{
    public CategoryDescriptionConverter() : base(_ => _.Value, _ => CategoryDescription.Instance(_)) { }
}
