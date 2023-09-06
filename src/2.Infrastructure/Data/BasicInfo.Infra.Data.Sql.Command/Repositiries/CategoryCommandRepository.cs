namespace BasicInfo.Infra.Data.Sql.Command.Repositiries;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sky.App.Infra.Data.Sql.Command;
using Sky.App.Core.Contract.Infra.Command;
using Context;
using Core.Contract.Infra.Command;
using Core.Domain.Categories.Source;

public class CategoryCommandRepository : CommandRepository<Category, BasicInfoCommandDbContext>, ICategoryCommandRepository
{
    public CategoryCommandRepository(BasicInfoCommandDbContext context) : base(context) { }

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
