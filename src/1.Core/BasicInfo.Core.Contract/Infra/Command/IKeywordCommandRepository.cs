namespace BasicInfo.Core.Contract.Infra.Command;

using Sky.App.Core.Contract.Infra.Command;
using Domain.Keywords.Aggregate.Entity;

public interface IKeywordCommandRepository : ICommandRepository<Keyword>, IEventSorcingRepository { }
