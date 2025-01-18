# FinalProject - Technology Store Product Management

## Description
This project is designed to record Phone and Computer products in a technology store. It is developed using the C# programming language and object-oriented programming (OOP) principles.

## OOP Concepts Used
- **Inheritance**: The `BaseMachine` class is inherited by the `Phone` and `Computer` classes.
- **Encapsulation**: The `UsbGirisSayisi` property restricts input to specific values (2 or 4), assigning -1 otherwise.
- **Polymorphism**: The `BilgileriYazdir()` method is defined in the `BaseMachine` class and overridden in derived classes for customization.
- **Abstraction**: The `BaseMachine` class includes an abstract method `UrunAdiGetir()`, implemented separately in subclasses.

## Project Structure
```
FinalProject
│── Abstract
│   └── BaseMachine.cs
│── Concrete
│   ├── Computer.cs
│   ├── Phone.cs
│── Program.cs
```

## Features
### **Phone (`Phone`)**
- Manufacturing Date
- Serial Number
- Name
- Description
- Operating System
- TR Licensed (Yes/No)

### **Computer (`Computer`)**
- Manufacturing Date
- Serial Number
- Name
- Description
- Operating System
- USB Port Count (Must be 2 or 4; otherwise, -1 is assigned)
- Bluetooth (Yes/No)

## Execution Steps
1. **Run the Project**: Use the following command to start the project in the console.
   ```sh
   dotnet run
   ```
2. **Select Product Type**:
   - Press `1` to create a Phone.
   - Press `2` to create a Computer.
3. **Enter Required Details**: Input serial number, name, description, operating system, etc.
4. **Receive Success Message**: Once the product is successfully created, its details will be displayed.
5. **Do You Want to Create Another Product?**: If you answer `yes`, the process restarts. If `no`, the program terminates.

## Example Usage
```
Press 1 to create a Phone, 2 to create a Computer:
1
Serial Number: 12345
Name: iPhone 13
Description: Latest Apple model
Operating System: iOS
Is TR Licensed? (true/false): true

Product successfully created!
Manufacturing Date: 2025-01-18
Serial Number: 12345
Name: iPhone 13
Description: Latest Apple model
Operating System: iOS
TR Licensed: Yes

Do you want to create another product? (yes/no): no
Goodbye!
```

## Developer
- **Efsan** 🚀

Feel free to contribute if you want to improve or modify this project!

