--   * yerine kategori seçilebilir ve kategori ismi değiştirilebilir.
--     Büyük Küçük Harf Duyarlılığı Yok.
Select ContactName Adi,CompanyName Sirketadi,City from Customers --customers verisinden tablo getirir.

Select * from Customers where City = 'London'


Select * from Products where CategoryID =1 or CategoryID=3
Select * from Products where UnitPrice<=19
select * from Products where CategoryID=1 and UnitPrice<20 and UnitsInStock>=15
select * from Products order by ProductName -- sıralamanın türü(mesela ürün adına göre)
select * from Products order by CategoryID,UnitPrice --virgül sırasına göre sıralama kısıtları ilerler
select * from Products order by UnitPrice asc  --artan (default özellik)
select * from Products where CategoryID=2 order by UnitPrice desc --azalan


select count(*) from Products -- kategorideki girdi sayısını hesaplar
select count(*) from Products where CategoryID= 2
select CategoryID from Products group by CategoryID --- GRUPLANDIRMA
select CategoryId Kategori,count(*) ÜrünSayısı from Products group by CategoryID 
select CategoryId,count(*) from Products group by CategoryID having count(*)<10 --2.count 1.ye uygulanır.
select CategoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 --20den pahalı ürün sayısı hangi kategoride 10 adetten azdır.


--slect * arası istenenler
-- inner join XXX on XX.YY = YY.ZZ  farklı 2 alandan bilgi getirtme(products, categories)
select Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID
select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice<15
select * from Products p left join [Order Details] od on p.ProductID= od.ProductID -- solda(left)olup sağda olmayan
select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null -- hiç ürün satın almayanlar tespit edilir.(null = sipişte olmayanlar.)

--Hangi Üründen Ne Kadar Satıldı
--product a order ve order details inner edilip toplamı bulunur.
select Products.ProductName ÜrünAdi,sum( [Order Details].UnitPrice*[Order Details].Quantity) ToplamSatış from Products inner join [Order Details] on [Order Details].ProductID=Products.ProductID inner join Orders on Orders.OrderID=[Order Details].OrderID group by ProductName order by ToplamSatış desc