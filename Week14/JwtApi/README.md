# 🛡️ JWT Authentication API with .NET 8

A simple authentication system using **JWT (JSON Web Token)** in **.NET 8** with **Entity Framework Core** and **SQL Server** as the database.

---

## 📌 Features

✅ User Registration & Login with JWT Authentication\
✅ Secure API Endpoint with Authorization\
✅ Entity Framework Core Integration (SQL Server)\
✅ Dependency Injection for Database Context\
✅ Token-Based Authentication for Secure Access

---

## 🚀 Installation & Setup

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/EfsanNart/JwtApi.git
cd JwtApi
```

### 2️⃣ Install Dependencies

```bash
dotnet restore
```

### 3️⃣ Update Database

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4️⃣ Run the Application

```bash
dotnet run
```

Now your API is running at: **`http://localhost:5000`** 🚀

---

## ⚙️ Configuration

Update **`appsettings.json`** for JWT authentication:

```json
"Jwt": {
  "Key": "ansjkskjhadhjsdjljaşjşdjşajşasjdşsdşjsaşlkfşosjfşskdşkş",
  "Issuer": "http://localhost:5099",
  "Audience": "http://localhost:5099"
}
```

Configure **SQL Server** in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=LAPTOP-IOOHI3VQ\\SQLEXPRESS;Database=JwtDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

## 🛠️ Project Structure

```
📂 JwtAuthSimple
 ┣ 📂 Controllers
 ┃ ┣ 📄 AuthController.cs  # Handles user authentication
 ┃ ┣ 📄 SecretController.cs # Protected API endpoint
 ┣ 📂 Models
 ┃ ┣ 📄 User.cs  # User model
 ┣ 📂 Data
 ┃ ┣ 📄 ApplicationDbContext.cs  # Database context
 ┣ 📄 appsettings.json  # Configurations (JWT, Database)
 ┣ 📄 Program.cs  # Application entry point
```

---

## 📜 API Endpoints

### 🔹 **User Registration**

📌 `POST /api/auth/register`

```json
{
  "email": "test@mail.com",
  "password": "123456"
}
```

✅ **Response:**

```json
"User registered successfully."
```

---

### 🔹 **User Login** (Get JWT Token)

📌 `POST /api/auth/login`

```json
{
  "email": "test@mail.com",
  "password": "123456"
}
```

✅ **Response:**

```json
{
  "token": "eyJhbGciOiJIUzI1..."
}
```



---

### 🔹 **Access Protected Endpoint**

📌 `GET /api/secret/protected`

🔐 **Requires Authorization** (Send JWT token in headers)

```http
Authorization: Bearer {your-token-here}
```

✅ **Response:**

```json
{
  "message": "This is a protected resource!"
}

```
![image](https://github.com/user-attachments/assets/7c890684-8914-4f95-8841-a9da10374e26)



🚫 **If unauthorized:**

```json
{
  "error": "401 Unauthorized"
}
```

---

## 🔧 Technologies Used

- **.NET 8** 🟣
- **Entity Framework Core** 🛢️
- **SQL Server Database** 🗄️
- **JWT Authentication** 🔑

---

## 📢 Notes

- **Use a strong secret key** for JWT (`appsettings.json`).
- **Store passwords securely** using hashing instead of plain text.
- **Consider environment variables** for sensitive configurations.

💡 *Feel free to improve and customize this project!* 🚀

---


✅ **Happy Coding!** 🎉

