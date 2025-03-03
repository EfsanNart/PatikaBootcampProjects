# 🎸 Crazy Musicians API 🎶

Welcome to the **Crazy Musicians API**! This API allows you to manage a collection of unique and fun musicians. It supports full **CRUD operations** and provides various filtering and searching options.

## 🚀 Features
- 🎼 **Retrieve** all musicians or filter by specific criteria.
- ✨ **Add** new crazy musicians to the list.
- 📝 **Update** musician details with `PUT` and `PATCH` methods.
- ❌ **Delete** a musician from the list.
- 🔍 **Search** musicians using `FromQuery` parameters.

## 📌 API Endpoints
### 🔹 Get All Musicians
```
GET /api/musicians
```
Returns a list of all crazy musicians.

### 🔹 Get a Musician by ID
```
GET /api/musicians/{id}
```
Retrieve details of a specific musician.

### 🔹 Search Musicians by Name
```
GET /api/musicians/search?name={name}
```
Find musicians by their name.

### 🔹 Add a New Musician
```
POST /api/musicians
```
Request Body (JSON):
```json
{
    "id": 1,
    "name": "Ahmet Çalgı",
    "profession": "Famous Note Player",
    "funFact": "Always plays the wrong note, but very fun"
}
```

### 🔹 Update a Musician (Full Update)
```
PUT /api/musicians/{id}
```
Request Body (JSON):
```json
{
    "id": 1,
    "name": "Ahmet Çalgı",
    "profession": "changed",
    "funFact": "changed"
}
```

### 🔹 Partial Update (Patch)
```
PATCH /api/musicians/{id}
```
Request Body (JSON - Example):
```json
[
  {
    "op": "replace",
    "path": "/funFact",
    "value": "Now performs magic tricks while playing!"
  }
]
```

### 🔹 Delete a Musician
```
DELETE /api/musicians/{id}
```
Removes a musician from the list.

## 🛠️ Technologies Used
- .NET Core Web API
- Entity Framework
- ASP.NET MVC

## 🚀 How to Run the Project
1. Clone the repository:
   ```sh
   git clone https://github.com/EfsanNart/Blockchain-based-EVChargingSystem.git
   ```
2. Navigate to the project folder and build the solution.
3. Run the application and test the endpoints using **Postman** or **Swagger**.

## 🔥 Author
👨‍💻 **Efsan Nart**

Happy coding! 🎵🚀

