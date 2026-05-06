using Serilog;

var builder = WebApplication.CreateBuilder(args);

#region Logging Configuration
builder.Host.UseSerilog((context, services, configuration) => configuration
    .ReadFrom.Configuration(context.Configuration)
    .ReadFrom.Services(services));
#endregion

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

app.Run();

//Hola