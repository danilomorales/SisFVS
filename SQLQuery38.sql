USE [DBFIGUE2]
GO
/****** Object:  Trigger [Caja].[TG_PROD_ID]    Script Date: 25/07/2018 16:30:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER TRIGGER [Caja].[TG_PROD_ID]
   ON [Caja].[PRODUCTO]
   INSTEAD OF INSERT
AS 
declare
@id as nvarchar(8),
@gen as nvarchar(8),
@contador as int;
BEGIN
	set @contador = (SELECT COUNT(IdProducto) from Caja.PRODUCTO);
		set @id = right(@contador,4) + 1; 
		set @gen ='P-' + right('0000' + convert(varchar(8),@id),5)
		INSERT INTO Caja.PRODUCTO (IdProducto,Alias,IdCategoria,IdMedida,DescripcionProducto,TiempoDuracion,Stock,StockMaximo,StockMinimo,Valor_Unitario,PrecioVenta1,PrecioVenta2,PrecioOferta,Nota,Factor,Estado,Item,StockInicial,cta_vnt,Vigente)
		SELECT @gen,Alias,IdCategoria,IdMedida,DescripcionProducto,TiempoDuracion,Stock,StockMaximo,StockMinimo,Valor_Unitario,PrecioVenta1,PrecioVenta2,PrecioOferta,Nota,Factor,Estado,Item,StockInicial,cta_vnt,Vigente FROM inserted
END
