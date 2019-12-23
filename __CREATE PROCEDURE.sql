DELIMITER //

CREATE PROCEDURE `sp_UTEIS_CAD_CARGOS`(IN `p_ID_CARGO` INT, IN `p_CARGO` VARCHAR(20), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'FUNCIONARIO_CARGO';

IF p_ID_CARGO = "0" THEN
 INSERT INTO cadastros
         (
				CADASTRO_PROPAGANDA, 
				
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO 
         )
    VALUES 
         (
				trim(ucase(p_CARGO))   , 
				
				p_CATEGORIA,
				
				now()						 , 				
				trim(ucase(p_USUARIO)),
				now()						 , 				
				trim(ucase(p_USUARIO)) 	
         );
ELSEIF p_ID_CARGO <> "0" THEN


	IF p_CARGO <> "" THEN

		UPDATE cadastros
			SET 
				CADASTRO_PROPAGANDA 		= trim(ucase(p_CARGO))    , 
	
				REGISTRO_UPDATE_USUARIO   	= ucase(p_USUARIO) 	,
				REGISTRO_UPDATE_EMISSAO		= now()	
	
		WHERE ID = p_ID_CARGO;
	
	ELSE 
	
		DELETE FROM cadastros WHERE ID = p_ID_CARGO;
	
	END IF; 
	
END IF; 

END //

DELIMITER ;