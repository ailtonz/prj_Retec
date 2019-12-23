INSERT INTO 
	vw_cad_clientes_contatos
	(ID_CLIENTE,
	CONTATO,
	EMAIL,
	TELEFONE,
	Observacao,
	CADASTRO_CATEGORIA)

	(
	SELECT 
		cadastros.ID, 
		LEFT(new_clientes_contatos.Nome,100) AS CONTATO,
		LEFT(new_clientes_contatos.eMail,120) AS eMail,
		LEFT(new_clientes_contatos.Telefone,100) AS TELEFONE,
		new_clientes_contatos.Observacao,	
		new_clientes_contatos.CADASTRO_CATEGORIA	
	FROM 
		new_clientes_contatos 
	INNER JOIN 
		cadastros 
		ON 
		cadastros.COBRANCA_INSCRICAO = new_clientes_contatos.strINSCRICAO
	);
	
SELECT * FROM vw_cad_clientes_contatos;