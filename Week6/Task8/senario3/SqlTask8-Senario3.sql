----Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.----

-- 1. first_name'e göre last_name ve email güncelleme
UPDATE employee 
SET last_name = 'UpdatedLastName',
email = 'efsannrt@gmail.com' 
WHERE first_name = 'Bord';

-- 2. last_name'e göre birthday güncelleme
UPDATE employee 
SET birthday = '2000-01-01' 
WHERE last_name = 'Tonepohl';

-- 3. email'e göre first_name güncelleme
UPDATE employee 
SET first_name = 'Ela' 
WHERE email = 'aabby3@jiathis.com';

-- 4. birthday'e göre email güncelleme
UPDATE employee 
SET email = 'hakanalkn@gmail.com' 
WHERE birthday = '2018-02-20';

-- 5. last_name'e göre first_name ve email güncelleme
UPDATE employee 
SET first_name = 'ModifiedFirst', 
email = 'elamtlu@gmail.com' 
WHERE last_name = 'Dingle';
