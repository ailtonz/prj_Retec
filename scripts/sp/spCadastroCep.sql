DELIMITER //

CREATE  PROCEDURE `spCadastroCep`(IN `p_ID` INT, IN `p_CEP` VARCHAR(8), IN `p_ENDERECO` VARCHAR(50), IN `p_COMPLEMENTO` VARCHAR(50), IN `p_BAIRRO` VARCHAR(50), IN `p_CIDADE` VARCHAR(50), IN `p_ESTADO` VARCHAR(2), IN `p_CONTRATO_VALOR` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'UTEIS_CEP';

IF p_ID = "0" THEN
 INSERT INTO cadastros
         (
				ENDERECO               , 
				COMPLEMENTO            ,
				BAIRRO	              ,
				CEP		    			  ,
				CIDADE                 ,
				ESTADO	              ,
				CONTRATO_VALOR			  ,
				
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO 
         )
    VALUES 
         (
				trim(ucase(p_ENDERECO))   , 
				trim(ucase(p_COMPLEMENTO)), 
				trim(ucase(p_BAIRRO))   , 
				trim(ucase(p_CEP))   	 , 
				trim(ucase(p_CIDADE))   , 
				trim(ucase(p_ESTADO))   , 
				REPLACE(p_CONTRATO_VALOR,',','.'),
				
				p_CATEGORIA,
				
				now()						 , 				
				trim(ucase(p_USUARIO)),
				now()						 , 				
				trim(ucase(p_USUARIO)) 	
         );
ELSEIF p_ID <> "0" THEN

	IF p_CEP <> "" THEN
		UPDATE cadastros
			SET 
				ENDERECO 		= trim(ucase(p_ENDERECO))    , 
				COMPLEMENTO		= trim(ucase(p_COMPLEMENTO)) , 
				BAIRRO 			= trim(ucase(p_BAIRRO))   	 , 
				CEP 				= trim(ucase(p_CEP))   	 	 , 
				CIDADE 			= trim(ucase(p_CIDADE))      , 
				ESTADO 			= trim(ucase(p_ESTADO))      ,  
				CONTRATO_VALOR = REPLACE(p_CONTRATO_VALOR,',','.'),
				REGISTRO_UPDATE_USUARIO   	= ucase(p_USUARIO) 	,
				REGISTRO_UPDATE_EMISSAO		= now()	
			WHERE ID = p_ID;
	ELSE
		DELETE FROM cadastros WHERE ID = p_ID;
	END IF;
	
END IF; 

SELECT * FROM vw_cep;
         
END //

DELIMITER ;