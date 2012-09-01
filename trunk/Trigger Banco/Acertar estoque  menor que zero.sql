create trigger acertarEstoque on Item
after update

as
begin
	declare
		@cod int, @qtd int
		
		select @cod = cod_item, @qtd = quantidade_estoque from inserted
		
		if(@qtd < 0)
			update Item set quantidade_estoque = 0 where cod_item = @cod
		
end
go