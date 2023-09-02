namespace BasicInfo.Infra.Data.Sql.Command.Converters.Categories;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Core.Domain.Categories.Elements;

public class CategoryTitleConverter : ValueConverter<CategoryTitle, string>
{
    public CategoryTitleConverter() : base(_ => _.Value, _ => CategoryTitle.Instance(_)) { }
}