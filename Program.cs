var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Sirve wwwroot/index.html en la ruta "/" y el resto de archivos estáticos (css, js, images).
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
