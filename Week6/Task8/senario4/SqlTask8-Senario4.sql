--Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.--

-- 1. first_name'e göre satır silme
DELETE FROM employee 
WHERE first_name = 'Abbey';

-- 2. last_name'e göre satır silme
DELETE FROM employee 
WHERE last_name = 'Christmas';

-- 3. email'e göre satır silme
DELETE FROM employee 
WHERE email = 'skrojns@chicagotribune.com';

-- 4. birthday'e göre satır silme
DELETE FROM employee 
WHERE birthday = '2023-01-07';

-- 5. email NULL olan satırları silme
DELETE FROM employee 
WHERE email IS NULL;
