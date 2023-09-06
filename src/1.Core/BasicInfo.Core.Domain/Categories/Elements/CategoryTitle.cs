namespace BasicInfo.Core.Domain.Categories.Elements;

using Sky.App.Core.Domain.Shared.ValueObjects;

public class CategoryTitle : EString
{
    private CategoryTitle() { }
    private CategoryTitle(string value) : base(value, 2, 100) { }

    public static CategoryTitle Instance(string value) => new(value);

    public static explicit operator string(CategoryTitle source) => source.Value;
    public static implicit operator CategoryTitle(string source) => new(source);
}
