DELIMITER //

CREATE  PROCEDURE `spCadastroFuncionarioCargo`(IN `p_ID` INT, IN `p_CARGO` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'FUNCIONARIO_CARGO';

IF p_ID = "0" THEN
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
ELSEIF p_ID <> "0" THEN


	IF p_CARGO <> "" THEN

		UPDATE cadastros
			SET 
				CADASTRO_PROPAGANDA 		= trim(ucase(p_CARGO))    , 
				REGISTRO_UPDATE_USUARIO   	= ucase(p_USUARIO) 	,
				REGISTRO_UPDATE_EMISSAO		= now()	
	
		WHERE ID = p_ID;
	
	ELSE 
	
		DELETE FROM cadastros WHERE ID = p_ID;
	
	END IF; 
	
END IF; 

select * from vw_funcionarios_cargos;
         
END //

DELIMITER ;