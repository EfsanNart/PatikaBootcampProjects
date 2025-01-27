# 🏢 Employee Database Management

## 📌 Project Overview
This project demonstrates how to create an `employee` table in a test database, populate it with mock data using **Mockaroo**, and perform **UPDATE** and **DELETE** operations on the data.

## 🛠 Technologies Used
- **PostgreSQL**
- **Mockaroo** (For generating sample data)
- **SQL Queries** (For database operations)

## 📋 Table Schema
The `employee` table consists of the following columns:

| Column   | Data Type       | Description             |
|----------|----------------|-------------------------|
| `id`     | `SERIAL PRIMARY KEY` | Unique identifier (Primary Key) |
| `first_name` | `VARCHAR(50) NOT NULL` | Employee's first name |
| `last_name`  | `VARCHAR(50) NOT NULL` | Employee's last name |
| `email`  | `VARCHAR(100)`  | Employee's email address |
| `birthday` | `DATE`        | Employee's birth date  |

---

## 🏗️ Creating the Employee Table
Use the following SQL command to create the `employee` table:
```sql
CREATE TABLE employee (
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100),
    birthday DATE
);
```

---

## 🗑️ Delete Operations
Perform **5 different DELETE** operations to remove records based on different columns.

```sql
-- 1️⃣ Delete a record based on first_name
DELETE FROM employee 
WHERE first_name = 'Abbey';

-- 2️⃣ Delete a record based on last_name
DELETE FROM employee 
WHERE last_name = 'Christmas';

-- 3️⃣ Delete a record based on email
DELETE FROM employee 
WHERE email = 'skrojns@chicagotribune.com';

-- 4️⃣ Delete a record based on birthday
DELETE FROM employee 
WHERE birthday = '2023-01-07';

-- 5️⃣ Delete all records with NULL email
DELETE FROM employee 
WHERE email IS NULL;
```

---

## ✏️ Update Operations
Perform **5 different UPDATE** operations, modifying other columns based on specific criteria.

```sql
-- 1️⃣ Update last_name and email based on first_name
UPDATE employee 
SET last_name = 'UpdatedLastName',
email = 'efsannrt@gmail.com' 
WHERE first_name = 'Bord';

-- 2️⃣ Update birthday based on last_name
UPDATE employee 
SET birthday = '2000-01-01' 
WHERE last_name = 'Tonepohl';

-- 3️⃣ Update first_name based on email
UPDATE employee 
SET first_name = 'Ela' 
WHERE email = 'aabby3@jiathis.com';

-- 4️⃣ Update email based on birthday
UPDATE employee 
SET email = 'hakanalkn@gmail.com' 
WHERE birthday = '2018-02-20';

-- 5️⃣ Update first_name and email based on last_name
UPDATE employee 
SET first_name = 'ModifiedFirst', 
email = 'elamtlu@gmail.com' 
WHERE last_name = 'Dingle';
```

---

## 🚀 How to Run
1. **Setup the Database**: Create the `employee` table.
2. **Insert Mock Data**: Use Mockaroo to generate 50 records.
3. **Perform Updates**: Run the UPDATE queries.
4. **Perform Deletions**: Run the DELETE queries.

Happy Coding! 🎉

