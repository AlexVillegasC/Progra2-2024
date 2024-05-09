using DataAccess.Layer.FileRepositories;
using Microsoft.OpenApi.Models;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Data;
using NLayer.Architecture.Data.FileRepositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); //  Controllers handle incoming HTTP requests and send responses.
builder.Services.AddEndpointsApiExplorer(); // Generate descriptions of its HTTP endpoints
builder.Services.AddSwaggerGen(); // Registers the Swagger generator (OpenAPI description document)
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "UNA.FARM.API", Version = "v1" });
});

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 2308f5c (Commenting for Education porpose)
=======
>>>>>>> d3ba865 (Commenting for Education porpose)
=======
>>>>>>> 6b45e76 (Commenting for Education porpose)

=======
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
<<<<<<< HEAD
<<<<<<< HEAD
=======

=======
>>>>>>> 006a680 (Commenting for Education porpose)
=======
>>>>>>> 2308f5c (Commenting for Education porpose)
=======
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
<<<<<<< HEAD
>>>>>>> d3ba865 (Commenting for Education porpose)
=======
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
>>>>>>> 6b45e76 (Commenting for Education porpose)
// Dependency Injection Configurations - DI container
// Services are created each time they are requested from the service container.

// 3 Main Objects Lifetime configuration.
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
>>>>>>> 6b45e76 (Commenting for Education porpose)
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
=======
>>>>>>> d3ba865 (Commenting for Education porpose)
>>>>>>> 495f6f5 (Commenting for Education porpose)
=======
=======
>>>>>>> 006a680 (Commenting for Education porpose)
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
=======
>>>>>>> 2308f5c (Commenting for Education porpose)
>>>>>>> 495f6f5 (Commenting for Education porpose)
builder.Services.AddTransient<IReporteClimaService, ReporteClimaService>();
builder.Services.AddTransient<IFileRepository, FileRepository>();
builder.Services.AddTransient<IReporteClimaRepository, ReporteClimaRepository>();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
builder.Services.AddTransient<IReporteRegistroGanadoRepository, ReporteRegistroGanadoRepository>();
=======
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
>>>>>>> a68434a (Cambios de CostosAlimenticios)

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 006a680 (Commenting for Education porpose)
=======
>>>>>>> 2308f5c (Commenting for Education porpose)
=======
>>>>>>> d3ba865 (Commenting for Education porpose)
=======
>>>>>>> 6b45e76 (Commenting for Education porpose)
builder.Services.AddTransient<IReporteInventarioService, ReporteInventarioService>();
builder.Services.AddTransient<IReporteInventarioRepository, ReporteInventarioRepository>();

>>>>>>> origin/development
builder.Services.AddTransient<IReporteAlimentacionService, ReporteAlimentacionService>();
builder.Services.AddTransient<IReporteAlimentacionRepository, ReporteAlimentacionRepository>();
builder.Services.AddTransient<IReporteRegistroGanadoService, ReporteRegistroGanadoService>();

builder.Services.AddTransient<IReportePlantaciones, ReportePlantaciones>();
builder.Services.AddTransient<IReportePlantacionesRepository,ReportePlantacionesRepository>();
=======
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
// Add Singleton
// The same instance is used by all components requiring that service.

<<<<<<< HEAD
=======
builder.Services.AddTransient<ICostosHigieneRepository, CostosHigieneRepository>();
builder.Services.AddTransient<ICostosHigieneServices, HigieneServices>();
// Add Singleton
// The same instance is used by all components requiring that service.

>>>>>>> origin/development
=======
// Add Singleton
// The same instance is used by all components requiring that service.

>>>>>>> 495f6f5 (Commenting for Education porpose)
// Add Scoped
// Ideal for services that need to maintain consistent data within a request.
// consistent read and write operations. DbContext

// Add Transient
// Useful when the services have no state or hold only minimal state that is not shared.
// state must not be shared between requests or operations.
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 495f6f5 (Commenting for Education porpose)

<<<<<<< HEAD
<<<<<<< HEAD
builder.Services.AddTransient<IReporteInventarioService, ReporteInventarioService>();
builder.Services.AddTransient<IReporteInventarioRepository, ReporteInventarioRepository>();

builder.Services.AddTransient<IReportePlantaciones, ReportePlantaciones>();
builder.Services.AddTransient<IReportePlantacionesRepository,ReportePlantacionesRepository>();

builder.Services.AddTransient<IReporteInventarioService, ReporteInventarioService>();
builder.Services.AddTransient<IReporteInventarioRepository, ReporteInventarioRepository>();

