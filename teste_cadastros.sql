-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               5.5.25a - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL version:             7.0.0.4053
-- Date/time:                    2013-01-23 00:00:43
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;

-- Dumping structure for view dbcacambas.vw_adm_aterros
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_adm_aterros` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`CADASTRO_TIPO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`NOME_FANTASIA` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`NOME` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`ENDERECO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`NUMERO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COMPLEMENTO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`BAIRRO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CEP` VARCHAR(8) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CIDADE` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`ESTADO` VARCHAR(2) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTATO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`TELEFONE` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`EMAIL` VARCHAR(120) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CNPJ_CPF` VARCHAR(14) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`IE_RG` VARCHAR(16) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CADASTRO_STATUS` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CADASTRO_OBSERVACAO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTRATO_VALOR` DECIMAL(18,2) NULL DEFAULT NULL,
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_adm_faturamentos
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_adm_faturamentos` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`CONTRATO_PLANO_FATURAMENTO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTRATO_FORMA_PAGAMENTO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTRATO_PERIDO_LOCACAO` INT(11) NULL DEFAULT NULL,
	`CONTRATO_RETIRADA_AUTOMATICA` INT(11) NULL DEFAULT NULL,
	`CONTRATO_VCTO_APOS_ENTREGA` INT(11) NULL DEFAULT NULL,
	`CONTRATO_VALOR` DECIMAL(18,2) NULL DEFAULT NULL,
	`CONTRATO_MULTA_MORA` DECIMAL(18,2) NULL DEFAULT NULL,
	`CONTRATO_MULTA_DIA` DECIMAL(18,2) NULL DEFAULT NULL,
	`CONTRATO_NF` TINYINT(1) NULL DEFAULT '0',
	`CONTRATO_ISS` TINYINT(1) NULL DEFAULT '0',
	`CONTRATO_CTR` TINYINT(1) NULL DEFAULT '0',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_adm_funcionarios
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_adm_funcionarios` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`NOME` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`ENDERECO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`NUMERO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COMPLEMENTO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`BAIRRO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CEP` VARCHAR(8) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CIDADE` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`ESTADO` VARCHAR(2) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CNPJ_CPF` VARCHAR(14) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`IE_RG` VARCHAR(16) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CARGO` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTATO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`TELEFONE` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`EMAIL` VARCHAR(120) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_adm_links
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_adm_links` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`DESCRICAO` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`LINK` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_adm_materiais
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_adm_materiais` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`MATERIAL` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_adm_propagandas
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_adm_propagandas` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`PROPAGANDA` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_adm_transportador
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_adm_transportador` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`Cadastro_Tipo` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`Nome` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`Endereco` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`Bairro` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CEP` VARCHAR(8) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`Cidade` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`Estado` VARCHAR(2) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`Contato` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`Telefone` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`Email` VARCHAR(120) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CNPJ_CPF` VARCHAR(14) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`LIMPURB` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_adm_veiculos
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_adm_veiculos` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`PLACA` VARCHAR(8) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`MODELO` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_clientes
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_clientes` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`CADASTRO_TIPO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`NOME_FANTASIA` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`NOME` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`ENDERECO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`NUMERO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COMPLEMENTO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`BAIRRO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CEP` VARCHAR(8) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CIDADE` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`ESTADO` VARCHAR(2) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTATO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`TELEFONE` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`EMAIL` VARCHAR(120) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CNPJ_CPF` VARCHAR(14) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`IE_RG` VARCHAR(16) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CADASTRO_STATUS` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CADASTRO_OBSERVACAO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`IDENTIFICACAO_SACADO` VARCHAR(28) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_clientes_contatos
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_clientes_contatos` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`ID_RELACAO` INT(11) NULL DEFAULT NULL,
	`SOLICITANTE` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTATO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`TELEFONE` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`EMAIL` VARCHAR(120) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_clientes_obras
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_clientes_obras` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`ID_RELACAO` INT(11) NULL DEFAULT NULL,
	`ENDERECO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`NUMERO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COMPLEMENTO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`BAIRRO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CEP` VARCHAR(8) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CIDADE` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`ESTADO` VARCHAR(2) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_SACADO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_CNPJ_CPF` VARCHAR(14) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`IDENTIFICACAO_SACADO` VARCHAR(28) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_LOGRADOURO` VARCHAR(40) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_BAIRRO` VARCHAR(12) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_CEP` VARCHAR(8) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_CIDADE` VARCHAR(15) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_ESTADO` VARCHAR(2) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_CONTATO` VARCHAR(15) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_TELEFONE` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`COBRANCA_EMAIL` VARCHAR(120) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTRATO_PLANO_FATURAMENTO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTRATO_FORMA_PAGAMENTO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CONTRATO_PERIDO_LOCACAO` INT(11) NULL DEFAULT NULL,
	`CONTRATO_RETIRADA_AUTOMATICA` INT(11) NULL DEFAULT NULL,
	`CONTRATO_VCTO_APOS_ENTREGA` INT(11) NULL DEFAULT NULL,
	`CONTRATO_VALOR` DECIMAL(18,2) NULL DEFAULT NULL,
	`CONTRATO_MULTA_MORA` DECIMAL(18,2) NULL DEFAULT NULL,
	`CONTRATO_MULTA_DIA` DECIMAL(18,2) NULL DEFAULT NULL,
	`CONTRATO_NF` TINYINT(1) NULL DEFAULT '0',
	`CONTRATO_ISS` TINYINT(1) NULL DEFAULT '0',
	`CONTRATO_CTR` TINYINT(1) NULL DEFAULT '0',
	`CONTRATO_INICIO` DATE NULL DEFAULT NULL,
	`CONTRATO_TERMINIO` DATE NULL DEFAULT NULL,
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_cliente_observacoes
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_cliente_observacoes` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`ID_RELACAO` INT(11) NULL DEFAULT NULL,
	`CADASTRO_OBSERVACAO` VARCHAR(255) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_cliente_status
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_cliente_status` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`STATUS_CLIENTE` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_cliente_status_observacao
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_cliente_status_observacao` (
	`ID` INT(11) NOT NULL DEFAULT '0',
	`STATUS_OBSERVACAO` VARCHAR(100) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_USUARIO` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8_general_ci',
	`CAD_EMISSAO` DATE NULL DEFAULT NULL
) ENGINE=MyISAM;


-- Dumping structure for view dbcacambas.vw_adm_aterros
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_adm_aterros`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_adm_aterros` AS SELECT 
	ID,
	CADASTRO_TIPO			,
	NOME_FANTASIA			,
	NOME					   ,
	ENDERECO					,
	NUMERO					,
	COMPLEMENTO				,
	BAIRRO					, 
	CEP                 	,
	CIDADE					,
	ESTADO					,
	CONTATO					,
	TELEFONE					,
	EMAIL						, 
	CNPJ_CPF					,
	IE_RG						,
	CADASTRO_STATUS		,
	CADASTRO_OBSERVACAO	,
	CONTRATO_VALOR			,
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "ADM_ATERRO"
ORDER BY
	Nome ;


-- Dumping structure for view dbcacambas.vw_adm_faturamentos
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_adm_faturamentos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_adm_faturamentos` AS SELECT 
	ID,
	CONTRATO_PLANO_FATURAMENTO		,
	CONTRATO_FORMA_PAGAMENTO		,
	CONTRATO_PERIDO_LOCACAO			,
	CONTRATO_RETIRADA_AUTOMATICA	,
	CONTRATO_VCTO_APOS_ENTREGA		,
	CONTRATO_VALOR						,
	CONTRATO_MULTA_MORA				,
	CONTRATO_MULTA_DIA				,
	CONTRATO_NF							,
	CONTRATO_ISS						,
	CONTRATO_CTR						,
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO
FROM 
	CADASTROS 
WHERE 
	Cadastro_Categoria = "ADM_FATURAMENTO"
ORDER BY
	CONTRATO_PLANO_FATURAMENTO ;


-- Dumping structure for view dbcacambas.vw_adm_funcionarios
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_adm_funcionarios`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_adm_funcionarios` AS SELECT 
	ID,
	NOME					   ,
	ENDERECO					,
	NUMERO					,
	COMPLEMENTO				,
	BAIRRO					, 
	CEP                 	,
	CIDADE					,
	ESTADO					,
	CNPJ_CPF					,
	IE_RG						,
	CADASTRO_STATUS		AS CARGO,
	CONTATO					,
	TELEFONE					,
	EMAIL						, 
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "ADM_FUNCIONARIO"
ORDER BY
	Nome ;


-- Dumping structure for view dbcacambas.vw_adm_links
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_adm_links`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_adm_links` AS SELECT 
	ID,
	NOME						AS DESCRICAO,
	CADASTRO_OBSERVACAO	AS LINK,
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "ADM_LINKS"
ORDER BY
	ID ;


-- Dumping structure for view dbcacambas.vw_adm_materiais
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_adm_materiais`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_adm_materiais` AS SELECT 
	ID,
	CADASTRO_OBSERVACAO 	AS MATERIAL,
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "ADM_MATERIAL"
ORDER BY
	MATERIAL ;


-- Dumping structure for view dbcacambas.vw_adm_propagandas
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_adm_propagandas`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_adm_propagandas` AS SELECT 
	ID,
	NOME					   AS PROPAGANDA,
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "ADM_PROPAGANDA"
ORDER BY
	PROPAGANDA ;


-- Dumping structure for view dbcacambas.vw_adm_transportador
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_adm_transportador`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_adm_transportador` AS SELECT 
	ID,
	Cadastro_Tipo			,
	Nome					   ,
	Endereco					,
	Bairro					, 
	CEP                 	,
	Cidade					,
	Estado					,
	Contato					,
	Telefone					,
	Email						, 
	CNPJ_CPF					,
	CADASTRO_OBSERVACAO	AS LIMPURB	,
	Sistema_Usuario      AS CAD_USUARIO , 
	Sistema_Emissao      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "ADM_TRANSPORTADOR"
ORDER BY
	Nome ;


-- Dumping structure for view dbcacambas.vw_adm_veiculos
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_adm_veiculos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_adm_veiculos` AS SELECT 
	ID,
	CEP                 	AS PLACA,
	Nome					   AS MODELO,
	Sistema_Usuario      AS CAD_USUARIO , 
	Sistema_Emissao      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "ADM_VEICULO"
ORDER BY
	PLACA ;


-- Dumping structure for view dbcacambas.vw_clientes
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_clientes`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_clientes` AS SELECT 
	ID,
	CADASTRO_TIPO			,
	NOME_FANTASIA			,
	NOME					   ,
	ENDERECO					,
	NUMERO					,
	COMPLEMENTO				,
	BAIRRO					, 
	CEP                 	,
	CIDADE					,
	ESTADO					,
	CONTATO					,
	TELEFONE					,
	EMAIL						, 
	CNPJ_CPF					,
	IE_RG						,
	CADASTRO_STATUS		,
	CADASTRO_OBSERVACAO	,
	CONCAT(LEFT(REPEAT(0,14),14-LENGTH(CNPJ_CPF)),CNPJ_CPF) AS IDENTIFICACAO_SACADO,		
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "CLIENTE"
ORDER BY
	Nome ;


-- Dumping structure for view dbcacambas.vw_clientes_contatos
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_clientes_contatos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_clientes_contatos` AS SELECT 
	ID,
	ID_RELACAO				,
	CADASTRO_TIPO			AS SOLICITANTE,
	CONTATO					,
	TELEFONE					,
	EMAIL						,
	SISTEMA_USUARIO      AS CAD_USUARIO, 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	CADASTROS 
WHERE 
	CADASTRO_CATEGORIA = "CLIENTE_CONTATO"
ORDER BY
	NOME, SOLICITANTE ;


-- Dumping structure for view dbcacambas.vw_clientes_obras
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_clientes_obras`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_clientes_obras` AS SELECT 
	ID,
	ID_RELACAO				,
	ENDERECO					,
	NUMERO					,
	COMPLEMENTO				,
	BAIRRO					, 
	CEP                 	,
	CIDADE					,
	ESTADO					,
	NOME_FANTASIA		   AS COBRANCA_SACADO,
	CNPJ_CPF					AS COBRANCA_CNPJ_CPF,
	CONCAT(LEFT(REPEAT(0,14),14-LENGTH(CNPJ_CPF)),CNPJ_CPF) AS IDENTIFICACAO_SACADO,	
	COBRANCA_LOGRADOURO	,
	COBRANCA_BAIRRO		,
	COBRANCA_CEP			,
	COBRANCA_CIDADE		,
	COBRANCA_ESTADO		,
	COBRANCA_CONTATO		,
	COBRANCA_TELEFONE		,
	COBRANCA_EMAIL			,
	CONTRATO_PLANO_FATURAMENTO		,
	CONTRATO_FORMA_PAGAMENTO		,
	CONTRATO_PERIDO_LOCACAO			,
	CONTRATO_RETIRADA_AUTOMATICA	,
	CONTRATO_VCTO_APOS_ENTREGA		,
	CONTRATO_VALOR						,
	CONTRATO_MULTA_MORA				,
	CONTRATO_MULTA_DIA				,
	CONTRATO_NF							,
	CONTRATO_ISS						,
	CONTRATO_CTR						,
	CONTRATO_INICIO					,
	CONTRATO_TERMINIO					,
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "CLIENTE_OBRA"
ORDER BY
	BAIRRO ;


-- Dumping structure for view dbcacambas.vw_cliente_observacoes
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_cliente_observacoes`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_cliente_observacoes` AS SELECT 
	ID,
	ID_RELACAO				,
	CADASTRO_OBSERVACAO				,
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "CLIENTE_OBSERVACAO"
ORDER BY
	ID DESC ;


-- Dumping structure for view dbcacambas.vw_cliente_status
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_cliente_status`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_cliente_status` AS SELECT 
	ID,
	NOME					   AS STATUS_CLIENTE,
	SISTEMA_USUARIO      AS CAD_USUARIO, 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	Cadastros 
WHERE 
	Cadastro_Categoria = "CLIENTE_STATUS"
ORDER BY
	STATUS_CLIENTE ;


-- Dumping structure for view dbcacambas.vw_cliente_status_observacao
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_cliente_status_observacao`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` VIEW `vw_cliente_status_observacao` AS SELECT 
	ID,
	NOME					   AS STATUS_OBSERVACAO,
	SISTEMA_USUARIO      AS CAD_USUARIO , 
	SISTEMA_EMISSAO      AS CAD_EMISSAO

FROM 
	CADASTROS 
WHERE 
	CADASTRO_CATEGORIA = "CLIENTE_STATUS_OBSERVACAO"
ORDER BY
	STATUS_OBSERVACAO ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
