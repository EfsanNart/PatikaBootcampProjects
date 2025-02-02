# 📚 Library Management System

A simple **Library Management System** using C# and LINQ to manage authors and books efficiently. This project demonstrates **LINQ join operations** to fetch books along with their respective authors. 🚀

## 🛠️ Features
- Manage authors and books using **C# classes**.
- Use **LINQ join** to combine book and author data.
- Display book titles along with their authors.

## 📂 Project Structure
```
LibraryManagementSystem/
│── Models/
│   ├── Author.cs
│   ├── Book.cs
│── Program.cs
```

## 📌 Technologies Used
- **C#**
- **.NET Framework / .NET Core**
- **LINQ (Language Integrated Query)**

## 🚀 How to Run the Project
1. Clone this repository:
   ```sh
   git clone https://github.com/yourusername/LibraryManagementSystem.git
   ```
2. Open the project in **Visual Studio** or any C# IDE.
3. Build and Run the project.
4. The program will display books along with their authors.

## 📝 Code Explanation
```csharp
var query = from book in books
            join author in authors on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle = book.Title,
                AuthorName = author.Name + " " + author.Surname
            };
```
### 🔍 How It Works:
- `join` is used to match **books** with their respective **authors** using `AuthorId`.
- A new object is created containing **Book Title** and **Author Name**.
- The result is printed to the console.

## 🎯 Expected Output
```
Kitap: Sabırsız Yürek, Yazar: Stefan Zweig
Kitap: Dönüşüm, Yazar: Franz Kafka
Kitap: Tutunamayanlar, Yazar: Oğuz Atay
Kitap: Aşk-ı Memnu, Yazar: Halit Ziya Uşaklıgil
```

## 🎯 Future Enhancements
- Add a **database** to store authors and books.
- Implement a **user interface**.
- Enable **search and filtering** capabilities.

## 🤝 Contributing
Contributions are welcome! Feel free to **fork** this repository and submit a **pull request**. 😊

## 📄 License
This project is licensed under the **MIT License**.

Happy Coding! 🎉

