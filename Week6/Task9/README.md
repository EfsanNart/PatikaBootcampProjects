# 📌 README - SQL Queries for dvdrental Database

## 🔍 Overview
This document provides SQL queries using **INNER JOIN** to retrieve meaningful data from the **dvdrental** sample database. 🗃️

## 📜 Queries

### 1️⃣ Retrieve City and Country Names Using INNER JOIN 🌍
This query joins the `city` table with the `country` table to display city names along with their respective country names. 🏙️

```sql
SELECT city.city, country.country
FROM city
INNER JOIN country ON city.country_id = country.country_id;
```

### 2️⃣ Retrieve Customer Names and Payment IDs Using INNER JOIN 💰
This query joins the `customer` table with the `payment` table to retrieve the `payment_id` along with `first_name` and `last_name` of the customers. 🧑‍💼

```sql
SELECT payment.payment_id, customer.first_name, customer.last_name
FROM payment
INNER JOIN customer ON payment.customer_id = customer.customer_id;
```

### 3️⃣ Retrieve Customer Names and Rental IDs Using INNER JOIN 🎬
This query joins the `customer` table with the `rental` table to retrieve the `rental_id` along with `first_name` and `last_name` of the customers. 🍿

```sql
SELECT rental.rental_id, customer.first_name, customer.last_name
FROM rental
INNER JOIN customer ON rental.customer_id = customer.customer_id;
```

## 🛠️ Usage
- Execute these queries in a SQL environment where the `dvdrental` database is available. ⚙️
- Ensure that the required tables (`city`, `country`, `customer`, `payment`, and `rental`) exist and contain data. ✅

## 📌 Notes
- The `INNER JOIN` ensures that only matching records from both tables are returned. 🔄
- The `ON` clause is used to specify the matching key between the tables. 🔑

### ✍️ Author
This document was created to demonstrate SQL JOIN operations using the **dvdrental** database. 🚀
