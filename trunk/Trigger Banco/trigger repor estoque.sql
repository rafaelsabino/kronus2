create trigger reporEstoque on LogEntrega
after delete
as
begin
	declare @cod int, @qtd int
	
	select @cod = cod_item_fk, @qtd = qtd_log_entrega from deleted
	update Item set quantidade_estoque = quantidade_estoque + @qtd where cod_item = @cod
end
go