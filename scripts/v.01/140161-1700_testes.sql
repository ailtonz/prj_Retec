-- LISTAR VISÃO TEMPORARIA
select * from vw_inscricao LIMIT 1;


-- RELACIONAR ID DE CLIENTE COM INSCRICAO
UPDATE
	tmp_inscricao
	set 
	 	tmp_inscricao.ID_RELACAO = 
		 (
		 	select 
			 	id_cliente 
			from 
				vw_cad_clientes 
			where 
				vw_cad_clientes.COBRANCA_INSCRICAO = tmp_inscricao.COBRANCA_INSCRICAO )
	where 
			id_relacao =0 limit 1 
			

-- LISTAR TMP INSCRICOES		
select 
	* 
	from
		tmp_inscricao
	where 
			id_relacao =0 
			limit 1
			
-- ATUALIZAR TMP INSCRICOES			
update
	tmp_inscricao
	set
		tmp_inscricao.ID_RELACAO =0

-- CHECK CLIENTES
select 
	vw_cad_clientes.ID_CLIENTE,
	vw_cad_clientes.COBRANCA_INSCRICAO
	from vw_cad_clientes where vw_cad_clientes.COBRANCA_INSCRICAO = "00012686585889";

-- CHECK INSCRICOES
select 
	* 
	from
		tmp_inscricao
	where tmp_inscricao.COBRANCA_INSCRICAO = "00012686585889";