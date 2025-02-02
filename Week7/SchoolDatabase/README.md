# 📚 LINQ Group Join Example

## 🏫 School Database Project
This project demonstrates how to use LINQ `group join` to associate students with their respective classes in a school database.

## 📌 Overview
We have two main data entities:
1. **Students** (List of students with their unique IDs and associated class IDs)
2. **Classes** (List of classes with unique class IDs and names)

Using `group join`, we link students to their respective classes and display the results in a structured manner.

---

## 📂 Project Structure

```
📦 SchoolDatabase
 ├── 📜 Program.cs
 ├── 📜 Models
 │   ├── 📜 Student.cs
 │   ├── 📜 Class.cs
```

---

## 🖥️ Code Implementation

### 🔹 1. Define Models
```csharp
namespace SchoolDatabase.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
        
        public Student(int studentId, string studentName, int classId)
        {
            StudentId = studentId;
            StudentName = studentName;
            ClassId = classId;
        }
    }
    
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        
        public Class(int classId, string className)
        {
            ClassId = classId;
            ClassName = className;
        }
    }
}
```

### 🔹 2. LINQ Group Join Operation
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using SchoolDatabase.Models;

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student(1, "Ali", 1),
            new Student(2, "Ayşe", 2),
            new Student(3, "Mehmet", 1),
            new Student(4, "Fatma", 3),
            new Student(5, "Ahmet", 2)
        };

        List<Class> classes = new List<Class>
        {
            new Class(1, "Matematik"),
            new Class(2, "Türkçe"),
            new Class(3, "Kimya")
        };

        var groupedData = from cls in classes
                          join student in students on cls.ClassId equals student.ClassId into studentGroup
                          select new
                          {
                              ClsName = cls.ClassName,
                              Students = studentGroup
                          };

        foreach (var item in groupedData)
        {
            Console.WriteLine($" {item.ClsName} Dersini Alanlar:");

            foreach (var student in item.Students)
            {
                Console.WriteLine($" {student.StudentName}");
            }
            Console.WriteLine();
        }
    }
}
```

---

## 🎯 Expected Output
```
 Matematik Dersini Alanlar:
 Ali
 Mehmet

 Türkçe Dersini Alanlar:
 Ayşe
 Ahmet

 Kimya Dersini Alanlar:
 Fatma
```

---

## 🚀 Key Features
- **📌 Group Join**: Uses LINQ `group join` to associate students with their respective classes.
- **📌 Readability**: Uses structured output for better understanding.
- **📌 Scalability**: Easily extendable for additional student and class data.

---

## 💡 How to Run the Project
1. Clone the repository or copy the code.
2. Open the project in **Visual Studio** or any C# IDE.
3. Run the `Program.cs` file.
4. View the console output.

---

## 📜 License
This project is open-source and free to use.

🔗 **Happy Coding!** 🎉

