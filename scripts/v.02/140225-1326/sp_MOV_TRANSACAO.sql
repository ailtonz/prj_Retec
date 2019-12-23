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

-- Dumping structure for procedure dbretec.sp_MOV_TRANSACAO
DROP PROCEDURE IF EXISTS `sp_MOV_TRANSACAO`;
DELIMITER //
CREATE DEFINER=`userRETEC`@`%` PROCEDURE `sp_MOV_TRANSACAO`(IN `p_ACAO` VARCHAR(10), IN `p_ID_TRANSACAO` INT, IN `p_TRANSACAO` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
    COMMENT 'FORMAS DE FATURAMENTO - EX: BOLETO, DEPOSITO E ETC...'
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'MOV_TRANSACAO';

IF p_ACAO = "INSERT" THEN
 INSERT INTO movimentos
         (
			TRANSACAO    , 
			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 
         )
    VALUES 
         (
				trim(ucase(p_TRANSACAO)), 
				p_CATEGORIA,
				now(),
				ucase(p_USUARIO),
				now(),
				ucase(p_USUARIO)
         );

ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE movimentos
		SET 
			TRANSACAO	= trim(ucase(p_TRANSACAO))   ,
			REGISTRO_UPDATE_USUARIO = ucase(p_USUARIO),
			REGISTRO_UPDATE_EMISSAO = now()
         
	WHERE ID = p_ID_TRANSACAO;
         
ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM movimentos WHERE ID = p_ID_TRANSACAO;
END IF;          


         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
