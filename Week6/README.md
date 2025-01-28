# Film and Payment Analysis Queries

This README file provides a detailed explanation of SQL queries designed to analyze data from the **film** and **payment** tables. The queries address specific business-related questions, enabling insights into film statistics and customer payment behaviors. 🎥💳

---

## Queries Overview 🔍

### 1. **Films Longer Than Average Length**
**Question:** How many films have a length greater than the average film length?

```sql
SELECT COUNT(*) FROM film
WHERE length > ( SELECT AVG(length) FROM film );
```
**Description:**
- Calculates the average film length from the `film` table.
- Counts the number of films whose length exceeds this average.

### 2. **Films with the Highest Rental Rate**
**Question:** How many films have the maximum rental rate?

```sql
SELECT COUNT(*) FROM film
WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);
```
**Description:**
- Identifies the maximum rental rate in the `film` table.
- Counts the number of films with this maximum rental rate.

### 3. **Films with the Lowest Rental Rate and Replacement Cost**
**Question:** Which films have the lowest rental rate and replacement cost?

```sql
SELECT *
FROM film
WHERE rental_rate = (SELECT MIN(rental_rate) FROM film)
AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);
```
**Description:**
- Finds the minimum rental rate and replacement cost in the `film` table.
- Selects all films that meet both criteria.

### 4. **Top Customers by Payment Count**
**Question:** Which customers have made the highest number of payments?

```sql
SELECT customer_id, COUNT(*) AS toplam_odeme_sayisi
FROM payment
GROUP BY customer_id
ORDER BY toplam_odeme_sayisi DESC;
```
**Description:**
- Groups payments by customer ID in the `payment` table.
- Counts the total payments for each customer.
- Orders the results in descending order to highlight the most active customers.

---

## How to Use 🛠️

1. **Database Access:** Ensure you have access to the database containing the `film` and `payment` tables.
2. **SQL Environment:** Execute the queries in a compatible SQL environment such as MySQL Workbench, PostgreSQL, or any database tool you prefer.
3. **Customize:** Modify the queries if additional filters or criteria are required for your analysis.

---

## Expected Output 📊

1. **Films Longer Than Average Length:** A single count representing the number of films exceeding the average length.
2. **Films with the Highest Rental Rate:** A single count showing how many films have the maximum rental rate.
3. **Films with the Lowest Rental Rate and Replacement Cost:** Details of the films (e.g., title, length, rental rate, etc.) meeting the criteria.
4. **Top Customers by Payment Count:** A list of customer IDs along with the count of their payments, sorted by the highest payment count.

---

## Notes 📝
- Ensure the database schema matches the table and column names used in the queries.
- Indexes on columns like `length`, `rental_rate`, and `customer_id` can improve query performance.
- For large datasets, consider limiting the results or optimizing the queries further.

---

Happy querying! 🚀

