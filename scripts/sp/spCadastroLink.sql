DELIMITER //

CREATE  PROCEDURE `spCadastroLink`(IN `p_ID` INT, IN `p_DESCRICAO` VARCHAR(50), IN `p_LINK` VARCHAR(255), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'UTEIS_LINKS';

IF p_ID = "0" THEN
 INSERT INTO cadastros
         (
				NOME,
				CADASTRO_OBSERVACAO	,
				REGISTRO_CATEGORIA   ,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO   
         )
    VALUES 
         (
				trim(ucase(p_DESCRICAO)), 
				trim(lcase(p_LINK)), 
				p_CATEGORIA ,
				now()						 , 				
				trim(ucase(p_USUARIO)),
				now()						 , 				
				trim(ucase(p_USUARIO)) 	
         );
ELSEIF p_ID <> "0" THEN

	IF p_DESCRICAO <> "" THEN
		UPDATE cadastros
			SET
				NOME	=	trim(ucase(p_DESCRICAO)),
				CADASTRO_OBSERVACAO		= 	trim(lcase(p_LINK)),
				REGISTRO_UPDATE_USUARIO	= 	ucase(p_USUARIO),
				REGISTRO_UPDATE_EMISSAO	=	curdate()
			WHERE
				ID	= p_ID;				
	ELSE
		DELETE FROM cadastros WHERE	ID	= p_ID;		
	END IF;  
	
END IF;  
         

         
END //

DELIMITER ;