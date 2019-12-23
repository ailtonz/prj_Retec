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

-- Dumping structure for procedure dbretec.sp_CAD_FUNCIONARIO_CARGO
DROP PROCEDURE IF EXISTS `sp_CAD_FUNCIONARIO_CARGO`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_CAD_FUNCIONARIO_CARGO`(IN `p_ACAO` VARCHAR(50), IN `p_ID_CARGO` INT, IN `p_CARGO` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'FUNCIONARIO_CARGO';

IF p_ACAO = "INSERT" THEN

 INSERT INTO cadastros
         (
			CARGO,		
			
			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 
			)
    VALUES 
         (
			ucase(p_CARGO),		 
			
			p_CATEGORIA,
			now(),
			ucase(p_USUARIO),
			now(),
			ucase(p_USUARIO)
			
			);
			
ELSEIF p_ACAO = "UPDATE" THEN

	UPDATE cadastros
		SET
			CARGO						= trim(ucase(p_CARGO)),
			REGISTRO_UPDATE_USUARIO   	= trim(ucase(p_USUARIO)),            
			REGISTRO_UPDATE_EMISSAO		= now()			
	WHERE ID 				= p_ID_CARGO;
	
	
ELSEIF p_ACAO = "DELETE_ALL" THEN

	DELETE FROM cadastros WHERE ID IN (SELECT * FROM (SELECT ID FROM cadastros WHERE ID = p_ID_CARGO) AS p);

END IF;


         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
