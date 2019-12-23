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

-- Dumping structure for procedure dbretec.sp_MOV_PCONTAS_GRUPOS
DROP PROCEDURE IF EXISTS `sp_MOV_PCONTAS_GRUPOS`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_MOV_PCONTAS_GRUPOS`(IN `p_ACAO` VARCHAR(50), IN `p_ID_GRUPO` INT, IN `p_GRUPO` VARCHAR(50), IN `p_USUARIO` VARCHAR(50))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = "PCONTA_GRUPO";

IF p_ACAO = "INSERT" THEN
 INSERT INTO vw_mov_plano_contas_grupos
         (
			GRUPO ,
            CADASTRO_CATEGORIA,
            CADASTRO_USUARIO	,            
            CADASTRO_EMISSAO
         )
    VALUES 
         (
             trim(ucase(p_GRUPO))	 , 
             p_CATEGORIA   		  	 ,
             ucase(p_USUARIO)      	 ,
             curdate()
         );
ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE vw_mov_plano_contas_grupos
		SET 
			GRUPO			= trim(ucase(p_GRUPO))   ,
         CADASTRO_USUARIO  = ucase(p_USUARIO)  ,
         CADASTRO_EMISSAO	= curdate()	
         
	WHERE ID = p_ID_GRUPO;
	
ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM vw_mov_plano_contas_grupos WHERE ID = p_ID_GRUPO;
END IF;          
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
