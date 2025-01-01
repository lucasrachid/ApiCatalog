using System.Text.Json.Serialization;
using ApiCatalog.Application.Mappings;
using ApiCatalog.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using ApiCatalog.Infrastructure.Configurations;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Configuration
    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "src", "Infrastructure"))
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

builder.Services.AddControllers()
    .AddJsonOptions(o => 
        o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    { 
        Title = "ApiCatalog", 
        Version = "v1",
        Description = "Udemy - API ApiCatalog"
    });
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("PostgresConnection")
    )
);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Services.AddApplicationServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiCatalog V1");
    });
}

app.MapControllers();

app.UseHttpsRedirection();
app.UseAuthorization();
app.Run();
