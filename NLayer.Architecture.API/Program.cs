using DataAccess.Layer.FileRepositories;
using Microsoft.OpenApi.Models;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); //  Controllers handle incoming HTTP requests and send responses.
builder.Services.AddEndpointsApiExplorer(); // Generate descriptions of its HTTP endpoints
builder.Services.AddSwaggerGen(); // Registers the Swagger generator (OpenAPI description document)
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "UNA.FARM.API", Version = "v1" });
});


builder.Services.AddTransient<IReporteClimaService, ReporteClimaService>();
builder.Services.AddTransient<IFileRepository, FileRepository>();
builder.Services.AddTransient<IReporteClimaRepository, ReporteClimaRepository>();

builder.Services.AddTransient<IReporteInventarioService, ReporteInventarioService>();
builder.Services.AddTransient<IReporteInventarioRepository, ReporteInventarioRepository>();

builder.Services.AddTransient<IReporteAlimentacionService, ReporteAlimentacionService>();
builder.Services.AddTransient<IReporteAlimentacionRepository, ReporteAlimentacionRepository>();

builder.Services.AddTransient<IReportePlantaciones, ReportePlantaciones>();
builder.Services.AddTransient<IReportePlantacionesRepository,ReportePlantacionesRepository>();

//builder.Services.AddTransient<ICostosHigieneRepository, CostosHigieneRepository>();
//builder.Services.AddTransient<ICostosHigieneServices, HigieneServices>();

builder.Services.AddTransient<IReporteFinanzasRepository, ReporteFinanzasRepository>();
builder.Services.AddTransient<IReporteFinanzasServices, ReporteFinanzasServices>();

builder.Services.AddTransient<IPronosticoLluviasServices, PronosticoLluviasService>();
//builder.Services.AddTransient<IPronosticoLluviasRepository, PronosticoLluviasRepository>();


builder.Services.AddTransient<ICultivoService, CultivoService>();
builder.Services.AddTransient<ICultivoRepository, CultivoRepository>();


//builder.Services.AddTransient<ICostosHigieneRepository, CostosHigieneRepository>();
//builder.Services.AddTransient<ICostosHigieneServices, HigieneServices>();

builder.Services.AddTransient<ICultivoService, CultivoService>();
builder.Services.AddTransient<ICultivoRepository, CultivoRepository>();

builder.Services.AddTransient<IReporteInventarioRecursosServices, ReporteInventarioRecursosServices>();
builder.Services.AddTransient<IReporteInventarioRecursosRepository, ReporteInventarioRecursosRepository>();
// Add Singleton
// The same instance is used by all components requiring that service.

// Add Scoped
// Ideal for services that need to maintain consistent data within a request.
// consistent read and write operations. DbContext

// Add Transient
// Useful when the services have no state or hold only minimal state that is not shared.
// state must not be shared between requests or operations.

builder.Services.AddTransient<IGestorRiegoService, GestorRiegoService>();
builder.Services.AddTransient<IGestorRiegoRepository, GestorRiegoRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middlewares:
// .NET Routing
// Redirects the HTTP trafict to HTTPS
// Checks Request authorization.

app.UseHttpsRedirection(); 
app.UseAuthorization(); 
app.MapControllers(); 

app.Run();