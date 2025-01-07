# Constructor Example - Baby Class

## Overview

This C# application demonstrates the use of constructors, specifically focusing on default and parameterized constructors. The program defines a `Baby` class with properties such as `Name`, `Surname`, and `BirthDate`. It includes two constructors:

1. A **default constructor** that initializes the baby's name and surname to "Unknown".
2. A **parameterized constructor** that allows setting the baby's name and surname while creating the object.

Both constructors share a common method to assign the current date and time as the birth date and display "Ingaaaa" in the console when a baby object is created.

## Key Features

- **Baby Class Properties**:
  - `Name` (string)
  - `Surname` (string)
  - `BirthDate` (DateTime)

- **Constructor Overloading**:
  - Default constructor that sets default values for the name and surname.
  - Parameterized constructor that accepts the `name` and `surname` to initialize properties.

- **Method Shared by Both Constructors**:
  - `BirthProcess()`: Sets the birth date to the current date and time and displays "Ingaaaa" in the console.

## Output Example
```txt
Ingaaaa
Bebek 1: Ad=Ron, Soyad=Weasley, Doğum Tarihi=7.01.2025 15:41:44
Ingaaaa
Bebek 2: Ad=Elif, Soyad=Aybal, Doğum Tarihi=7.01.2025 15:41:44
