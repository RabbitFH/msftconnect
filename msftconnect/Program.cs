using Microsoft.Extensions.Hosting;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Host.UseWindowsService();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
