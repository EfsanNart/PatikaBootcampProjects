using DependencyInjectionPractice.Interfaces;
using DependencyInjectionPractice.Services;

var builder = WebApplication.CreateBuilder(args);

// Service Lifetime Kaydý (Scoped, Transient, Singleton)
builder.Services.AddScoped<ITeacher, TeacherService>(); // Scoped olarak ekledim

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
