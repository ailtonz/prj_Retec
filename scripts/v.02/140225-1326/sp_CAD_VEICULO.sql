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

-- Dumping structure for procedure dbretec.sp_CAD_VEICULO
DROP PROCEDURE IF EXISTS `sp_CAD_VEICULO`;
DELIMITER //
CREATE DEFINER=`userRETEC`@`%` PROCEDURE `sp_CAD_VEICULO`(IN `p_ACAO` VARCHAR(10), IN `p_ID_VEICULO` INT, IN `p_PLACA` VARCHAR(8), IN `p_MODELO` VARCHAR(25), IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'CAD_VEICULO';

IF p_ACAO = "INSERT" THEN
 INSERT INTO cadastros
         (
			PLACA, 
			MODELO,
			
			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 
         )
    VALUES 
         (
			trim(ucase(p_PLACA)), 
			trim(ucase(p_MODELO)), 
			p_CATEGORIA,
			now(), 				
			ucase(p_USUARIO), 
			now(),
			ucase(p_USUARIO) 
         );
ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE cadastros
		SET
			PLACA						= trim(ucase(p_PLACA)), 
			MODELO						= trim(ucase(p_MODELO)),
			REGISTRO_UPDATE_USUARIO 	= p_USUARIO,
			REGISTRO_UPDATE_EMISSAO 	= curdate()			
	WHERE
		ID = p_ID_VEICULO;
		
ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM cadastros WHERE ID = p_ID_VEICULO;
END IF;   

         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
