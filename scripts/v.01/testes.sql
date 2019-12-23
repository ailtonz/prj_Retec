select * from vw_clientes where NOME_FANTASIA like "%ailton%";

select * from vw_clientes_contatos where id_relacao = 312604;

select * from vw_clientes_obras where id_relacao = 312604;

select * from vw_clientes_observacoes where id_relacao = 312604;

select * from vw_clientes_contatos where CONTATO like "%ailton%";

select * from vw_clientes_contatos;

update vw_clientes_contatos 
	set solicitante = null;