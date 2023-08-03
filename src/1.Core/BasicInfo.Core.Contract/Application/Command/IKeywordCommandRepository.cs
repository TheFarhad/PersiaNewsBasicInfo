namespace BasicInfo.Core.Contract.Application.Command;

using Sky.App.Core.Contract.Infrastructure.Command;
using Domain.Keywords.Aggregate.Entity;

public interface IKeywordCommandRepository : ICommandRepository<Keyword>, IEventSorcingRepository { }
