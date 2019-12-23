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

-- Dumping structure for procedure dbretec.sp_MOV_CONDICOES
DROP PROCEDURE IF EXISTS `sp_MOV_CONDICOES`;
DELIMITER //
CREATE DEFINER=`userRETEC`@`%` PROCEDURE `sp_MOV_TRANSACAO`(IN `p_ACAO` VARCHAR(10), IN `p_ID_TRANSACAO` INT, IN `p_TRANSACAO` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
    COMMENT 'FORMAS DE FATURAMENTO - EX: BOLETO, DEPOSITO E ETC...'
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'MOV_TRANSACAO';

IF p_ACAO = "INSERT" THEN
 INSERT INTO vw_mov_transacao
         (
            TRANSACAO    , 
				CADASTRO_CATEGORIA ,
				CAD_EMISSAO,
				CAD_USUARIO
         )
    VALUES 
         (
				trim(ucase(p_TRANSACAO)), 
				p_CATEGORIA ,
				now(),
				ucase(p_USUARIO)
         );

ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE vw_mov_transacao
		SET 
			TRANSACAO	= trim(ucase(p_TRANSACAO))   ,
         CAD_USUARIO = ucase(p_USUARIO)  ,
         CAD_EMISSAO	= now()	
         
	WHERE ID = p_ID_TRANSACAO;
         
ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM vw_mov_transacao WHERE ID = p_ID_TRANSACAO;
END IF;          


         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
