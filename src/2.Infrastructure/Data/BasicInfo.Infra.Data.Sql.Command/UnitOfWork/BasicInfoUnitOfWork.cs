namespace BasicInfo.Infra.Data.Sql.Command.UnitOfWork;

using Sky.App.Infra.Data.Sql.Command;
using Context;
using Core.Contract.Infrastructure.Command;

public class BasicInfoUnitOfWork : UnitOfWork<BasicInfoCommandDbContext>, IBasicInfoUnitOfWork
{
    public BasicInfoUnitOfWork(BasicInfoCommandDbContext context) : base(context) { }
}
