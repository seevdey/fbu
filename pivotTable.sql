--pivot table
--sql de elde ettiðimiz tablo verilerini görsel açýdan daha iyi bir hale getirmek için pivot table kullanýrýz
select ShipCity, COUNT(*) as [Satýþ Adedi] from Orders group by ShipCity


--PIVOT TABLE YAZILISI

--select * from (select x, count(*) y from [table1] group by x )
--table2 
--pivot
--(
--sum(y) for x in ([value1], [value2],[value3],[value4],[value5],,,,,,)
--)


--dikey olan bu olayý soldan saða doðru yatay yapmak istiyorum
--yaptýðým olduðum sorguyu daha düzgün þekilde yapýyor
--ÖRNEK:
select * from (select ShipCity, COUNT(*) as [Satýþ Adedi] from Orders group by ShipCity)
PersonelSatislar
Pivot
(
	sum([Satýþ Adedi]) for ShipCity IN([Barcelona], [Berlin], [Köln], [Helsinki])
)PivotPersonelSatislar

--pivot yaptýktan sonra unpivot ta yapabiliyorsun yani yerleri deðiþiyor
unpivot 
(
	[Satýþ Adedi] for ShipCity IN([Barcelona], [Berlin], [Köln], [Helsinki])
)unpivot_table



