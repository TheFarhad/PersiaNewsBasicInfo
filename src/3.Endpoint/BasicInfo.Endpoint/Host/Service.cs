namespace BasicInfo.Endpoint.Host;

using Microsoft.EntityFrameworkCore;
using Steeltoe.Discovery.Client;
using Sky.Kernel.Filing.Wireup;
using Sky.Kernel.Identity.Wireup;
using Sky.Kernel.Hashing.Wireup;
using Sky.Kernel.Serializing.Wireup;
using Sky.App.Endpoint.Api.Extentions;
using Sky.App.Infra.Data.Sql.Command.Interceptors;
using Infra.Data.Sql.Query.Context;
using Infra.Data.Sql.Command.Context;
using Services.Background;

internal static class Service
{
    internal static void Host(string[] args) => WebApplication.CreateBuilder(args).Services().Pipeline();
    private static WebApplication Services(this WebApplicationBuilder source)
    {
        var configration = source.Configuration;

        var commandDbConn = configration.GetConnectionString("BasicInfoCommandDbConn");
        var queryDbConn = configration.GetConnectionString("BasicInfoQueryDbConn");

        source
            .Services
            .AddDiscoveryClient()
            .AddDbContext<BasicInfoCommandDbContext>(_ =>
            {
                _
                .UseSqlServer(commandDbConn)
                .AddInterceptors(new EventSourcingCommandDbContextInterceptor());
            })
            .AddDbContext<BasicInfoQueryDbContext>(_ =>
            {
                _
                .UseSqlServer(queryDbConn);
            })
            .FilerWireup()
            .UploaderWireup()
            .NewtonSoftSerializerWireup()
            .BCryptHashingWireup()
            .FakeUserServiceWireup()
            .WebApiWireup("Sky", "BasicInfo")
            .AddEndpointsApiExplorer()
            .AddHostedService<KeywordPulisher>()
            .AddSwaggerGen();

        return source.Build();
    }
    private static void Pipeline(this WebApplication source)
    {
        if (source.Environment.IsDevelopment())
        {
            source.UseSwagger();
            source.UseSwaggerUI();
        }
        source.UseHttpsRedirection();
        source.UseAuthorization();
        source.MapControllers();
        source.Run();
    }
}
