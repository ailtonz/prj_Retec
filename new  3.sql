BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'STATUS_LIGACAO';

IF p_ACAO = "INSERT" THEN
 INSERT INTO servicos
         (
				SERVICO_STATUS,

				
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO     
         )
    VALUES 
         (
				ucase(p_STATUS), 
				p_CATEGORIA,
				now(), 				
				trim(ucase(p_USUARIO)),
				now(), 				
				trim(ucase(p_USUARIO)) 	
         );

ELSEIF p_ACAO = "UPDATE" THEN

	UPDATE servicos
		SET
			SERVICO_STATUS          		= ucase(p_STATUS),
			REGISTRO_UPDATE_USUARIO = ucase(p_USUARIO),
			REGISTRO_UPDATE_EMISSAO = now()	
	WHERE ID = p_ID_STATUS;


ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM servicos WHERE	ID = p_ID_STATUS;
END IF; 
         
END