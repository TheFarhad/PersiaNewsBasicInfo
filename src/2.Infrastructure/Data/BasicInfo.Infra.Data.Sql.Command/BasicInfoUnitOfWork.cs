namespace BasicInfo.Infra.Data.Sql.Command;

using Context;
using Sky.App.Infra.Data.Sql.Command;

public class BasicInfoUnitOfWork : UnitOfWork<BasicInfoCommandDbContext>, IBasicInfoUnitOfWork
{

    public BasicInfoUnitOfWork(BasicInfoCommandDbContext context) : base(context) { }
}
