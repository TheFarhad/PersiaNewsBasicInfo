namespace BasicInfo.Infra.Data.Sql.Command.Converters;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Core.Domain.Keywords.Aggregate.ValueObject;

public class KeywordDescriptionConverter : ValueConverter<KeywordDescription, string>
{
    public KeywordDescriptionConverter()
        : base(_ => _.Value, _ => KeywordDescription.Instance(_)) { }

}
