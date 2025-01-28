--city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini
--birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
--Bu sorgu, city tablosundaki tüm şehirleri ve bunlara karşılık gelen ülkeleri getirir. 
--Eğer bir şehir için country tablosunda eşleşen bir ülke bulunamazsa, NULL döndürülür.

SELECT city.city, country.country
FROM city
LEFT JOIN country ON city.country_id = country.country_id;

--customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini 
--birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
--Bu sorgu, payment tablosundaki tüm ödeme işlemlerini ve bunlara karşılık gelen müşteri isimlerini getirir. 
--Eğer bir ödeme kaydına karşılık bir müşteri bulunamazsa, NULL döndürülür.

SELECT payment.payment_id, customer.first_name, customer.last_name
FROM customer
RIGHT JOIN payment ON customer.customer_id = payment.customer_id;

--customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte 
--görebileceğimiz FULL JOIN sorgusunu yazınız.
--Bu sorgu, customer tablosundaki tüm müşterileri ve rental tablosundaki tüm kiralama işlemlerini getirir.
--Eşleşme olmayan satırlar için NULL değerleri döndürülür

SELECT rental.rental_id, customer.first_name, customer.last_name
FROM customer
FULL JOIN rental ON customer.customer_id = rental.customer_id;

