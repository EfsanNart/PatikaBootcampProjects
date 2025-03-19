# Survivor API 🏆

Welcome to **Survivor API**! This RESTful API is designed to manage **competitors** and **categories** in a Survivor-like competition. Built with **ASP.NET Core**, it provides endpoints for creating, retrieving, updating, and deleting competitors and categories. 🚀

## Features ✨
- 📂 CRUD operations for **Competitors** and **Categories**
- 🔍 Retrieve competitors by **category**
- 🏗 Built with **ASP.NET Core & Entity Framework Core**
- 📡 RESTful API design for seamless integration

## Tech Stack 🛠️
- **.NET Core** 🌐
- **Entity Framework Core** 🗄️
- **SQL Server** 🛢️
- **Swagger** 📜 (for API documentation)

## Installation & Setup ⚙️
### Prerequisites 📋
- Install **.NET SDK**
- Set up **SQL Server** (or modify for another DB provider)

### Steps 🚀
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo/SurvivorAPI.git
   ```
2. Navigate to the project directory:
   ```bash
   cd SurvivorAPI
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Apply database migrations:
   ```bash
   dotnet ef database update
   ```
5. Run the API:
   ```bash
   dotnet run
   ```

## API Endpoints 🌍
| Method | Endpoint | Description |
|--------|---------|-------------|
| GET | `/api/competitors` | Get all competitors |
| GET | `/api/competitors/{id}` | Get a competitor by ID |
| GET | `/api/competitors/categories/{categoryId}` | Get competitors by category |
| POST | `/api/competitors` | Create a new competitor |
| PUT | `/api/competitors/{id}` | Update a competitor |
| DELETE | `/api/competitors/{id}` | Delete a competitor |
| GET | `/api/categories` | Get all categories |
| GET | `/api/categories/{id}` | Get a category by ID |
| POST | `/api/categories` | Create a new category |
| PUT | `/api/categories/{id}` | Update a category |
| DELETE | `/api/categories/{id}` | Delete a category |

## Contributing 🤝
Feel free to contribute by submitting **issues** or **pull requests**! 🚀

## License 📜
This project is licensed under the **MIT License**.

---

🔥 Happy Coding! 🔥

