/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [IdProducto]
      ,[Alias]
      ,[IdCategoria]
      ,[IdMedida]
      ,[DescripcionProducto]
      ,[TiempoDuracion]
      ,[Stock]
      ,[StockMaximo]
      ,[StockMinimo]
      ,[Valor_Unitario]
      ,[PrecioVenta1]
      ,[PrecioVenta2]
      ,[PrecioOferta]
      ,[Nota]
      ,[Factor]
      ,[Estado]
      ,[Item]
      ,[StockInicial]
      ,[cta_vnt]
      ,[Vigente]
  FROM [DBFIGUE2].[dbo].[PRODUCTO]

/*    */
  USE [DBFIGUE2]
GO
/****** Object:  StoredProcedure [dbo].[SPFiltro_Busqueda]    Script Date: 26/07/2018 17:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPAgrega_Producto]
@filtro varchar (300)
as 
select
Alias, DescripcionProducto,Valor_Unitario from Caja.PRODUCTO
where Alias
Like @filtro + '%'


exec SPAgrega_Producto ''


GO
/****** Object:  StoredProcedure [dbo].[SPListarLCientes]    Script Date: 26/07/2018 17:35:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Alter proc

 [dbo].[SPListaProductos]
as
begin

select Alias, DescripcionProducto,Valor_Unitario from Caja.PRODUCTO
end 

exec dbo.SPListaProductos