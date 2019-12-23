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

-- Dumping structure for procedure dbretec.sp_UTEIS_TELEFONE
DROP PROCEDURE IF EXISTS `sp_UTEIS_TELEFONE`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_UTEIS_TELEFONE`(IN `p_ACAO` VARCHAR(10), IN `p_ID_TELEFONE` INT, IN `p_NOME` VARCHAR(50), IN `p_TELEFONE` VARCHAR(50), IN `p_EMAIL` VARCHAR(120), IN `p_CONTATO` VARCHAR(50), IN `p_OBSERVACAO` VARCHAR(255), IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = "UTEIS_TELEFONE";

IF p_ACAO = "INSERT" THEN
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

ELSEIF p_ACAO = "UPDATE" THEN

	UPDATE cadastros
		SET
			NOME              = trim(ucase(p_NOME)),
			TELEFONE          = p_TELEFONE,
			EMAIL		      = lcase(p_EMAIL),
			CONTATO			  = ucase(p_CONTATO),
			CADASTRO_OBSERVACAO     = lcase(p_OBSERVACAO),
			REGISTRO_UPDATE_USUARIO = ucase(p_USUARIO),
			REGISTRO_UPDATE_EMISSAO = now()			
	WHERE ID = p_ID_PROPAGANDA;


ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM cadastros WHERE	ID = p_ID_PROPAGANDA;
END IF; 
         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
