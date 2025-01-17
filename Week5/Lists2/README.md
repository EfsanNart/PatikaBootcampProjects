# Coffee List Console Application

## Overview
This is a simple C# console application that allows the user to input coffee names. The program ensures that only valid coffee names (containing only letters) are accepted and prevents numbers from being entered.

## Features
- Prompts the user to enter the number of coffee names they want to input.
- Validates user input to ensure only alphabetic characters are accepted.
- Displays the list of valid coffee names entered by the user.

## Requirements
- .NET SDK installed
- C# compiler (comes with .NET)

## Installation & Execution
1. Clone this repository or copy the code into a new C# console project.
2. Compile and run the application using the following command in the terminal or command prompt:
   
   ```sh
   dotnet run
   ```

## Code Explanation
The program follows these steps:
1. It initializes an empty list (`List<string> coffees`) to store coffee names.
2. It prompts the user to enter the number of coffee names they want to input.
3. A loop runs for the given count, asking the user to input a coffee name.
4. The input is validated using the `ContainsNumber()` function:
   - If the input contains numbers, the user is prompted to enter a valid name.
   - If the input is valid, it is added to the `coffees` list.
5. After all valid inputs are collected, the list is printed to the console.

## Sample Run
```
Kaç kahve ismi girmek istiyorsunuz? 3
Kahve 1 : Espresso
Kahve 2 : 123
⚠ Lütfen sadece harf içeren bir kahve ismi girin!
Kahve 2 : Latte
Kahve 3 : Mocha

Girilen Kahve İsimleri:
Espresso
Latte
Mocha
```



## License
This project is open-source and available for use under the MIT License.

