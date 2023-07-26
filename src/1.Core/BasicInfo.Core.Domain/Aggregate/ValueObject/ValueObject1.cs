namespace BasicInfo.Core.Domain.Aggregate.ValueObject;

using Sky.App.Core.Domain.Aggregate;

public class ValueObject1 : Element<ValueObject1>
{
    protected override IEnumerable<object> AttributesToEquality()
    {
        throw new NotImplementedException();
    }
}
