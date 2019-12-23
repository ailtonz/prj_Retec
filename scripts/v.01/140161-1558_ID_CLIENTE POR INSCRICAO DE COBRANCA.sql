SELECT 
	cadastros.COBRANCA_INSCRICAO,
	cadastros.CADASTRO_CATEGORIA 
FROM 
	cadastros
WHERE
	cadastros.CADASTRO_CATEGORIA = "tmp_inscricao"

-- CRIAR "LISTA TEMPORARIA DE COBRANCA_INSCRICAO"
INSERT INTO 
	cadastros
	(
		cadastros.COBRANCA_INSCRICAO,
		cadastros.CADASTRO_CATEGORIA 
	)

	(
		SELECT DISTINCT
			vw_cad_clientes_contatos.COBRANCA_INSCRICAO,
			"tmp_inscricao" as id_inscricao
		FROM	
			vw_cad_clientes_contatos
	);

-- LISTAR "LISTA TEMPORARIA DE COBRANCA_INSCRICAO"
SELECT 
	cadastros.ID_RELACAO,
	cadastros.COBRANCA_INSCRICAO,
	cadastros.CADASTRO_CATEGORIA 
FROM 
	cadastros
WHERE
	cadastros.CADASTRO_CATEGORIA = "tmp_inscricao"
		
-- ATUALIZAR "LISTA TEMPORARIA DE COBRANCA_INSCRICAO"

UPDATE
	cadastros
	SET
		ID_RELACAO = (SELECT ID_cliente FROM vw_cad_clientes WHERE vw_cad_clientes.COBRANCA_INSCRICAO = cadastros.COBRANCA_INSCRICAO)
	WHERE
		cadastros.CADASTRO_CATEGORIA = "tmp_inscricao";