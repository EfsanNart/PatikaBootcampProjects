# SimpleMVCBlogApp 📝

Welcome to **SimpleMVCBlogApp**! This is a basic ASP.NET Core MVC blog application where users can create and view blog posts. 🚀

## Features ✨
- 🏡 Home page displaying all blog posts
- ✍️ Create new blog posts with validation
- 🔍 View details of each blog post
- ⏳ Displays creation time and elapsed time since creation
- 🔄 Redirects users upon successful blog creation

## Installation & Setup 🛠

### Prerequisites 📌
- .NET SDK (latest version recommended)
- A code editor (Visual Studio, VS Code, Rider, etc.)
- A web browser

### Steps to Run 🚀
1. **Clone the Repository** 📂
   ```sh
   git clone https://github.com/your-username/SimpleMVCBlogApp.git
   cd SimpleMVCBlogApp
   ```
2. **Build the Application** 🔧
   ```sh
   dotnet build
   ```
3. **Run the Application** ▶️
   ```sh
   dotnet run
   ```
4. Open your browser and navigate to:
   ```
   https://localhost:5001
   ```

## Project Structure 📁
```
SimpleMVCBlogApp/
│── Controllers/
│   ├── BlogController.cs
│── Models/
│   ├── BlogPost.cs
│── Views/
│   ├── Blog/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Details.cshtml
│── Program.cs
│── appsettings.json
│── Startup.cs
```

## Routes & Endpoints 🌍
| Route            | HTTP Method | Description                          |
|-----------------|------------|----------------------------------|
| `/Blog/Index`   | GET        | Displays all blog posts          |
| `/Blog/Create`  | GET        | Shows form to create new post    |
| `/Blog/Create`  | POST       | Saves new post and redirects     |
| `/Blog/Details/{id}` | GET    | Displays details of a blog post  |

## Technologies Used 🛠
- ASP.NET Core MVC 🏗
- C# 💻
- Razor Pages 📝
- Bootstrap 🎨

## Contributing 🤝
Contributions are welcome! Feel free to open an issue or submit a pull request. 🚀

## License 📜
This project is licensed under the MIT License.

---
🎉 **Happy Coding!** 🚀

