SELECT 
	cadastros.ID,
	
	(Select vw_dgv_clientes_contatos.CONTATO from vw_dgv_clientes_contatos where vw_dgv_clientes_contatos.ID = cadastros.ID_RELACAO) AS CONTATO,
	cadastros.ID_RELACAO AS ID_CONTATO,

	(Select vw_dgv_clientes_obras.ENDERECO from vw_dgv_clientes_obras where vw_dgv_clientes_obras.ID = cadastros.CNPJ_CPF ) AS OBRA,
	cadastros.CNPJ_CPF AS ID_OBRA,

	cadastros.REGISTRO_CATEGORIA
from
	cadastros 
where
	(cadastros.REGISTRO_CATEGORIA = _utf8'CONTATO_OBRA') 