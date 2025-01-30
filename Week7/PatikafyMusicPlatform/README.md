# PatikafyMusicPlatform

This project is a simple C# program that analyzes a list of popular artists and performs various queries on them.

## 📌 Features
- **List artists whose names start with 'S'**
- **List artists with album sales exceeding 10 million**
- **List artists who debuted before 2000 and make Pop music**, sorted by release year and alphabetically
- **Find the artist with the highest album sales**
- **Find the newest and oldest debuting artists**

## 📁 Project Structure
```
PatikafyMusicPlatform
│── Program.cs       # Main program flow
│── Artist.cs        # Artist class
│── README.md        # Project description
```

## 🚀 Usage
1. **Run the Project:**
   - Open **`Program.cs`** in Visual Studio or any C# IDE and run it.
2. **Check the Output:**
   - The relevant artists and information will be displayed in the console.

## 📜 Code Explanation
- **`Artist` Class:**
  - `Name`: Artist's name
  - `Type`: Music genre of the artist
  - `ReleaseYear`: Debut year
  - `AlbumSales`: Album sales (in millions)

- **Main Operations (Program.cs)**
  - **LINQ queries** are used to filter and sort the artists.
  - **Grouping (GroupBy), Filtering (Where), Sorting (OrderBy, OrderByDescending)** operations are applied.

## 📌 Example Output
```
Artists whose names start with 'S':
Sezen Aksu
Sertab Erener
Sıla
Serdar Ortaç
-------------------------------------------------------------------------------------------
Artists with album sales exceeding 10 million:
Ajda Pekkan - 20
Tarkan - 40
-------------------------------------------------------------------------------------------
Artists who debuted before 2000 and make Pop music (Release Year - Alphabetical Order):
1968 - Ajda Pekkan
1971 - Sezen Aksu
1992 - Tarkan
1994 - Sertab Erener
1994 - Serdar Ortaç
1997 - Gülben Ergen
1999 - Funda Arar
1999 - Hande Yener
-------------------------------------------------------------------------------------------
Artist with the highest album sales: Tarkan
-------------------------------------------------------------------------------------------
Newest debuting artist: Sıla
Oldest debuting artist: Neşet Ertaş
```

## 📌 Requirements
- .NET SDK or Visual Studio
- C# 7.0 or later

## 🛠 Development & Contribution
If you would like to contribute to the project, feel free to **fork** it and share your improvements! 😊

