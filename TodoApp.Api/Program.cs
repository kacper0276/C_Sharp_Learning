using Microsoft.Extensions.Options;
using TodoApp.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<AppOptions>(builder.Configuration.GetSection("app"));

builder.Services.AddHostedService<HostedServiceTest>();

// Kontener IoS - druga opcja(bind)
//var appOptions = new AppOptions();
// builder.Configuration.GetSection("app").Bind(appOptions);
// builder.Services.AddSingleton<AppOptions>(appOptions);

var app = builder.Build();
var options = app.Services.GetRequiredService<IOptions<AppOptions>>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

// Minimal API
app.MapGet("/api/hc", async (_) => await Task.FromResult("TodoApp!"));
app.MapGet("/api/mini", (IOptionsMonitor<AppOptions> options) => options.CurrentValue);
app.MapPost("/api/hc", (int id) => Results.Ok($"Created{id}"));

app.Run();

class HostedServiceTest : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}