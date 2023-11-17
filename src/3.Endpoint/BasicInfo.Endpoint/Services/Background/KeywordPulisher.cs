namespace BasicInfo.Endpoint.Services.Background;

using System.Text;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using Infra.Data.Sql.Command.Context;

public class KeywordPulisher : BackgroundService
{
    private readonly BasicInfoCommandDbContext _context;
    private readonly IModel _model;
    private readonly string _exchange = "PersiaNews";
    private readonly string _routeKey = "PersiaNews.BasicInfo.KeywordEventPulisher";

    public KeywordPulisher(IServiceProvider serviceProvider)
    {
        var connection = new ConnectionFactory
        {
            HostName = "localhost"
        }
        .CreateConnection();
        _model = connection.CreateModel();
        _model.ExchangeDeclare(_exchange, ExchangeType.Topic);

        _context = serviceProvider
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<BasicInfoCommandDbContext>();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var keywordEvents = await _context
                .OutboxEvents
                .Take(100)
                .Where(_ => _.AggregateName == "Keyword" && !_.IsProccessd)
                .ToListAsync();

            if (keywordEvents.Any())
            {
                keywordEvents.ForEach(_ =>
                {
                    _model.BasicPublish(_exchange, _routeKey, null, Encoding.UTF8.GetBytes(_.Payload));

                    _.IsProccessd = true;
                });
                await _context.SaveChangesAsync();
            }

            await Task.Delay(2000, stoppingToken);
        }
    }
}
