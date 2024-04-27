using DataAccess.Layer.FileRepositories;
using Microsoft.OpenApi.Models;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "UNA.FARM.API", Version = "v1" });
});

builder.Services.AddTransient<IReporteClimaService, ReporteClimaService>();
builder.Services.AddTransient<IFileRepository, FileRepository>();
builder.Services.AddTransient<IReporteClimaRepository, ReporteClimaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();