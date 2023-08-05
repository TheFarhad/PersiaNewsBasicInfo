namespace BasicInfo.Endpoint.Extentions;

using Microsoft.EntityFrameworkCore;
using Sky.Kernel.Filing.Wireup;
using Sky.Kernel.Identity.Wireup;
using Sky.Kernel.Hashing.Wireup;
using Sky.Kernel.Serializing.Wireup;
using Sky.App.Endpoint.Api.Extentions;
using Sky.App.Infra.Data.Sql.Command.Interceptors;
using Infra.Data.Sql.Query.Context;
using Infra.Data.Sql.Command.Context;

public static class HostingExtentions
{
    public static void HostingWireup(this WebApplicationBuilder source) =>
         source
        .ServicesWireup()
        .MiddlewaresWireup();

    private static WebApplication ServicesWireup(this WebApplicationBuilder source)
    {
        var configration = source.Configuration;

        var commandDbConn = configration.GetConnectionString("BasicInfoCommandDbConn");
        var queryDbConn = configration.GetConnectionString("BasicInfoQueryDbConn");

        source.Services.AddDbContext<BasicInfoCommandDbContext>(_ =>
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
        .AddSwaggerGen();

        return source.Build();
    }

    private static void MiddlewaresWireup(this WebApplication source)
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
