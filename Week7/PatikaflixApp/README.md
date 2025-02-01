# 📺 Patikaflix TV Series Platform

## 📌 Project Description
This C# console application allows users to create and manage a list of TV series. Users can enter series details, add multiple series, and filter comedy series into a separate list. The filtered list is then displayed in alphabetical order by series name and director.

## 🚀 Features
- Add TV series with details: Name, Year, Genre, Release Year, Director, and Platform.
- Ask users if they want to add another series after each entry.
- Filter comedy series into a separate list.
- Sort the comedy series list by name and then by director.
- Display the sorted comedy series list in the console.

## 🛠️ Technologies Used
- C#
- .NET Console Application
- LINQ for filtering and sorting

## 🎯 How to Run the Project
1. Clone this repository:
   ```sh
   git clone https://github.com/your-repo/patikaflix-tvseries.git
   ```
2. Navigate to the project folder:
   ```sh
   cd patikaflix-tvseries
   ```
3. Compile and run the application:
   ```sh
   dotnet run
   ```
4. Follow the on-screen instructions to add TV series and view the filtered comedy list.

## 📌 Example Output
```
Dizi Adı: Avrupa Yakası
Yapım Yılı: 2004
Türü: Komedi
Yayınlanmaya Başlama Yılı: 2004
Yönetmen: Yüksel Aksu
Yayınlandığı İlk Platform: Kanal D

Yeni bir dizi eklemek istiyor musunuz? (e/h): e

Dizi Adı: Aşk-ı Memnu
Yapım Yılı: 2008
Türü: Dram, Romantik
Yayınlanmaya Başlama Yılı: 2008
Yönetmen: Hilal Saral
Yayınlandığı İlk Platform: Kanal D

Yeni bir dizi eklemek istiyor musunuz? (e/h): h

Komedi Dizileri Listesi:
Dizi Adı: Avrupa Yakası, Türü: Komedi, Yönetmen: Yüksel Aksu
```


