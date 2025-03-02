# Celebrities API 🌟

Welcome to the **Celebrities API**! This project is a simple ASP.NET Core Web API that allows you to manage a list of celebrities. 🎤🎭

## 🚀 Getting Started

### 1️⃣ Project Setup
1. Open **Visual Studio**.
2. Create a new project using the **ASP.NET Core Web API** template.
3. Name the project **CelebritiesApi**.
4. Set up the necessary dependencies and start coding! ✨

---

### 2️⃣ Model Definition 🏗️
The `Celebrity` model represents a celebrity with an **Id, Name, and Profession**.

#### 📌 `Celebrity.cs`
```csharp
namespace CelebritiesApi.Models
{
    public class Celebrity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
    }
}
```

---

### 3️⃣ Running the API ▶️
To run the API:
1. **Start the project** in Visual Studio.
2. **Use Swagger UI** or Postman to test the API.

---

## 🌐 API Endpoints

### 1️⃣ Get All Celebrities 📜
- **Method:** GET
- **URL:** `http://localhost:5000/api/celebrities`
- **Response:** List of celebrities

### 2️⃣ Get a Celebrity by ID 🔍
- **Method:** GET
- **URL:** `http://localhost:5000/api/celebrities/{id}`
- **Response:** Single celebrity

### 3️⃣ Add a New Celebrity ➕
- **Method:** POST
- **URL:** `http://localhost:5000/api/celebrities`
- **Body:**
```json
{
    "name": "Hadise",
    "profession": "Pop Singer"
}
```

### 4️⃣ Update a Celebrity ✏️
- **Method:** PUT
- **URL:** `http://localhost:5000/api/celebrities/{id}`
- **Body:**
```json
{
    "name": "Banu Alkan",
    "profession": "Afrodit Bebeğim"
}
```

### 5️⃣ Delete a Celebrity ❌
- **Method:** DELETE
- **URL:** `http://localhost:5000/api/celebrities/{id}`

---

## 🎯 Tools Used
- **ASP.NET Core Web API** 🏗️
- **C#** 💻
- **Swagger UI** 📜
- **Postman** 📡

Happy Coding! 🚀🎉

