USE [DBFIGUE2]
GO
/****** Object:  StoredProcedure [Caja].[SP_ClienteReceptorBusquedaCliente_SEL]    Script Date: 20/07/2018 14:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER	 procedure [Caja].[SP_ClienteReceptorBusquedaCliente_SEL]
/*
////////////////////////////////////////////////////////////////////////////
--Autor: Alejandro Gutierrez
--Fecha Creación: 01/02/2018
--Modifica: 
--Fecha Modificación:
--Descripción del SP: Devuelve la busqueda de clientes para Venta.
////////////////////////////////////////////////////////////////////////////
*/
(
@vTipoBusqueda int,
@vCriterio varchar(50)
)
as
BEGIN
	 BEGIN
		SELECT IdClienteReceptor ,Nombres+ ' ' + ApellidoPaterno + ' ' + ApellidoMaterno as Cliente, NumeroRuc, NroDocIdentidad FROM Caja.ClienteReceptor WHERE NroDocIdentidad LIKE @vCriterio AND Estado = 1 order by 1
	 END

	 BEGIN
		SELECT IdClienteReceptor ,RazonSocial as Cliente,NumeroRuc,ISNULL(NroDocIdentidad,'') as NroDocIdentidad FROM Caja.ClienteReceptor WHERE NumeroRuc LIKE @vCriterio AND Estado = 1 order by 1
	 END
	 BEGIN
		SELECT IdClienteReceptor ,RazonSocial as Cliente,NumeroRuc,ISNULL(NroDocIdentidad,'') as NroDocIdentidad FROM Caja.ClienteReceptor WHERE RazonSocial LIKE @vCriterio AND Estado = 1 order by 1
	 END
	 BEGIN
		SELECT IdClienteReceptor ,RazonSocial as Cliente,NumeroRuc,ISNULL(NroDocIdentidad,'') as NroDocIdentidad FROM Caja.ClienteReceptor WHERE NombreComercial LIKE @vCriterio AND Estado = 1 order by 1
	 END
	 BEGIN
		SELECT IdClienteReceptor ,Nombres+ ' ' + ApellidoPaterno + ' ' + ApellidoMaterno as Cliente,NumeroRuc,ISNULL(NroDocIdentidad,'') as NroDocIdentidad FROM Caja.ClienteReceptor WHERE Nombres+ ' ' + ApellidoPaterno + ' ' + ApellidoMaterno LIKE @vCriterio AND Estado = 1 order by 1
	 END
END


exec Caja.SP_ClienteReceptorBusquedaCliente_SEL '',''


create proc SPListarLCientes
as
begin
select * from Caja.ClienteReceptor;
end 
exec SPListarLCientes


create proc SPFiltro_Busqueda
@filtro varchar (300)
as 
select NroDocIdentidad, NumeroRuc,NombreComercial, Nombres, ApellidoPaterno, ApellidoMaterno from Caja.ClienteReceptor
where Nombres like @filtro + '%'

exec SPFiltro_Busqueda ''


select Nombres from ClienteReceptor;


