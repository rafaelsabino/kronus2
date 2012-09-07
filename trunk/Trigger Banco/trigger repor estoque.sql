create trigger devolverNoEstoque on LogEntrega
after delete

as
begin
	declare @cod int, @qtd int, @codFunc int
	
	select @cod = cod_item_fk, @qtd = qtd_log_entrega, @codFunc = cod_funcionario_fk from deleted
	update Item set quantidade_estoque = quantidade_estoque + @qtd where cod_item = @cod
	delete from Entrega where cod_item_fk = @cod and cod_funcionario_fk = @codFunc
end
go