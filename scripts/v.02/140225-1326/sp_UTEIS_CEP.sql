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

-- Dumping structure for procedure dbretec.sp_UTEIS_CEP
DROP PROCEDURE IF EXISTS `sp_UTEIS_CEP`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_UTEIS_CEP`(IN `p_ACAO` VARCHAR(10), IN `p_CEP` VARCHAR(8), IN `p_ENDERECO` VARCHAR(50), IN `p_COMPLEMENTO` VARCHAR(50), IN `p_BAIRRO` VARCHAR(50), IN `p_CIDADE` VARCHAR(50), IN `p_ESTADO` VARCHAR(2), IN `p_CONTRATO_VALOR` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

DECLARE p_ID_CEP 	INT;

SET p_ID_CEP 	= (SELECT ID FROM cadastros WHERE CEP = p_CEP LIMIT 1);

SET p_CATEGORIA = 'UTEIS_CEP';

IF p_ACAO = "INSERT" THEN
 INSERT INTO cadastros
         (
				ENDERECO               , 
				COMPLEMENTO            ,
				BAIRRO	              ,
				CEP		    			  ,
				CIDADE                 ,
				ESTADO	              ,
				CONTRATO_VALOR			  ,
				
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO 
         )
    VALUES 
         (
				trim(ucase(p_ENDERECO))   , 
				trim(ucase(p_COMPLEMENTO)), 
				trim(ucase(p_BAIRRO))   , 
				trim(ucase(p_CEP))   	 , 
				trim(ucase(p_CIDADE))   , 
				trim(ucase(p_ESTADO))   , 
				REPLACE(p_CONTRATO_VALOR,',','.'),
				
				p_CATEGORIA   		   		 ,
				
				now()						 , 				
				trim(ucase(p_USUARIO)),
				now()						 , 				
				trim(ucase(p_USUARIO)) 	
         );
ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE cadastros
		SET 
			ENDERECO 		= trim(ucase(p_ENDERECO))    , 
			COMPLEMENTO		= trim(ucase(p_COMPLEMENTO)) , 
			BAIRRO 			= trim(ucase(p_BAIRRO))   	 , 
			CEP 			= trim(ucase(p_CEP))   	 	 , 
			CIDADE 			= trim(ucase(p_CIDADE))      , 
			ESTADO 			= trim(ucase(p_ESTADO))      ,  
			CONTRATO_VALOR = REPLACE(p_CONTRATO_VALOR,',','.'),

			REGISTRO_UPDATE_USUARIO   	= ucase(p_USUARIO) 	,
			REGISTRO_UPDATE_EMISSAO		= now()	

	WHERE ID = p_ID_CEP;
	
ELSEIF p_ACAO = "DELETE_ALL" THEN
	
	DELETE FROM cadastros WHERE ID = p_ID_CEP;
	
END IF; 

         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
