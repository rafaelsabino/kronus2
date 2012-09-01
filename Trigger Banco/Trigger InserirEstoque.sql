--====================================
--  Create database trigger template 
--====================================

CREATE TRIGGER inserirEstoque ON notaFiscal 
AFTER insert
	 
AS 
	
BEGIN
	DECLARE
	@cod int, @quantidade int
	
	select @cod = cod_item_fk, @quantidade = quantidade_compra from inserted  
	
   update Item set quantidade_estoque = quantidade_estoque + @quantidade where Item.cod_item = @cod
   
   
END
GO


