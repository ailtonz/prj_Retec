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

-- Dumping structure for procedure dbretec.sp_UTEIS_PROPAGANDA
DROP PROCEDURE IF EXISTS `sp_UTEIS_LINK`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_UTEIS_LINK`(IN `p_ACAO` VARCHAR(10), IN `p_ID_LINK` INT, IN `p_DESCRICAO` VARCHAR(50), IN `p_LINK` VARCHAR(255), IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'UTEIS_LINKS';

IF p_ACAO = "INSERT" THEN
 INSERT INTO cadastros
         (
				NOME,
				CADASTRO_OBSERVACAO	,
				REGISTRO_CATEGORIA   ,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO   
         )
    VALUES 
         (
				trim(ucase(p_DESCRICAO)), 
				trim(lcase(p_LINK)), 
				p_CATEGORIA ,
				now()						 , 				
				trim(ucase(p_USUARIO)),
				now()						 , 				
				trim(ucase(p_USUARIO)) 	
         );
ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE cadastros
		SET
			NOME	=	trim(ucase(p_DESCRICAO)),
			CADASTRO_OBSERVACAO		= 	trim(lcase(p_LINK)),
			REGISTRO_UPDATE_USUARIO	= 	ucase(p_USUARIO),
			REGISTRO_UPDATE_EMISSAO	=	curdate()
		WHERE
			ID	= p_ID_LINK;
			
ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM cadastros WHERE	ID	= p_ID_LINK;
	
END IF;  

         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
