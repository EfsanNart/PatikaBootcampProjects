# Array Operations in C#

This project demonstrates basic array operations in C# by implementing a simple console application that:

1. Initializes an array of 10 integers.
2. Populates the array with user input and displays the values.
3. Adds an additional user-provided integer to the array.
4. Sorts and displays the array in descending order.

## Features
- Accepts 10 integer inputs from the user.
- Allows adding an 11th integer dynamically.
- Uses `Array.Resize` to expand the array.
- Sorts the array in descending order before displaying.

## Usage
1. Clone this repository.
2. Open the project in an IDE that supports C# (e.g., Visual Studio, Visual Studio Code).
3. Run the program and follow the console prompts to enter numbers.
4. Observe the sorted output.

## Code Example
```csharp
// Resize array to add a new element
Array.Resize(ref numbers, numbers.Length + 1);
numbers[numbers.Length - 1] = newValue;

// Sort and reverse to get descending order
Array.Sort(numbers);
Array.Reverse(numbers);
```

## Requirements
- .NET Core or .NET Framework installed.
- Basic knowledge of C# and console applications.

## License
This project is open-source and available under the MIT License.



