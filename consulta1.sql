select * from caja.Usuario;
CREATE PROCEDURE SFIniciarSesion
@Usuario nvarchar(40),
@Contrasena nvarchar(50)
as
select * from caja.Usuario
where Login=@Usuario and Pass=@Contrasena;
go

exec SFIniciarSesion 'danilo','123'