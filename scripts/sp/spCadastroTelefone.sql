DELIMITER //

CREATE  PROCEDURE `spCadastroTelefone`(
IN `p_ID` INT
, IN `p_NOME` VARCHAR(50)
, IN `p_TELEFONE` VARCHAR(50)
, IN `p_EMAIL` VARCHAR(120)
, IN `p_CONTATO` VARCHAR(50)
, IN `p_OBSERVACAO` VARCHAR(255)
, IN `p_USUARIO` VARCHAR(10)
)
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'UTEIS_TELEFONE';

IF p_ID = "0" THEN
 INSERT INTO cadastros
         (
				NOME,
				TELEFONE,
				EMAIL,
				CONTATO,
				CADASTRO_OBSERVACAO,
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO     
         )
    VALUES 
         (
				trim(ucase(p_NOME)), 
				p_TELEFONE, 
				lcase(p_EMAIL), 
				ucase(p_CONTATO), 
				lcase(p_OBSERVACAO), 
				p_CATEGORIA,
				now(), 				
				trim(ucase(p_USUARIO)),
				now(), 				
				trim(ucase(p_USUARIO)) 	
         );

ELSEIF p_ID <> "0" THEN
	IF p_NOME <> "" THEN
		UPDATE cadastros
			SET
				NOME           = trim(ucase(p_NOME)),
				TELEFONE       = p_TELEFONE,
				EMAIL		      = lcase(p_EMAIL),
				CONTATO			= ucase(p_CONTATO),
				CADASTRO_OBSERVACAO     = lcase(p_OBSERVACAO),
				REGISTRO_UPDATE_USUARIO = ucase(p_USUARIO),
				REGISTRO_UPDATE_EMISSAO = now()			
		WHERE ID = p_ID;
	ELSE
		DELETE FROM cadastros WHERE	ID = p_ID;
	END IF; 

END IF;
        
                 
END //

DELIMITER ;