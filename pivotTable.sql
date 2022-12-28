--pivot table
--sql de elde etti�imiz tablo verilerini g�rsel a��dan daha iyi bir hale getirmek i�in pivot table kullan�r�z
select ShipCity, COUNT(*) as [Sat�� Adedi] from Orders group by ShipCity


--PIVOT TABLE YAZILISI

--select * from (select x, count(*) y from [table1] group by x )
--table2 
--pivot
--(
--sum(y) for x in ([value1], [value2],[value3],[value4],[value5],,,,,,)
--)


--dikey olan bu olay� soldan sa�a do�ru yatay yapmak istiyorum
--yapt���m oldu�um sorguyu daha d�zg�n �ekilde yap�yor
--�RNEK:
select * from (select ShipCity, COUNT(*) as [Sat�� Adedi] from Orders group by ShipCity)
PersonelSatislar
Pivot
(
	sum([Sat�� Adedi]) for ShipCity IN([Barcelona], [Berlin], [K�ln], [Helsinki])
)PivotPersonelSatislar

--pivot yapt�ktan sonra unpivot ta yapabiliyorsun yani yerleri de�i�iyor
unpivot 
(
	[Sat�� Adedi] for ShipCity IN([Barcelona], [Berlin], [K�ln], [Helsinki])
)unpivot_table



