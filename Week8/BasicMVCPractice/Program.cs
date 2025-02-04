using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// MVC hizmetlerini ekleme
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

// Varsayýlan route ayarý
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CustomerOrders}/{action=Index}/{id?}");

app.Run();
