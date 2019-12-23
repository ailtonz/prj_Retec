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

-- Dumping structure for procedure dbretec.sp_CAD_CLIENTE
DROP PROCEDURE IF EXISTS `sp_CAD_CLIENTE`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_CAD_CLIENTE`(IN `p_ACAO` VARCHAR(10), IN `p_ID_CLIENTE` INT, IN `p_CADASTRO_TIPO` VARCHAR(2), IN `p_CNPJ_CPF` VARCHAR(14), IN `p_IE_RG` VARCHAR(50), IN `p_NOME_FANTASIA` VARCHAR(50), IN `p_NOME` VARCHAR(100), IN `p_CEP` VARCHAR(8), IN `p_NUMERO` VARCHAR(10), IN `p_COMPLEMENTO` VARCHAR(50), IN `p_ENDERECO` VARCHAR(200), IN `p_BAIRRO` VARCHAR(50), IN `p_CIDADE` VARCHAR(100), IN `P_ESTADO` VARCHAR(2), IN `p_CONTATO` VARCHAR(100), IN `p_TELEFONE` VARCHAR(100), IN `p_EMAIL` VARCHAR(120), IN `p_CADASTRO_OBSERVACAO` VARCHAR(1000), IN `p_CADASTRO_STATUS` VARCHAR(50), IN `p_CADASTRO_STATUS_OBSERVACAO` VARCHAR(50), IN `p_CADASTRO_PROPAGANDA` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = "CLIENTE";

IF p_ACAO = "INSERT" THEN

 INSERT INTO vw_cad_clientes
         (
			CADASTRO_TIPO,
			CNPJ_CPF,	
			IE_RG,			
			NOME,			
			NOME_FANTASIA,
			CEP,
			NUMERO,			
			COMPLEMENTO,
			ENDERECO,
			BAIRRO,
			CIDADE,
			ESTADO,
			CONTATO,				
			TELEFONE,			
			EMAIL,			
			CADASTRO_OBSERVACAO,
			CADASTRO_STATUS,
			CADASTRO_STATUS_OBSERVACAO,
			CADASTRO_PROPAGANDA,
			CAD_EMISSAO,
			CAD_USUARIO,
			ALT_EMISSAO,
			ALT_USUARIO,
			CADASTRO_CATEGORIA)
    VALUES 
         (
			ucase(p_CADASTRO_TIPO),
			p_CNPJ_CPF,
			p_IE_RG,
			ucase(p_NOME),
			ucase(p_NOME_FANTASIA),
			p_CEP,			
			p_NUMERO,
			ucase(p_COMPLEMENTO),
			ucase(p_ENDERECO),
			ucase(p_BAIRRO),
			ucase(p_CIDADE),
			ucase(p_ESTADO),			
			ucase(p_CONTATO),
			p_TELEFONE,
			lcase(p_EMAIL),
			ucase(p_CADASTRO_OBSERVACAO),
			ucase(p_CADASTRO_STATUS),
			ucase(p_CADASTRO_STATUS_OBSERVACAO),
			ucase(p_CADASTRO_PROPAGANDA),
			now(),
			ucase(p_USUARIO),			
			now(),
			ucase(p_USUARIO),
			p_CATEGORIA);			
			
ELSEIF p_ACAO = "UPDATE" THEN

	UPDATE vw_cad_clientes
		SET
			CADASTRO_TIPO						= trim(ucase(p_CADASTRO_TIPO)),
			CNPJ_CPF								= p_CNPJ_CPF,
			IE_RG									= p_IE_RG,
			NOME									= trim(ucase(p_NOME)),
			NOME_FANTASIA						= trim(ucase(p_NOME_FANTASIA)),
			CEP									= p_CEP,
			NUMERO								= p_NUMERO,
			COMPLEMENTO							= trim(ucase(p_COMPLEMENTO)),
			ENDERECO								=	trim(ucase(p_ENDERECO)),
			BAIRRO								=	trim(ucase(p_BAIRRO)),
			CIDADE								=	trim(ucase(p_CIDADE)),
			ESTADO								=	trim(ucase(p_ESTADO)),
			CONTATO								= trim(ucase(p_CONTATO)),
			TELEFONE								= p_TELEFONE,
			EMAIL									= trim(lcase(p_EMAIL)), 
			CADASTRO_OBSERVACAO				= ucase(p_CADASTRO_OBSERVACAO),
			CADASTRO_STATUS					= ucase(p_CADASTRO_STATUS),
			CADASTRO_STATUS_OBSERVACAO		= ucase(p_CADASTRO_STATUS_OBSERVACAO),
			CADASTRO_PROPAGANDA				= trim(ucase(p_CADASTRO_PROPAGANDA)),
			ALT_USUARIO   						= trim(ucase(p_USUARIO)),            
			ALT_EMISSAO							= now()			
	WHERE 
			ID_CLIENTE 					= p_ID_CLIENTE;
	

ELSEIF p_ACAO = "DELETE_ALL" THEN

	DELETE FROM vw_cad_clientes WHERE ID_CLIENTE IN (SELECT * FROM (SELECT ID_CLIENTE FROM vw_cad_clientes WHERE CNPJ_CPF = p_CNPJ_CPF) AS p);

END IF; 
         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
