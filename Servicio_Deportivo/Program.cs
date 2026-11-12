using JB_aplicaciones_Deportiva.implementaciones;
using JB_aplicaciones_Deportiva.interfaces;
using JB_aplicaciones_Deportiva.nucleo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IConexion, Conexion>();
builder.Services.AddScoped<IBalonesAplicacion, BalonesAplicacion>();
builder.Services.AddScoped<IAuditoriasAplicacion, AuditoriasAplicacion>();
builder.Services.AddScoped<ITiposAplicacion, TiposAplicacion>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "");
app.Run();