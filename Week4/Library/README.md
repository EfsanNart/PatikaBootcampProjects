# Patika Library - Book Registration Application 📚

This project is a simple console application to manage book records and book information. Book objects are created through the `Book` class.

## Features ✨

- **Book Information:**
  - Name 📖
  - Author's First Name ✍️
  - Author's Last Name ✍️
  - Number of Pages 📄
  - Publisher 🏢
  - Registration Date (automatically assigned) 📅

- **Constructors:**
  - **Default Constructor:**
    - Does not accept parameters.
    - The registration date is automatically assigned.
  - **Parameterized Constructor:**
    - Accepts book name, author’s name, number of pages, and publisher as parameters.
    - The registration date is also automatically assigned.

## Usage 🔧

### Example Code 🖥️

#### Using the Default Constructor
```csharp
Book book1 = new Book()
{
    Name = "Sabırsız Yürek",
    WriterName = "Stefan",
    WriterSurname = "Zweig",
    NumberOfPages = 464,
    Publisher = "Alfa Kitabevi"
};
````
### Using the Parameterized Constructor
```csharp
Book book2 = new Book("Les Misérables", "Victor Hugo", 1724, "Can Yayınları");
```
## Printing Book Information 📄
```csharp
book1.BookInfo();
book2.BookInfo();
```
### Expected Output 📊
## Kullanım

### Örnek Kod

#### Default Constructor Kullanımı
```csharp
The book titled "Sabırsız Yürek" was written by Stefan Zweig.
464 pages, published by Alfa Yayınları, registered on 09.01.2025.

The book titled "Les Misérables" was written by Victor Hugo.
1724 pages, published by Can Yayınları, registered on 09.01.2025.
```



