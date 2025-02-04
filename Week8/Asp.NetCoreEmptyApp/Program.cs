var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
/*
 ASP.NET Core MVC Temel Kavramlar ve Metotlar

-Controller --> Kullanýcý isteklerini iþleyen ve modele/veritabanýna eriþerek uygun yanýtý döndüren sýnýftýr.

-Action --> Bir controller içindeki belirli bir isteði (GET, POST vb.) iþleyen metottur.

-Model --> Verileri temsil eden ve iþ mantýðýný taþýyan sýnýflardýr.

-View --> Kullanýcýya gösterilecek HTML sayfasýný oluþturan dosyalardýr.

-Razor --> HTML içinde C# kodlarýný dinamik olarak yazmaya yarayan þablon motorudur.

-RazorView --> Razor ile yazýlmýþ .cshtml uzantýlý görünümlerdir.

-wwwroot --> Statik dosyalarýn (CSS, JavaScript, resimler) saklandýðý klasördür.

-builder.Build() --> Uygulama nesnesini oluþturur ve middleware’leri yapýlandýrýr.

-app.Run() -->  Uygulamayý baþlatýr ve gelen HTTP isteklerini iþler.
 
 */