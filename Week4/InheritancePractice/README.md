# Inheritance Practice: BasePerson, Teacher, and Student

## Purpose
This project demonstrates the concept of inheritance in object-oriented programming (OOP) using C#. The goal is to create a base class (`BasePerson`) and derive two subclasses (`Teacher` and `Student`) from it. Example objects are created, and their details are displayed on the console.

---

## Classes

### 1. BasePerson
- **Properties**:
  - `Name`: First name of the person.
  - `Surname`: Last name of the person.
- **Method**:
  - `PersonInfo`: Displays the person's name and surname on the console.

### 2. Student (Inherits from BasePerson)
- **Additional Property**:
  - `StudentNumber`: The student's unique number.
- **Additional Method**:
  - `StudentInfo`: Displays the student's name, surname, and student number on the console.

### 3. Teacher (Inherits from BasePerson)
- **Additional Property**:
  - `SalaryInfo`: The teacher's salary.
- **Additional Method**:
  - `TeacherInfo`: Displays the teacher's name, surname, and salary on the console.

---

## Output Example
```
 Name : Ron
 Surname : Weasley
 Student Number : 17
----------------------------------------------------------------------------------------------------------------
 Name : Severus
 Surname : Snape
 Teacher's salary is 60000 TL.
```

---

## Key Takeaways
✨ This project teaches:
- How to create and inherit from a base class.
- Encapsulation by defining and using properties.
- Calling a method within another method.
- Displaying information on the console.

---

## Contribution
This project provides a simple example for developers to learn OOP concepts. It can serve as a foundation for more complex systems. Feel free to experiment and expand! 🚀

