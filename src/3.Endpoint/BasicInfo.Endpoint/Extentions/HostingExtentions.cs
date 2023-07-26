namespace BasicInfo.Endpoint.Extentions;

using Microsoft.EntityFrameworkCore;
using Sky.App.Endpoint.Api.Extentions;
using BasicInfo.Infra.Data.Sql.Query.Context;
using BasicInfo.Infra.Data.Sql.Command.Context;
using Sky.App.Infra.Data.Sql.Command.Interceptor;

public static class HostingExtentions
{
    public static WebApplication ServicesWireup(this WebApplicationBuilder source)
    {
        var commandDbConn = source.Configuration.GetConnectionString("BasicInfoCommandDbConn");
        var queryDbConn = source.Configuration.GetConnectionString("BasicInfoQueryDbConn");

        source.Services.AddDbContext<BasicInfoCommandDbContext>(_ =>
        {
            _
            .UseSqlServer(commandDbConn)
            .AddInterceptors(new CommandDbContextInterceptor());
        });

        source.Services.AddDbContext<BasicInfoQueryDbContext>(_ =>
        {
            _.UseSqlServer(queryDbConn);
        });

        source.Services.WebApiWireup("Sky", "BasicInfo");
        source.Services.AddEndpointsApiExplorer();
        source.Services.AddSwaggerGen();
        return source.Build();
    }

    public static void MiddlewaresWireup(this WebApplication source)
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
