select * from Employees

--CURSOR --> bi kümeyi tut çek ve o küme içinde dön

--temp tablo aldým ve bu temp tabloya bilgileri doldurdum tabloyu açtým tablonun üstünde satýr satýr ilerledim
--kýsaca temp tablo diyebilirsiniz
--CURSOR
declare @adi NVARCHAR(MAX), @soyadi NVARCHAR(MAX), @unvani NVARCHAR(MAX)

--cursor oluþturuyorum
declare PersonelCursor CURSOR
for
--cursor 
select FirstName, LastName, Title from Employees 
open PersonelCursor
FETCH NEXT from PersonelCursor into @adi, @soyadi , @unvani
--iþlem baþarýlý ise fetch status deðeri 0  olacaktýr
--datareader içindeki while gibi düþün
while @@FETCH_STATUS = 0 --kayýt olduðu sürece
-- -1 ise kayýt bulunamadý
-- -2 eksik kayýt hatasý 
-- -9 kayýt geri getirilemiyor
begin 
print @adi + '-' + @soyadi + ' - ' + @unvani
--bir sonraki kayýta geçiyorum
FETCH NEXT from PersonelCursor into @adi, @soyadi , @unvani
end 
close PersonelCursor --þu anda hafýzada duruyor bunu hafýzadan boþaltmalýyýz
deallocate PersonelCursor --diyerek hafýzadan tamamen silmiþ oluyoruz


--NEXT ile ilerle
--prior ile geri gel

-------------------------------------------------------------

--CURSOR
declare @adi2 NVARCHAR(MAX), @soyadi2 NVARCHAR(MAX), @unvani2 NVARCHAR(MAX)
declare PersonelCursor2 CURSOR scroll
--scroll koyarak adým adým ilerliyorum
for
--cursor 
select FirstName, LastName, Title from Employees 
open PersonelCursor2
FETCH first from PersonelCursor2 into @adi2, @soyadi2 , @unvani2
print @adi2 + '-' + @soyadi2 + ' - ' + @unvani2
FETCH last from PersonelCursor2 into @adi2, @soyadi2 , @unvani2
close PersonelCursor2
deallocate PersonelCursor2