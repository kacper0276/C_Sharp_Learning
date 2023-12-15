var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
app.MapGet("/api/mini", () => Results.Ok("MinimalApi"));
app.MapPost("/api/hc", (int id) => Results.Ok($"Created{id}"));

app.Run();
