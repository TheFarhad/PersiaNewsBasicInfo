namespace BasicInfo.Infra.Data.Sql.Command.Converters.Keywords;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Core.Domain.Keywords.Aggregate.Enumers;

public class KeywordStatusConverter : ValueConverter<KeywordStatus, string>
{
    public KeywordStatusConverter() : base(_ => _.Value, _ => KeywordStatus.Instance(_)) { }

}