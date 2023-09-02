namespace BasicInfo.Core.Contract.Infra.Command;

using Sky.App.Core.Contract.Infra.Command;
using Domain.Categories.Source;

public interface ICategoryCommandRepository : ICommandRepository<Category>, IEventSorcingRepository { }
