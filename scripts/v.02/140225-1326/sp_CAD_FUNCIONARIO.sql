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

-- Dumping structure for procedure dbretec.sp_CAD_FUNCIONARIO
DROP PROCEDURE IF EXISTS `sp_CAD_FUNCIONARIO`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_CAD_FUNCIONARIO`(IN `p_ACAO` VARCHAR(10), IN `p_ID_FUNCIONARIO` INT, IN `p_CNPJ_CPF` VARCHAR(14), IN `p_IE_RG` VARCHAR(50), IN `p_CARGO` VARCHAR(50), IN `p_NOME` VARCHAR(100), IN `p_CEP` VARCHAR(8), IN `p_NUMERO` VARCHAR(10), IN `p_COMPLEMENTO` VARCHAR(50), IN `p_ENDERECO` VARCHAR(255), IN `p_BAIRRO` VARCHAR(50), IN `p_CIDADE` VARCHAR(50), IN `p_ESTADO` VARCHAR(2), IN `p_CONTATO` VARCHAR(20), IN `p_TELEFONE` VARCHAR(100), IN `p_EMAIL` VARCHAR(120), IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

DECLARE p_ID_FUNCIONARIO 	INT;

SET p_ID_FUNCIONARIO 	= (SELECT ID FROM cadastros WHERE CNPJ_CPF = p_CNPJ_CPF LIMIT 1);

SET p_CATEGORIA = 'FUNCIONARIO';

IF p_ACAO = "INSERT" THEN

 INSERT INTO cadastros
         (
			CNPJ_CPF,	
			IE_RG,
			CARGO,			
			NOME,			
			CEP,	
			ENDERECO,
			NUMERO,			
			COMPLEMENTO,
			BAIRRO,		
			CIDADE,			
			ESTADO,			
			CONTATO,				
			TELEFONE,			
			EMAIL,		
			
			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 			
			)
    VALUES 
         (
			p_CNPJ_CPF,
			p_IE_RG,
			ucase(p_CARGO),		 
			ucase(p_NOME),
			p_CEP,
			ucase(p_ENDERECO),
			p_NUMERO,
			ucase(p_COMPLEMENTO),
			ucase(p_BAIRRO),
			ucase(p_CIDADE),
			ucase(p_ESTADO),
			ucase(p_CONTATO),
			p_TELEFONE,
			lcase(p_EMAIL),
			
			p_CATEGORIA,
			now(),
			ucase(p_USUARIO),
			now(),
			ucase(p_USUARIO)			
			);
			
ELSEIF p_ACAO = "UPDATE" THEN

	UPDATE cadastros
		SET
			CNPJ_CPF				= p_CNPJ_CPF,
			IE_RG					= p_IE_RG,
			CARGO					= trim(ucase(p_CARGO)),
			NOME					= trim(ucase(p_NOME)),
			CEP						= p_CEP,
			ENDERECO				= trim(ucase(p_ENDERECO)),
			NUMERO					= p_NUMERO,
			COMPLEMENTO				= trim(ucase(p_COMPLEMENTO)),
			BAIRRO					= trim(ucase(p_BAIRRO)), 
			CIDADE					= trim(ucase(p_CIDADE)),
			ESTADO					= trim(ucase(p_ESTADO)),
			CONTATO					= trim(ucase(p_CONTATO)),
			TELEFONE				= p_TELEFONE,
			EMAIL					= trim(lcase(p_EMAIL)), 
			REGISTRO_UPDATE_USUARIO	= trim(ucase(p_USUARIO)),            
			REGISTRO_UPDATE_EMISSAO	= now()			
	WHERE ID 							= p_ID_FUNCIONARIO;
	

ELSEIF p_ACAO = "SELECT" THEN

	SELECT * FROM cadastros LIMIT 300;
	
ELSEIF p_ACAO = "SELECT_DUPLICADOS" THEN

	SELECT ID, CNPJ_CPF,nome, COUNT(CNPJ_CPF) records FROM cadastros GROUP BY CNPJ_CPF HAVING COUNT(CNPJ_CPF)>1;
	
ELSEIF p_ACAO = "SELECT_REGISTROS_DUPLICADOS" THEN

	SELECT * FROM cadastros WHERE ID in (SELECT ID FROM cadastros WHERE CNPJ_CPF = p_CNPJ_CPF);
	
ELSEIF p_ACAO = "DELETE_ALL" THEN

	DELETE FROM cadastros WHERE ID IN (SELECT * FROM (SELECT ID FROM cadastros WHERE CNPJ_CPF = p_CNPJ_CPF) AS p);

END IF; 

         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