builder.Services.AddTransient<IReportePlantaciones, ReportePlantaciones>();
builder.Services.AddTransient<IReportePlantacionesRepository,ReportePlantacionesRepository>();

builder.Services.AddTransient<IReporteInventarioService, ReporteInventarioService>();
builder.Services.AddTransient<IReporteInventarioRepository, ReporteInventarioRepository>();

builder.Services.AddTransient<IReportePlantaciones, ReportePlantaciones>();
builder.Services.AddTransient<IReportePlantacionesRepository,ReportePlantacionesRepository>();

builder.Services.AddTransient<IReporteInventarioService, ReporteInventarioService>();
builder.Services.AddTransient<IReporteInventarioRepository, ReporteInventarioRepository>();

=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
=======
builder.Services.AddTransient<ICostosHigieneRepository, CostosHigieneRepository>();
builder.Services.AddTransient<ICostosHigieneServices, HigieneServices>();
>>>>>>> origin/development
// Add Singleton
// The same instance is used by all components requiring that service.

// Add Scoped
// Ideal for services that need to maintain consistent data within a request.
// consistent read and write operations. DbContext

// Add Transient
// Useful when the services have no state or hold only minimal state that is not shared.
// state must not be shared between requests or operations.

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
builder.Services.AddTransient<ICostosHigieneRepository, CostosHigieneRepository>();
builder.Services.AddTransient<ICostosHigieneServices, HigieneServices>();
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
<<<<<<< HEAD
=======
builder.Services.AddTransient<IReportePlantaciones, ReportePlantaciones>();
builder.Services.AddTransient<IReportePlantacionesRepository,ReportePlantacionesRepository>();

>>>>>>> 01278ca (cositas)
=======
builder.Services.AddTransient<IReporteInventarioService, ReporteInventarioService>();
builder.Services.AddTransient<IReporteInventarioRepository, ReporteInventarioRepository>();

>>>>>>> c6f87cd (se agregaron los servicios al program  y la ruta de los archivos json)
=======
>>>>>>> 495f6f5 (Commenting for Education porpose)
=======
builder.Services.AddTransient<ICostosHigieneRepository, CostosHigieneRepository>();
builder.Services.AddTransient<ICostosHigieneServices, HigieneServices>();
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
<<<<<<< HEAD
builder.Services.AddTransient<IReportePlantaciones, ReportePlantaciones>();
builder.Services.AddTransient<IReportePlantacionesRepository,ReportePlantacionesRepository>();

>>>>>>> 01278ca (cositas)
=======
builder.Services.AddTransient<IReporteInventarioService, ReporteInventarioService>();
builder.Services.AddTransient<IReporteInventarioRepository, ReporteInventarioRepository>();

>>>>>>> c6f87cd (se agregaron los servicios al program  y la ruta de los archivos json)
=======
>>>>>>> origin/development
=======
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
=======

>>>>>>> 495f6f5 (Commenting for Education porpose)
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 2308f5c (Commenting for Education porpose)
=======
=======
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
builder.Services.AddTransient<ICostosHigieneRepository, CostosHigieneRepository>();
builder.Services.AddTransient<ICostosHigieneServices, HigieneServices>();
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======

>>>>>>> 495f6f5 (Commenting for Education porpose)
>>>>>>> d3ba865 (Commenting for Education porpose)
=======
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
=======

>>>>>>> origin/development
<<<<<<< HEAD
>>>>>>> f932598 (Squashed commit of the following:)
=======
=======

>>>>>>> 495f6f5 (Commenting for Education porpose)
<<<<<<< HEAD
>>>>>>> 6b45e76 (Commenting for Education porpose)
=======
=======
builder.Services.AddTransient<ICostosHigieneRepository, CostosHigieneRepository>();
builder.Services.AddTransient<ICostosHigieneServices, HigieneServices>();
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
>>>>>>> a68434a (Cambios de CostosAlimenticios)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

app.UseHttpsRedirection(); 
app.UseAuthorization(); 
app.MapControllers(); 
>>>>>>> 495f6f5 (Commenting for Education porpose)

app.UseHttpsRedirection(); 
app.UseAuthorization(); 
app.MapControllers(); 
=======
>>>>>>> origin/development
=======
>>>>>>> 006a680 (Commenting for Education porpose)

app.UseHttpsRedirection(); 
app.UseAuthorization(); 
app.MapControllers(); 

app.Run();