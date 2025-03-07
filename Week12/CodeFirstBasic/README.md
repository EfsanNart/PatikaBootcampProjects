# 🎮🎬 PatikaFirst API

A simple RESTful API built with ASP.NET Core and Entity Framework Core using Code-First approach. This project allows you to manage a collection of **Games** and **Movies** with CRUD operations. 🚀

## 📌 Features
- 🎮 **Games API** - Manage your favorite games with platform and rating.
- 🎬 **Movies API** - Store movie details including genre and release year.
- 🏗 **Code-First Approach** - Database is created using EF Core Migrations.
- 🛠 **Fluent API Configuration** - Entities are configured with Fluent API.
- 📜 **Swagger Documentation** - Easily test API endpoints with Swagger UI.
- ✅ **Seed Data Included** - The database starts with preloaded games and movies.

## 🏗 Tech Stack
- 🌐 **ASP.NET Core 7** - Web API framework
- 🛢 **Entity Framework Core** - ORM for database operations
- 💾 **SQL Server** - Database management system
- 🔥 **Swagger (Swashbuckle)** - API documentation and testing

## 🚀 Getting Started

### 🔧 Prerequisites
Ensure you have the following installed:
- ✅ .NET 7 SDK
- ✅ SQL Server
- ✅ Visual Studio / VS Code

### 📥 Installation
1. **Clone the Repository**
   ```sh
   git clone https://github.com/your-username/PatikaFirstAPI.git
   cd PatikaFirstAPI
   ```
2. **Install Required Packages**
   ```sh
   dotnet restore
   ```
3. **Update Database** (Run Migrations)
   ```sh
   dotnet ef migrations add SeedData
   dotnet ef database update
   ```
4. **Run the Application**
   ```sh
   dotnet run
   ```
5. **Access Swagger UI**
   Open [https://localhost:5001/swagger](https://localhost:5001/swagger) to explore API endpoints.

## 🔗 API Endpoints

### 🎮 Games API
| Method  | Endpoint        | Description           |
|---------|----------------|-----------------------|
| GET     | /api/games     | Get all games        |
| GET     | /api/games/{id} | Get a single game by ID |
| POST    | /api/games     | Add a new game       |
| PUT     | /api/games/{id} | Update an existing game |
| DELETE  | /api/games/{id} | Delete a game        |

### 🎬 Movies API
| Method  | Endpoint        | Description           |
|---------|----------------|-----------------------|
| GET     | /api/movies    | Get all movies       |
| GET     | /api/movies/{id} | Get a single movie by ID |
| POST    | /api/movies    | Add a new movie      |
| PUT     | /api/movies/{id} | Update an existing movie |
| DELETE  | /api/movies/{id} | Delete a movie      |

## 🛠 Configuration

### 🔗 Database Connection
Edit the `appsettings.json` file to configure your SQL Server connection:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=LAPTOP-IOOHI3VQ\\SQLEXPRESS;Database=PatikaFirstDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```


## 🛠 Dependencies
Make sure these NuGet packages are installed:
```sh
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Swashbuckle.AspNetCore
dotnet add package Microsoft.AspNetCore.Mvc.Core
```

## ✅ Preloaded Data (Seed Data)
When the database is created, it will include these initial games and movies:

### 🎮 Preloaded Games
| ID | Name               | Platform | Rating |
|----|--------------------|----------|--------|
| 1  | The Witcher 3      | PC       | 9.5    |
| 2  | God of War         | PS5      | 9.8    |
| 3  | Cyberpunk 2077     | PC       | 8.0    |

### 🎬 Preloaded Movies
| ID | Title             | Genre   | Release Year |
|----|------------------|---------|--------------|
| 1  | Inception        | Sci-Fi  | 2010         |
| 2  | The Dark Knight  | Action  | 2008         |
| 3  | Interstellar     | Sci-Fi  | 2014         |

## 📌 Future Improvements
- ✅ Implement Authentication & Authorization 🔐
- ✅ Add Pagination & Filtering 📊
- ✅ Improve Error Handling ⚠️



## 📜 License
This project is licensed under the **MIT License** - see the LICENSE file for details.

---
🚀 Enjoy building with ASP.NET Core! Happy coding! 😃

