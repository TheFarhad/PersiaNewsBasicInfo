using BasicInfo.Endpoint.Extentions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.ServicesWireup();
app.MiddlewaresWireup();

