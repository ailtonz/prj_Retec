-- CLIENTES SEM INSCRIÇÃO
SELECT
	vw_cad_clientes.COBRANCA_INSCRICAO,
	vw_cad_clientes.NOME
FROM 
	vw_cad_clientes
WHERE 
	vw_cad_clientes.COBRANCA_INSCRICAO is null;
	
-- CLIENTES COM INSCRIÇÃO	
SELECT
	vw_cad_clientes.ID_CLIENTE,
	vw_cad_clientes.COBRANCA_INSCRICAO,
	vw_cad_clientes.NOME
FROM 
	vw_cad_clientes
WHERE 
	vw_cad_clientes.COBRANCA_INSCRICAO ="00000218064896";
ORDER BY
	vw_cad_clientes.COBRANCA_INSCRICAO ASC;

-- CONTATOS	
SELECT
	vw_cad_clientes_contatos.ID_CLIENTE,
	vw_cad_clientes_contatos.COBRANCA_INSCRICAO,
	vw_cad_clientes_contatos.CONTATO
FROM 
	vw_cad_clientes_contatos
WHERE 
	vw_cad_clientes_contatos.COBRANCA_INSCRICAO <>""
ORDER BY
	vw_cad_clientes_contatos.COBRANCA_INSCRICAO;

-- RELACIONAR CONTATOS COM CLIENTES PELO " COBRANCA_INSCRICAO "
UPDATE
	vw_cad_clientes_contatos
SET
	vw_cad_clientes_contatos.ID_CLIENTE =(SELECT vw_cad_clientes.ID_CLIENTE FROM vw_cad_clientes where vw_cad_clientes.COBRANCA_INSCRICAO ="00000218064896")
	WHERE 
	vw_cad_clientes_contatos.COBRANCA_INSCRICAO ="00000218064896";
	
-- CONTATOS	
SELECT
	vw_cad_clientes_contatos.ID_CLIENTE,
	vw_cad_clientes_contatos.COBRANCA_INSCRICAO,
	vw_cad_clientes_contatos.CONTATO
FROM 
	vw_cad_clientes_contatos
WHERE 
	vw_cad_clientes_contatos.COBRANCA_INSCRICAO = "00000218064896"
ORDER BY
	vw_cad_clientes_contatos.COBRANCA_INSCRICAO;	
	
-- RELACIONAR CONTATOS COM CLIENTES
UPDATE
	cadastros
SET
 	cadastros.ID_RELACAO =(SELECT cadastros.ID FROM cadastros where cadastros.COBRANCA_INSCRICAO ="00000218064896" AND cadastros.CADASTRO_CATEGORIA = "CLIENTE")
	WHERE 
	cadastros.COBRANCA_INSCRICAO ="00000218064896" 
	AND 
	cadastros.CADASTRO_CATEGORIA = "CONTATO_CLIENTE";