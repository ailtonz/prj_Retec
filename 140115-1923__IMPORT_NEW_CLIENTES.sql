INSERT INTO 
	vw_cad_clientes
	(CADASTRO_TIPO,
	CNPJ_CPF,
	IE_RG,
	NOME_FANTASIA,
	NOME,
	CONTATO,
	TELEFONE,
	CEP,
	CADASTRO_OBSERVACAO,
	COBRANCA_INSCRICAO,
	CADASTRO_CATEGORIA)

(SELECT 
		LEFT(strTipoPessoa,2) AS strTipoPessoa,
		LEFT(CNPJ,14) AS CNPJ,
		LEFT(IE,16) AS IE,
		LEFT(Apelido,50) AS Apelido,
		LEFT(Nome,100) AS Nome,
		LEFT(Contato,100) AS Contato,
		LEFT(Telefone,100) AS Telefone,
		LEFT(Cep,8) AS Cep,
		strOBS,
		LEFT(strINSCRICAO,14) AS strINSCRICAO,
		CADASTRO_CATEGORIA
FROM 
	new_clientes);
	
SELECT * FROM vw_cad_clientes;