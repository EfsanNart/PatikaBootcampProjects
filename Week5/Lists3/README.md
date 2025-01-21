# IMDb Movie List Console Application

## Description
This is a simple C# console application that allows users to enter movie names and their IMDb ratings. The program stores these movies in a list and displays various filtered results based on user inputs.

## Features
- Users can add multiple movies with their IMDb ratings.
- After each entry, users are asked whether they want to add another movie.
- The program displays:
  1. A list of all entered movies.
  2. Movies with IMDb ratings between 4 and 9.
  3. Movies whose names start with the letter 'A'.

## Usage
1. Run the application.
2. Enter the movie name when prompted.
3. Enter the IMDb rating (between 0 and 10).
4. Choose whether to add another movie.
5. View the generated movie lists based on different criteria.

## Filtering Logic
- The program checks if a movie's IMDb rating is between 4 and 9 and displays it.
- Instead of using `StartsWith("A")`, it directly checks the first character by converting it to uppercase: `char.ToUpper(film.Isim[0]) == 'A'`.

## Requirements
- .NET SDK
- C# Compiler

## Running the Application
- Compile and run the C# file in a .NET-supported environment.

## Example Output
```
Film Adı: Avatar
IMDb Puanı: 8.5
Yeni film eklemek istiyor musunuz? (evet/hayır): evet

Film Adı: Titanic
IMDb Puanı: 7.8
Yeni film eklemek istiyor musunuz? (evet/hayır): hayır

Tüm Filmler:
Avatar - IMDb: 8.5
Titanic - IMDb: 7.8

IMDb Puanı 4 ile 9 Arasında Olan Filmler:
Avatar - IMDb: 8.5
Titanic - IMDb: 7.8

İsmi 'A' ile Başlayan Filmler:
Avatar - IMDb: 8.5
```

## Author
Developed by Efsan

