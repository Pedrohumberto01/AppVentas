using AppVentas.Data;
using AppVentas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Conexi�n a MySQL
builder.Services.AddDbContext<VentasContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

//// Configuraci�n de Identity
//builder.Services.AddIdentity<Usuario, IdentityRole>()
//    .AddEntityFrameworkStores<VentasContext>()
//    .AddDefaultTokenProviders();

// Configuraci�n de cookies (opcional)
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Auth/Login"; // Ruta para el login
    options.AccessDeniedPath = "/Auth/AccessDenied"; // Ruta para acceso denegado
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Habilitar autenticaci�n y autorizaci�n
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Productos}/{action=Index}/{id?}");

app.Run();