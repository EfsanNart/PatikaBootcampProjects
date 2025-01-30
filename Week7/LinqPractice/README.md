# 🎲 Random Number Filtering with LINQ

This project generates a list of **10 random numbers** between **-50 and 49** and applies various LINQ queries to filter and process the numbers.

## 📌 Features
- Generates **10 random numbers** between -50 and 49.
- Filters numbers based on different conditions using **LINQ**:
  - ✅ Even numbers
  - 🔢 Odd numbers
  - 🔴 Negative numbers
  - 🟢 Positive numbers
  - 🎯 Numbers between **15 and 22**
  - 📈 Square of each number

## 🚀 Usage

1. **Clone the repository** (if applicable) or copy the `Program.cs` file.
2. **Run the project** in a C# development environment (such as Visual Studio or .NET CLI).
3. The output will display random numbers along with filtered results.

## 🛠 Example Output

```
Random Numbers: -12, 25, -8, 34, 19, -3, 42, 21, -45, 16
Even Numbers: -12, -8, 34, 42, 16
Odd Numbers: 25, 19, -3, 21, -45
Negative Numbers: -12, -8, -3, -45
Positive Numbers: 25, 34, 19, 42, 21, 16
Numbers between 15 and 22: 19, 16
Squared Numbers: 144, 625, 64, 1156, 361, 9, 1764, 441, 2025, 256
```

## 📌 Technologies Used
- C#
- .NET Framework
- LINQ (Language Integrated Query)

## 📝 Notes
- Each execution produces **different random numbers**.
- Adjust the range of numbers by modifying `rnd.Next(-50, 50)`.
- You can increase the count of generated numbers by changing the loop condition.

🔹 **Happy Coding!** 🎉

