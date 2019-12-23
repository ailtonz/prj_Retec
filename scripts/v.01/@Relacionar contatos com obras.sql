insert into cadastros
(
	cadastros.ID_RELACAO,
	cadastros.CNPJ_CPF,
	cadastros.REGISTRO_CATEGORIA
)

select
	vw_dgv_clientes_contatos.ID as id_contato,
	vw_dgv_clientes_obras.ID as id_obra,
	'CONTATO_OBRA' AS CATEGORIA
from
	vw_dgv_clientes_contatos,vw_dgv_clientes_obras
where
	vw_dgv_clientes_obras.ID_CLIENTE = vw_dgv_clientes_contatos.ID_RELACAO;
	
	
	
	
-----------------------------------


SELECT 
	vw_dgv_clientes_obras.ID_CLIENTE,
	(SELECT vw_dgv_clientes.CLIENTE FROM vw_dgv_clientes WHERE vw_dgv_clientes.ID=vw_dgv_clientes_obras.ID_CLIENTE) AS tmpCLIENTE,
	CADASTRO_OBSERVACAO,
	vw_dgv_clientes_obras.COBRANCA_INSCRICAO
FROM 
	vw_dgv_clientes_obras 
WHERE 
	vw_dgv_clientes_obras.ID_CLIENTE is not null
	or
	vw_dgv_clientes_obras.ENDERECO is null
order by
	vw_dgv_clientes_obras.ID_CLIENTE