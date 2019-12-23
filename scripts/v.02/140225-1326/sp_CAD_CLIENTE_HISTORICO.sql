-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.5.25a - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL version:             7.0.0.4053
-- Date/time:                    2014-02-25 13:53:42
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;

-- Dumping structure for procedure dbretec.sp_CAD_CLIENTE_HISTORICO
DROP PROCEDURE IF EXISTS `sp_CAD_CLIENTE_HISTORICO`;
DELIMITER //

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_CAD_CLIENTE_HISTORICO`(IN `p_ACAO` varCHAR(10), IN `p_ID_CLIENTE` INT, IN `p_ID_OBSERVACAO` INT, IN `p_OBSERVACAO` VARCHAR(1000), IN `p_USUARIO` VARCHAR(10))
    COMMENT 'OBSERVAÇÕES PARA CLIENTES'
BEGIN

DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'CLIENTE_HISTORICO';

IF p_ID_CLIENTE >0 THEN

	IF p_ACAO = "INSERT" THEN
	
	 INSERT INTO cadastros
	         (
	         	ID_CLIENTE,
	            HISTORICO,
			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 
	         )
	    VALUES 
	         (
	             p_ID_CLIENTE,
				trim(ucase(p_OBSERVACAO)), 
	             p_CATEGORIA,
	             ucase(p_USUARIO),
	             now(),
	             ucase(p_USUARIO),
	             now()
	         );
	         
	ELSEIF p_ACAO = "UPDATE" THEN
		UPDATE cadastros
			SET
				HISTORICO 	= trim(ucase(p_OBSERVACAO)),
				REGISTRO_UPDATE_USUARIO =  trim(ucase(p_USUARIO)),
				REGISTRO_UPDATE_EMISSAO = now()			
		WHERE
			ID = p_ID_OBSERVACAO;
	ELSEIF p_ACAO = "DELETE_ALL" THEN
		DELETE FROM vw_cad_clientes_historicos	WHERE ID = p_ID_OBSERVACAO;
	END IF;

END IF;

         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
