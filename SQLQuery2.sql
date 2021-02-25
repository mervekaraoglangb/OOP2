--Select 
--Ansii
Select ContactName,CompanyName SirketAdi ,City Sehir from Customers

Select * from Customers where City='Berlin'

--Case insensitive - Büyük küçük harf duyarsız 
--Or=ya da anlamında 
Select*From Products where CategoryID=1 or CategoryID=3

Select*From Products where CategoryID=1 and UnitPrice>=10
--ASC= küçükten büyüğe sıralama yani artan sıralama ilk olarak küçükten başlar
--DEsc=büyükten küçüğe sıralama yani azalan sıralama ilk olarak büyükten başlar
-- order by= sıralama demektir. 
select* from Products where CategoryID=1 order by UnitPrice asc 

--Count= adet demek. aynı ürünleri saymak için kullanılır. ÖR: aynı üründen kaç tane var gibi.
Select Count(*) Adet from Products 

-- sadece group by ile yapılan da Bütün kategorileri tekrar etmeyecek şekilde listele demek
--Count ekle dediğimizde her grupun tam sayısını ve kaç tane olduğunu gösterir
select CategoryID,Count (*) adet from Products group by CategoryID having count(*)>10




