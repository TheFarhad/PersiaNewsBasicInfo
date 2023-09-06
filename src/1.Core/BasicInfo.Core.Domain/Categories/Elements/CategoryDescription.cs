namespace BasicInfo.Core.Domain.Categories.Elements;

using Sky.App.Core.Domain.Shared.ValueObjects;

public class CategoryDescription : EString
{
    private CategoryDescription() { }
    private CategoryDescription(string value) : base(value, 2, 500) { }

    public static CategoryDescription Instance(string value) => new(value);

    public static explicit operator string(CategoryDescription source) => source.Value;
    public static implicit operator CategoryDescription(string source) => new(source);
}
