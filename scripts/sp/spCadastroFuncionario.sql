DELIMITER //

CREATE  PROCEDURE `spCadastroFuncionario`(
IN `p_ID` INT
, IN `p_CNPJ_CPF` VARCHAR(50)
, IN `p_IE_RG` VARCHAR(50)
, IN `p_NOME` VARCHAR(50)

, IN `p_TELEFONE` VARCHAR(50)
, IN `p_EMAIL` VARCHAR(120)
, IN `p_CONTATO` VARCHAR(50)

, IN `p_CEP` VARCHAR(8)
, IN `p_NUMERO` VARCHAR(10)
, IN `p_COMPLEMENTO` VARCHAR(50)
, IN `p_ENDERECO` VARCHAR(50)
, IN `p_BAIRRO` VARCHAR(50)
, IN `p_CIDADE` VARCHAR(50)
, IN `p_ESTADO` VARCHAR(2)

, IN `p_CARGO` VARCHAR(50)
, IN `p_CONTRATO_VALOR` VARCHAR(50)

, IN `p_USUARIO` VARCHAR(10)
)
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'FUNCIONARIO';

IF p_ID = "0" THEN
 INSERT INTO cadastros
         (
			CNPJ_CPF	,
			IE_RG		,
			NOME		,
			TELEFONE	,
			EMAIL		,
			CONTATO		,

			CEP		       ,
			NUMERO		   ,
			COMPLEMENTO    ,			
			ENDERECO       , 
			BAIRRO	       ,
			CIDADE         ,
			ESTADO	       ,
			
			CADASTRO_PROPAGANDA	,
			CONTRATO_VALOR 		,

			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 
         )
    VALUES 
         (
			trim(ucase(p_CNPJ_CPF)) , 
			trim(ucase(p_IE_RG))   	, 
			trim(ucase(p_NOME))   	, 
			
			p_TELEFONE   			, 
			trim(lcase(p_EMAIL))   	, 
			trim(ucase(p_CONTATO))  , 
			
			
			trim(ucase(p_CEP))  	, 
			p_NUMERO				,
			trim(ucase(p_COMPLEMENTO))	,			
			trim(ucase(p_ENDERECO))   	, 
			trim(ucase(p_BAIRRO))   	, 
			trim(ucase(p_CIDADE))   	, 
			trim(ucase(p_ESTADO))   	, 
			
			trim(ucase(p_CARGO))   , 
			REPLACE(p_CONTRATO_VALOR,',','.'),
			
			p_CATEGORIA,
			
			now()						 , 				
			trim(ucase(p_USUARIO)),
			now()						 , 				
			trim(ucase(p_USUARIO)) 	
         );
ELSEIF p_ID <> "0" THEN

	IF p_NOME <> "" THEN
		UPDATE cadastros
			SET 
				CNPJ_CPF	=	trim(ucase(p_CNPJ_CPF)) , 
				IE_RG		=	trim(ucase(p_IE_RG))   	, 
				NOME		=	trim(ucase(p_NOME))   	, 
				
				TELEFONE	=	p_TELEFONE   			, 
				EMAIL		=	trim(lcase(p_EMAIL))   	, 
				CONTATO		=	trim(ucase(p_CONTATO))  , 			
			
			
				CEP 			= trim(ucase(p_CEP))   	 	 , 
				NUMERO			= p_NUMERO					 ,
				COMPLEMENTO		= trim(ucase(p_COMPLEMENTO)) , 
				ENDERECO 		= trim(ucase(p_ENDERECO))    , 				
				BAIRRO 			= trim(ucase(p_BAIRRO))   	 , 				
				CIDADE 			= trim(ucase(p_CIDADE))      , 
				ESTADO 			= trim(ucase(p_ESTADO))      ,  
				
				CADASTRO_PROPAGANDA	=	trim(ucase(p_CARGO))   ,
				CONTRATO_VALOR 		= REPLACE(p_CONTRATO_VALOR,',','.'),
				
				REGISTRO_UPDATE_USUARIO   	= ucase(p_USUARIO) 	,
				REGISTRO_UPDATE_EMISSAO		= now()	
				
			WHERE ID = p_ID;
	ELSE
		DELETE FROM cadastros WHERE ID = p_ID;
	END IF;
	
END IF; 
        
END //

DELIMITER ;