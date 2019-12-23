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

-- Dumping structure for procedure dbretec.sp_MOV_PCONTAS
DROP PROCEDURE IF EXISTS `sp_MOV_PCONTAS`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_MOV_PCONTAS`(IN `p_ACAO` VARCHAR(50), IN `p_ID_PLANO` INT, IN `p_CONTA` VARCHAR(50), IN `p_GRUPO` VARCHAR(50), IN `p_FREQUENCIA` VARCHAR(50), IN `p_PLANO` VARCHAR(50), IN `p_USUARIO` VARCHAR(50))
    COMMENT 'Controle de Plano de contas'
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);
DECLARE p_PLANO 		VARCHAR(50);
DECLARE p_MOVIMENTO 	VARCHAR(50);

SET p_CATEGORIA = "PCONTA";
SET p_PLANO     = "PROFISSIONAL";
SET p_MOVIMENTO = "DESPESA";

IF p_ACAO = "INSERT" THEN
 INSERT INTO vw_mov_plano_contas
         (
				CONTA			,
				GRUPO			,
				FREQUENCIA		,
            PLANO       , 
            MOVIMENTO   ,
            CADASTRO_CATEGORIA	,
            CADASTRO_USUARIO		,            
            CADASTRO_EMISSAO
         )
    VALUES 
         (
             trim(ucase(p_CONTA))	 , 
             trim(ucase(p_GRUPO))	 , 
             trim(ucase(p_FREQUENCIA)) , 
             trim(ucase(p_PLANO))	 , 
             trim(ucase(p_MOVIMENTO)), 
             p_CATEGORIA   		  	 ,
             ucase(p_USUARIO)      	 ,
             curdate()
         );
ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE vw_mov_plano_contas
		SET 
			CONTA			= trim(ucase(p_CONTA))   ,
			GRUPO			= trim(ucase(p_GRUPO))   ,
			FREQUENCIA		= trim(ucase(p_FREQUENCIA)),
         PLANO       = trim(ucase(p_PLANO))    , 
         MOVIMENTO   = trim(ucase(p_MOVIMENTO)),
         CADASTRO_USUARIO  = ucase(p_USUARIO)  ,
         CADASTRO_EMISSAO	= curdate()	
         
	WHERE ID = p_ID_PLANO;
	
ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM vw_mov_plano_contas WHERE ID = p_ID_PLANO;
END IF; 

END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
