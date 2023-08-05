namespace BasicInfo.Core.Domain.Keywords.Aggregate.ValueObject;

using Sky.App.Core.Domain.Shared;

public class KeywordTitle : Title
{
    private KeywordTitle() { }
    private KeywordTitle(string value) : base(value, 3, 100) { }

    public static KeywordTitle Instance(string value) => new KeywordTitle(value);

    public static explicit operator string(KeywordTitle source) => source.Value;
    public static implicit operator KeywordTitle(string source) => new(source);
}