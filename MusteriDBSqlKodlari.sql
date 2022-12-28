--tek procta ekle ve güncelleyi eklemiþ olduk
/*
create proc MusteriEkleveDuzenle
@id int,
@Adý nvarchar(50),
@Soyadý nvarchar(50),
@sil bit,
@Adress nvarchar(250)
as
begin
if(@id = 0) --id 0 ise insert et
begin
	insert into MusteriBilgileri
	(Adý,
	Soyadý,
	sil,
	Adres )
	values(
	@Adý,
	@Soyadý,
	@sil,
	@Adress)
end 
else 
begin
	Update MusteriBilgileri
	set Adý = @Adý,
	Soyadý = @Soyadý,
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
where (@Aramametni = '' or Adý like '%' + @Aramametni + '%')
and sil = 0
end
*/


/*
create proc [dbo].[MusteriAramaSil]
@Aramametni nvarchar(50)
as 
begin
select * from MusteriBilgileri
where (@Aramametni = '' or Adý like '%' + @Aramametni + '%')
and sil = 1
end
*/