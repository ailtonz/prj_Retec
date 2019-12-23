INSERT INTO 
	vw_cad_clientes_contatos
	(CONTATO,
	EMAIL,
	TELEFONE,
	Observacao,
	COBRANCA_INSCRICAO,
	CADASTRO_CATEGORIA)

	(
	SELECT 
		LEFT(new_clientes_contatos.Nome,100) AS CONTATO,
		LEFT(new_clientes_contatos.eMail,120) AS eMail,
		LEFT(new_clientes_contatos.Telefone,100) AS TELEFONE,
		new_clientes_contatos.Observacao,
		new_clientes_contatos.strINSCRICAO,	
		new_clientes_contatos.CADASTRO_CATEGORIA	
	FROM 
		new_clientes_contatos 

	);
	
SELECT * FROM vw_cad_clientes_contatos;

--DELETE FROM vw_cad_clientes_contatos;