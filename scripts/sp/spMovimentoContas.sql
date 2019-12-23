DELIMITER //

CREATE  PROCEDURE `spMovimentoContas`(IN `p_ID` INT, IN `p_GRUPO` VARCHAR(50), IN `p_CONTA` VARCHAR(50), IN `p_USUARIO` VARCHAR(50))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT 'Controle de Plano de contas'
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = "PCONTA";

IF p_ID = "0" THEN
 INSERT INTO movimentos
         (
				GRUPO			,		
				CONTA			,
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_USUARIO	,            
				REGISTRO_INSERT_EMISSAO
         )
    VALUES 
         (
             trim(ucase(p_GRUPO))	 ,
             trim(ucase(p_CONTA))	 , 
             p_CATEGORIA   		  	 ,
             ucase(p_USUARIO)      	 ,
             now()
         );
ELSEIF p_ID <> "0" THEN

	IF p_CONTA <> "" THEN
		UPDATE movimentos
			SET 
				GRUPO			= trim(ucase(p_GRUPO)),
				CONTA			= trim(ucase(p_CONTA)),
	         REGISTRO_UPDATE_USUARIO  = ucase(p_USUARIO),
	         REGISTRO_UPDATE_EMISSAO	= now()
		WHERE ID = p_ID;
		
	ELSE
		DELETE FROM movimentos WHERE ID = p_ID;
	END IF;

END IF; 
       

END //

DELIMITER ;