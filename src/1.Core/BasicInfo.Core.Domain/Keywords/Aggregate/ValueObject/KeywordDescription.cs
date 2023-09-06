namespace BasicInfo.Core.Domain.Keywords.Aggregate.ValueObject;

using Sky.App.Core.Domain.Shared.ValueObjects;

public class KeywordDescription : EString
{
    private KeywordDescription() { }
    private KeywordDescription(string value) : base(value, 3, 500) { }

    public static KeywordDescription Instance(string value) => new KeywordDescription(value);

    public static explicit operator string(KeywordDescription source) => source.Value;
    public static implicit operator KeywordDescription(string source) => new(source);
}
