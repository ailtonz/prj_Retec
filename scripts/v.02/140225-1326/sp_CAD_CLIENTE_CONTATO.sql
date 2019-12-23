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

-- Dumping structure for procedure dbretec.sp_CAD_CLIENTE_CONTATO
DROP PROCEDURE IF EXISTS `sp_CAD_CLIENTE_CONTATO`;
DELIMITER //

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_CAD_CLIENTE_CONTATO`(IN `p_CADASTRO` VARCHAR(50), IN `p_ACAO` VARCHAR(10), IN `p_ID_CONTATO` INT, IN `p_ID_RELACAO` INT, IN `p_CONTATO_NOME` VARCHAR(20), IN `p_CONTATO_TELEFONE` VARCHAR(100), IN `p_CONTATO_EMAIL` VARCHAR(120), IN `p_CONTATO_OBSERVACAO` VARCHAR(100), IN `p_CONTATO_SOLICITANTE` TINYINT, IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

IF p_CADASTRO = "CLIENTE" THEN
	
	SET p_CATEGORIA 	= "CONTATO_CLIENTE";
	
	IF p_ACAO = "INSERT" THEN
	
	 	INSERT INTO vw_cad_clientes_contatos
	         (
				ID_CLIENTE,
				CONTATO, 
				TELEFONE,
				EMAIL,
				OBSERVACAO,			
				SOLICITANTE,
				
			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 				
				
	
				)
	   VALUES 
	         (p_ID_RELACAO               ,
				trim(ucase(p_CONTATO_NOME)) ,
				p_CONTATO_TELEFONE          ,
				trim(lcase(p_CONTATO_EMAIL)),
				p_CONTATO_OBSERVACAO			 ,
				p_CONTATO_SOLICITANTE   	 ,
				p_CATEGORIA					    ,
				now(),
				trim(ucase(p_USUARIO)),
				now(),
				trim(ucase(p_USUARIO)));
	
	ELSEIF p_ACAO = "UPDATE" THEN
	
		UPDATE vw_cad_clientes_contatos
			SET
				CONTATO				= trim(ucase(p_CONTATO_NOME)) , 
				TELEFONE				= p_CONTATO_TELEFONE          ,
				EMAIL					= trim(lcase(p_CONTATO_EMAIL)),
				OBSERVACAO			= p_CONTATO_OBSERVACAO        ,						
				SOLICITANTE			= p_CONTATO_SOLICITANTE 	   ,			
				REGISTRO_UPDATE_EMISSAO			= 	now(),
				REGISTRO_UPDATE_USUARIO   		=	trim(ucase(p_USUARIO))
		WHERE
			ID = p_ID_CONTATO;
			
	ELSEIF p_ACAO = "DELETE_ALL" THEN		
	
		DELETE FROM vw_cad_clientes_contatos WHERE ID = p_ID_CONTATO;
			
	END IF;	
	
	SELECT * FROM vw_cad_clientes_contatos WHERE ID_CLIENTE = p_ID_RELACAO;
	
ELSEIF p_CADASTRO = "OBRA" THEN

	SET p_CATEGORIA = "CONTATO_OBRA";
	
	IF p_ACAO = "INSERT" THEN
	
	 	INSERT INTO vw_cad_clientes_obras_contatos
	         (
				ID_OBRA,
				CONTATO, 
				TELEFONE,
				EMAIL,
				OBSERVACAO,			
				SOLICITANTE,

			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 				
			 )
	   VALUES 
	         (p_ID_RELACAO               ,
				trim(ucase(p_CONTATO_NOME)) ,
				p_CONTATO_TELEFONE          ,
				trim(lcase(p_CONTATO_EMAIL)),
				p_CONTATO_OBSERVACAO			 ,
				p_CONTATO_SOLICITANTE   	 ,
				p_CATEGORIA					    ,
				now(),
				trim(ucase(p_USUARIO)),
				now(),
				trim(ucase(p_USUARIO)));
	
	ELSEIF p_ACAO = "UPDATE" THEN
	
		UPDATE vw_cad_clientes_obras_contatos
			SET
				CONTATO				= trim(ucase(p_CONTATO_NOME)) , 
				TELEFONE				= p_CONTATO_TELEFONE          ,
				EMAIL					= trim(lcase(p_CONTATO_EMAIL)),
				OBSERVACAO			= p_CONTATO_OBSERVACAO        ,						
				SOLICITANTE			= p_CONTATO_SOLICITANTE 	   ,			
				REGISTRO_UPDATE_EMISSAO			= 	now(),
				REGISTRO_UPDATE_USUARIO   		=	trim(ucase(p_USUARIO))
		WHERE
			ID = p_ID_CONTATO;
			
	ELSEIF p_ACAO = "DELETE" THEN		
	
		DELETE FROM vw_cad_clientes_obras_contatos WHERE ID = p_ID_CONTATO;
			
	END IF;	
	
	SELECT * FROM vw_cad_clientes_obras_contatos WHERE ID_OBRA = p_ID_RELACAO;
	
END IF;


         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
