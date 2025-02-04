# 📌 ASP.NET MVC - Customer & Orders Display

## 📖 Overview
This project is a simple ASP.NET MVC application that displays customer and order information. It follows the **Model-View-Controller (MVC)** design pattern.

## 📂 Project Structure
- **Models/**: Contains `Customer` and `Order` classes.
- **ViewModels/**: Contains `CustomerOrderViewModel`.
- **Controllers/**: Contains `CustomerOrdersController`.
- **Views/**: Includes `Index.cshtml` to display customer and order details.

## 🛠 Setup & Installation
1. **Clone the repository**:
   ```sh
   git clone https://github.com/your-repo/mvc-customer-orders.git
   ```
2. **Navigate to the project folder**:
   ```sh
   cd mvc-customer-orders
   ```
3. **Build & Run the project**:
   ```sh
   dotnet run
   ```

## 🏗 Implementation Steps
### 1️⃣ Model Creation
- `Customer` model with `Id`, `FirstName`, `LastName`, and `Email`.
- `Order` model with `Id`, `ProductName`, `Price`, and `Quantity`.

### 2️⃣ ViewModel Creation
- `CustomerOrderViewModel` containing a `Customer` object and a list of `Order` objects.

### 3️⃣ Controller Setup
- `CustomerOrdersController` with an `Index` action to pass data to the view.

### 4️⃣ View Creation
- `Index.cshtml` displaying customer details and orders in a table.

## 🎯 Usage
- Open a browser and navigate to:
  ```
  https://localhost:5001/CustomerOrders/Index
  ```
- View customer details and their orders in a tabular format.

## 🚀 Technologies Used
- ASP.NET Core MVC
- C#
- Razor Views
- HTML & CSS

## 📜 License
This project is licensed under the MIT License.

---

💡 Feel free to contribute or report issues!

