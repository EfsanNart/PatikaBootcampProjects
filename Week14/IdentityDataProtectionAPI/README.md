# 🛡️ Identity & Data Protection API

This project is an **Identity Management & Data Protection API** built with **ASP.NET Core** and **Entity Framework Core**. It includes **user authentication** and **data encryption** for password security. 🔒

## ✨ Features
- ✅ User Registration & Login  
- ✅ Password Hashing & Security 🔐  
- ✅ Identity API Implementation  
- ✅ Entity Framework Core Code-First Approach  
- ✅ SQL Server Database Integration  
- ✅ API Endpoints with Swagger UI  

---

## 🏠 Project Structure
```
📂 IdentityDataProtectionAPI
 ┣ 📂 Controllers
 ┃ ┣ 📚 AccountController.cs
 ┣ 📂 Data
 ┃ ┣ 📚 ApplicationDbContext.cs
 ┣ 📂 DTOs
 ┃ ┣ 📚 UserLoginDto.cs
 ┃ ┣ 📚 UserRegisterDto.cs
 ┣ 📂 Entities
 ┃ ┣ 📚 User.cs
 ┣ 📂 Services
 ┃ ┣ 📚 IUserService.cs
 ┃ ┣ 📚 UserService.cs
 ┣ 📚 Program.cs
 ┣ 📚 appsettings.json
 ┣ 📚 README.md
```

---

## ⚙️ Installation & Setup
Follow these steps to set up and run the project:

### 1️⃣ Clone the repository  
```sh
git clone https://github.com/yEfsanNart/IdentityDataProtectionAPI.git
cd IdentityDataProtectionAPI
```

### 2️⃣ Configure the database connection  
Update **`appsettings.json`** with your SQL Server details:  
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=LAPTOP-IOOHI3VQ\\SQLEXPRESS;Database=IdentityDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

### 3️⃣ Install dependencies  
Run the following command in **Package Manager Console (PMC):**  
```sh
dotnet restore
```

### 4️⃣ Apply migrations & update the database  
```sh
dotnet ef migrations add Identity
dotnet ef database update
```

### 5️⃣ Run the project  
```sh
dotnet run
```
The API will be available at: **`https://localhost:5001/swagger`** 🚀

---

## 🔥 API Endpoints
| Method | Endpoint         | Description               |
|--------|----------------|---------------------------|
| POST   | `/api/account/register` | Register a new user 📝 |
| POST   | `/api/account/login`    | User login 🔑 |

---

## 🛠️ Technologies Used
- **ASP.NET Core** 🚀  
- **Entity Framework Core** 🏰️  
- **Microsoft Identity API** 🔒  
- **SQL Server** 📺  
- **Swagger UI** 📜  

---

## 🐜 License
This project is open-source and available under the **MIT License**.  

---

## 💡 Contributing
Contributions are welcome! Feel free to fork the project and submit a pull request.  

---

## 📱 Contact
📧 Email: efsannart@gmail.com

🔗 GitHub: [EfsanNart](https://github.com/EfsanNart)

