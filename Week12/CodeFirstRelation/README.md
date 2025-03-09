# 📚 Code First Approach with Entity Framework Core

## 📌 Project Overview
This project demonstrates how to implement the **Code First** approach using **Entity Framework Core** in an ASP.NET Core Web API. The project consists of **Users** and **Posts**, where:

- A **User** can have multiple **Posts** (One-to-Many Relationship).
- Each **Post** belongs to a single **User**.

## 🏗️ Technologies Used
- 🟣 **ASP.NET Core Web API**
- 🟢 **Entity Framework Core**
- 🛢️ **SQL Server**
- 🔄 **Code First Migrations**


## 📂 Project Structure
```
📦 CodeFirstBasic
 ┣ 📂 Context
 ┃ ┣ 📜 PatikaSecondDbContext.cs
 ┣ 📂 Entities
 ┃ ┣ 📜 User.cs
 ┃ ┣ 📜 Post.cs
 ┣ 📜 Program.cs
 ┣ 📜 appsettings.json
```

## 🏛️ Database Models
### **UserEntity**
```csharp
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public List<Post> Posts { get; set; }
}
```
### **PostEntity**
```csharp
public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
```

## 🔗 Setting Up the Project
### 1️⃣ **Clone the Repository**
```sh
git clone https://github.com/your-repo/codefirst-basic.git
cd codefirst-basic
```

### 2️⃣ **Update Connection String**
Modify the `appsettings.json` file:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=PatikaCodeFirstDb2;Trusted_Connection=True;"
}
```

### 3️⃣ **Apply Migrations & Update Database**
Run the following commands in the terminal:
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4️⃣ **Run the Application**
```sh
dotnet run
```


## 🏁 Conclusion
This project demonstrates how to implement a **Code First** approach with **Entity Framework Core** in an ASP.NET Core Web API.

Happy Coding! 🚀

