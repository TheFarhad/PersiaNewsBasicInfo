namespace BasicInfo.Infra.Data.Sql.Command.Converters;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Core.Domain.Keywords.Aggregate.ValueObject;

public class KeywordTitleConverter : ValueConverter<KeywordTitle, string>
{
    public KeywordTitleConverter()
        : base(_ => _.Value, _ => KeywordTitle.Instance(_)) { }

}
