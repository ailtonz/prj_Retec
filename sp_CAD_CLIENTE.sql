CREATE DEFINER=`Ailto_user`@`%` CREATE PROCEDURE `sp_CAD_CLIENTE`(IN `p_ACAO` VARCHAR(10), IN `p_ID_CLIENTE` INT, IN `p_CADASTRO_TIPO` VARCHAR(2), IN `p_CNPJ_CPF` VARCHAR(14), IN `p_IE_RG` VARCHAR(50), IN `p_NOME_FANTASIA` VARCHAR(50), IN `p_NOME` VARCHAR(100), IN `p_ENDERECO` VARCHAR(255), IN `p_NUMERO` VARCHAR(10), IN `p_COMPLEMENTO` VARCHAR(50), IN `p_BAIRRO` VARCHAR(50), IN `p_CEP` VARCHAR(8), IN `p_CIDADE` VARCHAR(50), IN `p_ESTADO` VARCHAR(2), IN `p_CONTATO` VARCHAR(20), IN `p_TELEFONE` VARCHAR(100), IN `p_EMAIL` VARCHAR(120), IN `p_CADASTRO_PROPAGANDA` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
IF p_ACAO = "INCLUSAO" THEN

 INSERT INTO vw_cad_clientes
         (CADASTRO_TIPO,
			CNPJ_CPF,	
			IE_RG,			
			NOME,			
			NOME_FANTASIA,
			CEP,	
			ENDERECO,
			NUMERO,			
			COMPLEMENTO,
			BAIRRO,		
			CIDADE,			
			ESTADO,			
			CONTATO,				
			TELEFONE,			
			EMAIL,			
			CADASTRO_PROPAGANDA,
			CAD_EMISSAO,
			CAD_USUARIO,
			ALT_EMISSAO,
			ALT_USUARIO,
			CADASTRO_CATEGORIA)
    VALUES 
         (ucase(p_CADASTRO_TIPO),
			p_CNPJ_CPF,
			p_IE_RG,		 
			ucase(p_NOME),
			ucase(p_NOME_FANTASIA),
			p_CEP,
			ucase(p_ENDERECO),
			p_NUMERO,
			ucase(p_COMPLEMENTO),
			ucase(p_BAIRRO),
			ucase(p_CIDADE),
			ucase(p_ESTADO),
			ucase(p_CONTATO),
			p_TELEFONE,
			lcase(p_EMAIL),
			ucase(p_CADASTRO_PROPAGANDA),
			now(),
			ucase(p_USUARIO),
			now(),
			ucase(p_USUARIO),
			"CLIENTE");
			
ELSEIF p_ACAO = "ATUALIZAR" THEN

	UPDATE vw_cad_clientes
		SET
			CADASTRO_TIPO				= trim(ucase(p_CADASTRO_TIPO)),
			CNPJ_CPF						= p_CNPJ_CPF,
			IE_RG							= p_IE_RG,
			NOME							= trim(ucase(p_NOME)),
			NOME_FANTASIA				= trim(ucase(p_NOME_FANTASIA)),
			CEP							= p_CEP,
			ENDERECO						= trim(ucase(p_ENDERECO)),
			NUMERO						= p_NUMERO,
			COMPLEMENTO					= trim(ucase(p_COMPLEMENTO)),
			BAIRRO						= trim(ucase(p_BAIRRO)), 
			CIDADE						= trim(ucase(p_CIDADE)),
			ESTADO						= trim(ucase(p_ESTADO)),
			CONTATO						= trim(ucase(p_CONTATO)),
			TELEFONE						= p_TELEFONE,
			EMAIL							= trim(lcase(p_EMAIL)), 
			CADASTRO_PROPAGANDA		= trim(ucase(p_CADASTRO_PROPAGANDA)),
			ALT_USUARIO   				= trim(ucase(p_USUARIO)),            
			ALT_EMISSAO					= now()			
	WHERE ID_CLIENTE 					= p_ID_CLIENTE;
	
ELSEIF p_ACAO = "EXCLUIR" THEN

	DELETE FROM	vw_cad_clientes WHERE ID = p_ID_CLIENTE
	
ELSEIF p_ACAO = "CARREGAR" THEN

	SELECT * FROM vw_cad_clientes
	
END IF

END