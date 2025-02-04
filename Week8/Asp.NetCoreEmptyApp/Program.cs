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

-Controller --> Kullan�c� isteklerini i�leyen ve modele/veritaban�na eri�erek uygun yan�t� d�nd�ren s�n�ft�r.

-Action --> Bir controller i�indeki belirli bir iste�i (GET, POST vb.) i�leyen metottur.

-Model --> Verileri temsil eden ve i� mant���n� ta��yan s�n�flard�r.

-View --> Kullan�c�ya g�sterilecek HTML sayfas�n� olu�turan dosyalard�r.

-Razor --> HTML i�inde C# kodlar�n� dinamik olarak yazmaya yarayan �ablon motorudur.

-RazorView --> Razor ile yaz�lm�� .cshtml uzant�l� g�r�n�mlerdir.

-wwwroot --> Statik dosyalar�n (CSS, JavaScript, resimler) sakland��� klas�rd�r.

-builder.Build() --> Uygulama nesnesini olu�turur ve middleware�leri yap�land�r�r.

-app.Run() -->  Uygulamay� ba�lat�r ve gelen HTTP isteklerini i�ler.
 
 */