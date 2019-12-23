	SELECT 
		cadastros.ID, 
		new_clientes_contatos.Nome,
		new_clientes_contatos.eMail,
		new_clientes_contatos.Telefone,	
		new_clientes_contatos.Observacao,	
		new_clientes_contatos.CADASTRO_CATEGORIA	
	FROM 
		new_clientes_contatos 
	INNER JOIN 
		cadastros 
		ON 
		cadastros.COBRANCA_INSCRICAO = new_clientes_contatos.strINSCRICAO;





SELECT 
	cadastros.ID, 
	new_clientes_contatos.Nome
FROM 
	new_clientes_contatos 
INNER JOIN 
	cadastros 
	ON 
	cadastros.COBRANCA_INSCRICAO = new_clientes_contatos.strINSCRICAO
WHERE 
	id = "1611314";