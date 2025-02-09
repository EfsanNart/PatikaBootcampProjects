# 🚗 Car Factory Console Application

## 📌 Description
This C# console application allows users to manufacture cars with specific properties. The user can create multiple cars and store them in a list. At the end of the process, all manufactured cars will be displayed with their serial numbers and brands.

## 🛠 Features
- Prompt the user to decide whether they want to create a car or not.
- Collect car details such as:
  - Serial Number
  - Brand
  - Model
  - Color
  - Number of Doors (Validated for numeric input)
- Automatically set the production date to the current date.
- Handle invalid inputs using error handling.
- Display all manufactured cars at the end.

## 📜 How It Works
1. The user is asked whether they want to create a car (`e` for yes, `h` for no).
2. If the user chooses `e`, they are prompted to enter the car's details.
3. The number of doors must be a valid numeric input; otherwise, the program will prompt again.
4. The created car is stored in a list.
5. The user is asked if they want to create another car.
6. If the user chooses `h`, all created cars are displayed.

## 🚀 Getting Started
### Prerequisites
- .NET SDK installed
- Basic knowledge of C# and console applications

### Running the Program
1. Clone the repository or copy the source code.
2. Open a terminal or command prompt in the project directory.
3. Compile and run the program using:
   ```sh
   dotnet run
   ```
4. Follow the on-screen instructions.

## 📝 Example Output
```
Do you want to manufacture a car? (e/h): e
Enter Serial Number: ABC123
Enter Brand: Toyota
Enter Model: Corolla
Enter Color: Red
Enter Number of Doors: 4
Car successfully manufactured! 🎉

Do you want to manufacture another car? (e/h): h

Manufactured Cars:
Serial No: ABC123, Brand: Toyota
```

## 📌 Notes
- Invalid inputs are handled gracefully.
- The program loops until the user decides to stop.

## 📧 Contact
For any questions or suggestions, feel free to reach out! 😊

