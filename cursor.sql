select * from Employees

--CURSOR --> bi k�meyi tut �ek ve o k�me i�inde d�n

--temp tablo ald�m ve bu temp tabloya bilgileri doldurdum tabloyu a�t�m tablonun �st�nde sat�r sat�r ilerledim
--k�saca temp tablo diyebilirsiniz
--CURSOR
declare @adi NVARCHAR(MAX), @soyadi NVARCHAR(MAX), @unvani NVARCHAR(MAX)

--cursor olu�turuyorum
declare PersonelCursor CURSOR
for
--cursor 
select FirstName, LastName, Title from Employees 
open PersonelCursor
FETCH NEXT from PersonelCursor into @adi, @soyadi , @unvani
--i�lem ba�ar�l� ise fetch status de�eri 0  olacakt�r
--datareader i�indeki while gibi d���n
while @@FETCH_STATUS = 0 --kay�t oldu�u s�rece
-- -1 ise kay�t bulunamad�
-- -2 eksik kay�t hatas� 
-- -9 kay�t geri getirilemiyor
begin 
print @adi + '-' + @soyadi + ' - ' + @unvani
--bir sonraki kay�ta ge�iyorum
FETCH NEXT from PersonelCursor into @adi, @soyadi , @unvani
end 
close PersonelCursor --�u anda haf�zada duruyor bunu haf�zadan bo�altmal�y�z
deallocate PersonelCursor --diyerek haf�zadan tamamen silmi� oluyoruz


--NEXT ile ilerle
--prior ile geri gel

-------------------------------------------------------------

--CURSOR
declare @adi2 NVARCHAR(MAX), @soyadi2 NVARCHAR(MAX), @unvani2 NVARCHAR(MAX)
declare PersonelCursor2 CURSOR scroll
--scroll koyarak ad�m ad�m ilerliyorum
for
--cursor 
select FirstName, LastName, Title from Employees 
open PersonelCursor2
FETCH first from PersonelCursor2 into @adi2, @soyadi2 , @unvani2
print @adi2 + '-' + @soyadi2 + ' - ' + @unvani2
FETCH last from PersonelCursor2 into @adi2, @soyadi2 , @unvani2
close PersonelCursor2
deallocate PersonelCursor2