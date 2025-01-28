# 📌 DVD Rental SQL Queries

Welcome to the **DVD Rental Database Query Guide**! 🎬 This document provides SQL queries to retrieve essential information using **JOIN** operations on the `dvdrental` sample database. 🚀

---

## 📌 Queries Overview

### 1️⃣ LEFT JOIN: Retrieve City and Country Names 🌎
This query fetches all cities along with their corresponding countries. If a city has no associated country, it will still appear in the result.

```sql
SELECT city.city, country.country
FROM city
LEFT JOIN country ON city.country_id = country.country_id;
```

---

### 2️⃣ RIGHT JOIN: Retrieve Customer Names with Payments 💰
This query retrieves all payment transactions along with the **first name** and **last name** of the customers who made the payments.

```sql
SELECT payment.payment_id, customer.first_name, customer.last_name
FROM customer
RIGHT JOIN payment ON customer.customer_id = payment.customer_id;
```

---

### 3️⃣ FULL JOIN: Retrieve Customers and Their Rentals 🎥
This query returns all rental transactions along with the **first name** and **last name** of the customers. It ensures that customers without rentals and rentals without associated customers are included in the result.

```sql
SELECT rental.rental_id, customer.first_name, customer.last_name
FROM customer
FULL JOIN rental ON customer.customer_id = rental.customer_id;
```

If using **PostgreSQL**, you can also use:
```sql
SELECT rental.rental_id, customer.first_name, customer.last_name
FROM customer
FULL OUTER JOIN rental ON customer.customer_id = rental.customer_id;
```

---

## 🚀 Database & Compatibility
- These queries are designed for the **dvdrental** sample database.
- Compatible with **PostgreSQL** and other SQL databases with slight modifications.

📌 Enjoy querying your DVD rental database! Happy coding! 🚀

