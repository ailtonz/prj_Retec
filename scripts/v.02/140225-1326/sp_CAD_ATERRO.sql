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

-- Dumping structure for procedure dbretec.sp_CAD_ATERRO
DROP PROCEDURE IF EXISTS `sp_CAD_ATERRO`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_CAD_ATERRO`(IN `p_ACAO` VARCHAR(10), IN `p_ID_ATERRO` INT, IN `p_CADASTRO_TIPO` VARCHAR(2), IN `p_NOME_FANTASIA` VARCHAR(50), IN `p_NOME` VARCHAR(100), IN `p_ENDERECO` VARCHAR(255), IN `p_NUMERO` VARCHAR(10), IN `p_COMPLEMENTO` VARCHAR(50), IN `p_BAIRRO` VARCHAR(50), IN `p_CEP` VARCHAR(8), IN `p_CIDADE` VARCHAR(50), IN `p_ESTADO` VARCHAR(2), IN `p_CONTATO` VARCHAR(20), IN `p_TELEFONE` VARCHAR(100), IN `p_EMAIL` VARCHAR(120), IN `p_CNPJ_CPF` VARCHAR(14), IN `p_IE_RG` VARCHAR(16), IN `p_CADASTRO_STATUS` VARCHAR(20), IN `p_CADASTRO_OBSERVACAO` VARCHAR(50), IN `p_CONTRATO_VALOR` vaRCHAR(50), IN `p_USUARIO` VARCHAR(10))
    COMMENT 'CADASTRO DE ATERROS'
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'ATERRO';

IF p_ACAO = "INSERT" THEN
 INSERT INTO cadastros
         (
				CADASTRO_TIPO			,
				
				NOME_FANTASIA			,
				NOME					,
				
				ENDERECO				,
				NUMERO					,
				COMPLEMENTO				,
				BAIRRO					,
				CEP						,
				CIDADE					,
				ESTADO					,
				
				CONTATO					,
				TELEFONE				,
				EMAIL					,
				
				CNPJ_CPF				,
				IE_RG					,
				
				CADASTRO_STATUS			,
				CADASTRO_OBSERVACAO		,
				
				CONTRATO_VALOR			,
				
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO        	
         )
    VALUES 
         (
				trim(ucase(p_CADASTRO_TIPO))		,
				trim(ucase(p_NOME_FANTASIA))		,
				trim(ucase(p_NOME))					,
				trim(ucase(p_ENDERECO))				,
				p_NUMERO							,
				trim(ucase(p_COMPLEMENTO))			,
				trim(ucase(p_BAIRRO))				,		
				p_CEP								,
				trim(ucase(p_CIDADE))				,
				trim(ucase(p_ESTADO))				,
				trim(ucase(p_CONTATO))				,
				p_TELEFONE							,
				trim(lcase(p_EMAIL))				,
				p_CNPJ_CPF							,
				p_IE_RG								,
				trim(ucase(p_CADASTRO_STATUS))		,
				trim(ucase(p_CADASTRO_OBSERVACAO))	,
				REPLACE(p_CONTRATO_VALOR,',','.')	, 
				
				p_CATEGORIA							,
				now()						 		, 				
				ucase(p_USUARIO)	 				, 
				now()						 		,	 				
				ucase(p_USUARIO)   
         );
ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE cadastros
			SET
				CADASTRO_TIPO			=	trim(ucase(p_CADASTRO_TIPO)),
				NOME_FANTASIA			=	trim(ucase(p_NOME_FANTASIA)),
				NOME					=	trim(ucase(p_NOME)),
				ENDERECO				=	trim(ucase(p_ENDERECO)),
				NUMERO					=	p_NUMERO,
				COMPLEMENTO				=	trim(ucase(p_COMPLEMENTO)),
				BAIRRO					=	trim(ucase(p_BAIRRO)),
				CEP						=	p_CEP,
				CIDADE					=	trim(ucase(p_CIDADE)),
				ESTADO					=	trim(ucase(p_ESTADO)),
				CONTATO					=	trim(ucase(p_CONTATO)),
				TELEFONE				=	p_TELEFONE,
				EMAIL					=	trim(lcase(p_EMAIL)),
				CNPJ_CPF				=	p_CNPJ_CPF,
				IE_RG					=	p_IE_RG,
				CADASTRO_STATUS			=	trim(ucase(p_CADASTRO_STATUS)),
				CADASTRO_OBSERVACAO		=	trim(ucase(p_CADASTRO_OBSERVACAO)),
				CONTRATO_VALOR			=	REPLACE(p_CONTRATO_VALOR,',','.'),
				REGISTRO_UPDATE_USUARIO	= trim(ucase(p_USUARIO)),
				REGISTRO_UPDATE_EMISSAO	= curdate()			
		WHERE
			ID = p_ID_ATERRO;
ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM cadastros	WHERE ID = p_ID_ATERRO;
END IF;
         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
