--tek procta ekle ve g�ncelleyi eklemi� olduk
/*
create proc MusteriEkleveDuzenle
@id int,
@Ad� nvarchar(50),
@Soyad� nvarchar(50),
@sil bit,
@Adress nvarchar(250)
as
begin
if(@id = 0) --id 0 ise insert et
begin
	insert into MusteriBilgileri
	(Ad�,
	Soyad�,
	sil,
	Adres )
	values(
	@Ad�,
	@Soyad�,
	@sil,
	@Adress)
end 
else 
begin
	Update MusteriBilgileri
	set Ad� = @Ad�,
	Soyad� = @Soyad�,
	sil = @sil,
	Adres = @Adress
	where id = @id
end
end
*/


/*
create proc MusteriSil
@id nvarchar(50)
as begin
delete from MusteriBilgileri
where id = @id 
end
*/


/*
create proc MusteriSilYeni
@id nvarchar(50)
as begin
update MusteriBilgileri
set sil = 1
where id = @id 
end
*/

/*
create proc [dbo].[MusteriArama]
@Aramametni nvarchar(50)
as 
begin
select * from MusteriBilgileri
where (@Aramametni = '' or Ad� like '%' + @Aramametni + '%')
and sil = 0
end
*/


/*
create proc [dbo].[MusteriAramaSil]
@Aramametni nvarchar(50)
as 
begin
select * from MusteriBilgileri
where (@Aramametni = '' or Ad� like '%' + @Aramametni + '%')
and sil = 1
end
*/