create trigger excluiEstoque on notaFiscal
after delete

as
begin
declare
	@cod int, @quantidade int
	
	select @cod = cod_item_fk, @quantidade = quantidade_compra from deleted	
	update Item set quantidade_estoque = quantidade_estoque - @quantidade where Item.cod_item = @cod
	
end
go