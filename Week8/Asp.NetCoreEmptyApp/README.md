# ASP.NET Core Empty Project Setup 🚀

## Overview 📝
This project is a basic **ASP.NET Core Empty** application structured following the **MVC (Model-View-Controller) design pattern**. It includes necessary folders and configurations to support MVC architecture.

## Folder Structure 📂

The project consists of the following directories:

- **Controllers/** 🏗️ - Contains the controllers that handle HTTP requests.
- **Models/** 📄 - Holds the data models used by the application.
- **Views/** 🖼️ - Contains Razor views to present data to the user.
- **wwwroot/** 🌍 - Stores static files such as CSS, JavaScript, and images.

## Configuration Steps ⚙️

### 1️⃣ Adding MVC Services
Modify `Program.cs` to add MVC services:
```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
```

### 2️⃣ Enabling Static Files
Enable static files so that assets from the `wwwroot` folder can be served:
```csharp
var app = builder.Build();
app.UseStaticFiles();
```

### 3️⃣ Setting Up Routing
Define routing to direct requests correctly to controllers and views:
```csharp
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
```

### 4️⃣ Running the Application
Finally, start the application with:
```csharp
app.Run();
```

## Key Concepts 💡

### MVC Components 🏛️
- **Controller** 🎮 - Handles incoming requests and returns appropriate responses.
- **Model** 📊 - Represents the data structure and business logic.
- **View** 👁️ - Defines the UI using Razor syntax.
- **Razor** ⚡ - A templating engine to embed C# in HTML.
- **RazorView** 📜 - The rendered output of a Razor page.

### Core Methods ⚙️
- **builder.Build()** 🏗️ - Constructs the application pipeline.
- **app.Run()** 🚀 - Runs the web application and listens for requests.

---
🎯 This project serves as a foundation for building ASP.NET Core MVC applications efficiently!
