DELIMITER //

CREATE  PROCEDURE spCadastroTipoCadastro(IN p_ID INT, IN p_TIPO VARCHAR(50), IN p_USUARIO VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = "UTEIS_TIPO_CADASTRO";

IF p_ID = "0" THEN
 INSERT INTO cadastros
         (
				CADASTRO_TIPO,
				
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO     
         )
    VALUES 
         (
				ucase(p_TIPO), 
				p_CATEGORIA,
				now(), 				
				trim(ucase(p_USUARIO)),
				now(), 				
				trim(ucase(p_USUARIO)) 	
         );

ELSEIF p_ID <> "0" THEN

	IF p_TIPO <> "" THEN
		UPDATE cadastros
			SET
				CADASTRO_TIPO          	= ucase(p_TIPO),
				REGISTRO_UPDATE_USUARIO = ucase(p_USUARIO),
				REGISTRO_UPDATE_EMISSAO = now()			
		WHERE ID = p_ID;
	
	
	ELSE
		DELETE FROM cadastros WHERE	ID = p_ID;
	END IF; 
END IF; 
         
END //

DELIMITER ;