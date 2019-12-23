DELIMITER //

CREATE  PROCEDURE `spCadastroPropaganda`(IN `p_ID_PROPAGANDA` INT, IN `p_PROPAGANDA` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'UTEIS_PROPAGANDA';

IF p_ID_PROPAGANDA = "0" THEN
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
	         ucase(p_PROPAGANDA), 
				p_CATEGORIA 			 ,
				now()						 , 				
				trim(ucase(p_USUARIO)),
				now()						 , 				
				trim(ucase(p_USUARIO)) 
         );

ELSEIF p_ID_PROPAGANDA <> "0" THEN

	IF p_PROPAGANDA <> "" THEN

		UPDATE cadastros
			SET
				CADASTRO_PROPAGANDA		= trim(ucase(p_PROPAGANDA)),
				REGISTRO_UPDATE_USUARIO = trim(ucase(p_USUARIO)),            
				REGISTRO_UPDATE_EMISSAO	= now()			
		WHERE ID 							= p_ID_PROPAGANDA;
		
	ELSE
		
		DELETE FROM cadastros WHERE	ID = p_ID_PROPAGANDA;	
		
	END IF;

END IF; 
                 
END //

DELIMITER ;