# 📚 Dependency Injection Practice - Web API

This project demonstrates how to implement **Dependency Injection (DI) with Service Lifetimes** in an **ASP.NET Core Web API**. 🚀

---

## 🛠️ Technologies Used
- ASP.NET Core Web API 🌐
- C# 💻
- Dependency Injection (DI) 🏗️
- Service Lifetimes (Scoped, Transient, Singleton) 🔄
- Swagger for API Testing 📜

---

## 📂 Project Structure
```
DependencyInjectionPractice/
│── DependencyInjectionPractice.sln  --> (Solution file)
│
├── DependencyInjectionPractice/  --> (Main Web API project)
│   ├── Controllers/
│   │   ├── ClassroomController.cs  --> (API Controller)
│   │
│   ├── Interfaces/
│   │   ├── ITeacher.cs  --> (Interface for Teacher service)
│   │
│   ├── Models/
│   │   ├── Teacher.cs  --> (Teacher model)
│   │   ├── Classroom.cs  --> (Classroom model)
│   │
│   ├── Services/
│   │   ├── TeacherService.cs  --> (Service implementing ITeacher)
│   │
│   ├── Program.cs  --> (Registers dependencies and runs the API)
│   ├── appsettings.json  --> (Configuration file)
```

---

## ⚙️ Service Lifetimes
In this project, **Scoped** lifetime is used for Dependency Injection:

| Lifetime  | Description |
|-----------|------------|
| **Scoped** 🏛️ | Creates a new instance per HTTP request. (Used in this project) |
| **Transient** 🔄 | Creates a new instance every time it is requested. |
| **Singleton** 🔁 | Creates one instance and uses it throughout the application's lifetime. |

---

## 🚀 How to Run

1️⃣ **Clone the repository**
```bash
git clone https://github.com/your-repo/dependency-injection-practice.git
```

2️⃣ **Navigate to the project directory**
```bash
cd DependencyInjectionPractice
```

3️⃣ **Run the project**
```bash
dotnet run
```

4️⃣ **Test the API using Swagger or Postman**
- Open **Swagger UI**:
  ```
  http://localhost:5000/swagger
  ```
- Or send a **GET request** to:
  ```
  GET http://localhost:5000/api/classroom/teacher
  ```

✅ **Response Example:**
```json
"Teacher: Sertan Bozkuş"
```

---

## 📌 Key Features
✔ Implements **Dependency Injection** using interfaces 🔗  
✔ Uses **Scoped** Service Lifetime ⏳  
✔ API can be tested via **Swagger** or **Postman** 🛠️  
✔ Clean and **modular project structure** 📂  

---

## 📜 License
This project is licensed under the **MIT License**. 📄

Feel free to contribute and improve this project! 🚀✨

