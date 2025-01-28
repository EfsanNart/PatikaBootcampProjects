# DVD Rental Database Query Scenarios 📀

This document showcases SQL query scenarios executed on the `dvdrental` example database. The scenarios involve operations on the `actor` and `customer` tables, specifically focusing on the `first_name` column. Let's explore each scenario! 🚀

---

## Query Scenarios 🔍

### 1. List All Unique First Names 🎭👤
Retrieve all unique `first_name` values from the `actor` and `customer` tables, ordered alphabetically.

```sql
SELECT first_name FROM actor
UNION
SELECT first_name FROM customer
ORDER BY first_name;
```

### 2. List Common First Names 🎭🤝👤
Retrieve `first_name` values that are present in both the `actor` and `customer` tables, ordered alphabetically.

```sql
SELECT first_name FROM actor
INTERSECT
SELECT first_name FROM customer
ORDER BY first_name;
```

### 3. List First Names in `actor` Only 🎭❌👤
Retrieve `first_name` values that are present in the `actor` table but not in the `customer` table, ordered alphabetically.

```sql
SELECT first_name FROM actor
EXCEPT
SELECT first_name FROM customer
ORDER BY first_name;
```

### 4. Include Duplicates in Queries 🔄
Perform the first three queries while including duplicate values:

#### 4.1 List All First Names (With Duplicates) 🎭👤🔄
Retrieve all `first_name` values (including duplicates) from the `actor` and `customer` tables, ordered alphabetically.

```sql
SELECT first_name FROM actor
UNION ALL
SELECT first_name FROM customer
ORDER BY first_name;
```

#### 4.2 List Common First Names (With Duplicates) 🎭🤝👤🔄
Retrieve `first_name` values (including duplicates) that are present in both the `actor` and `customer` tables, ordered alphabetically.

```sql
SELECT first_name FROM actor
INTERSECT ALL
SELECT first_name FROM customer
ORDER BY first_name;
```

#### 4.3 List First Names in `actor` Only (With Duplicates) 🎭❌👤🔄
Retrieve `first_name` values (including duplicates) that are present in the `actor` table but not in the `customer` table, ordered alphabetically.

```sql
SELECT first_name FROM actor
EXCEPT ALL
SELECT first_name FROM customer
ORDER BY first_name;
```

---

## How to Use These Queries 🛠️
1. Connect to the `dvdrental` PostgreSQL database.
2. Run each query in your SQL client or editor.
3. Observe the output and analyze the results for unique, common, or differing first names.

---

### Happy Querying! 🥳
