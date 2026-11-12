
using JB_aplicaciones_Deportiva.interfaces;
using JB_presentaciones_Deportiva.implementaciones;
using JB_presentaciones_Deportiva.interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();


builder.Services.AddScoped<IComunicaciones, Comunicaciones>();
builder.Services.AddScoped<IAuditoriasPresentacion, AuditoriasPresentacion>();
builder.Services.AddScoped<IBalonesPresentacion, BalonesPresentacion>();
builder.Services.AddScoped<ITiposPresentacion, TiposPresentacion>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();
app.Run();