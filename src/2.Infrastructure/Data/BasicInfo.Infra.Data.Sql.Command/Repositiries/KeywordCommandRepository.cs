namespace BasicInfo.Infra.Data.Sql.Command.Repositiries;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sky.App.Infra.Data.Sql.Command;
using Sky.App.Core.Contract.Infrastructure.Command;
using Context;
using Core.Contract.Application.Command;
using Core.Domain.Keywords.Aggregate.Entity;

public class KeywordCommandRepository : CommandRepository<Keyword, BasicInfoCommandDbContext>, IKeywordCommandRepository
{
    public KeywordCommandRepository(BasicInfoCommandDbContext context) : base(context) { }

    public async Task<List<OutboxEvent>> Get(int maxCount = 100) =>
        await _context
        .OutboxEvents
        .Take(maxCount)
        .ToListAsync();

    public async Task MarkAsRead(List<OutboxEvent> outBoxEventItems)
    {

        await Task.CompletedTask;
    }
}
