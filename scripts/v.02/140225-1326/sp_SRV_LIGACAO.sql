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

-- Dumping structure for procedure dbretec.sp_SRV_LIGACAO
DROP PROCEDURE IF EXISTS `sp_SRV_LIGACAO`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_SRV_LIGACAO`(IN `p_ACAO` VARCHAR(10), IN `p_ID_SERVICO` INT, IN `p_ID_CADASTRO` INT, IN `p_ID_OBRA` INT, IN `p_ID_SOLICITANTE` INT, IN `p_ID_MATERIAL` INT, IN `p_PEDIDO_COLOCA` INT, IN `p_PEDIDO_TROCA` INT, IN `p_PEDIDO_RETIRA` INT, IN `p_PEDIDO_DT_COLOCA` VARCHAR(10), IN `p_PEDIDO_DT_TROCA` VARCHAR(10), IN `p_PEDIDO_DT_RETIRA` VARCHAR(10), IN `p_PEDIDO_PR_COLOCA` TINYINT, IN `p_PEDIDO_PR_TROCA` TINYINT, IN `p_PEDIDO_PR_RETIRA` TINYINT, IN `p_PEDIDO_OBS_COLOCA` VARCHAR(200), IN `p_PEDIDO_OBS_TROCA` VARCHAR(200), IN `p_PEDIDO_OBS_RETIRA` VARCHAR(200), IN `p_PEDIDO_OBS_LIGACAO` VARCHAR(200), IN `p_PEDIDO_MATERIAL` VARCHAR(255), IN `p_OBRA_CEP` VARCHAR(8), IN `p_OBRA_NUMERO` VARCHAR(10), IN `p_OBRA_COMPLEMENTO` VARCHAR(50), IN `p_OBRA_ENDERECO` VARCHAR(200), IN `p_OBRA_BAIRRO` VARCHAR(50), IN `p_OBRA_CIDADE` VARCHAR(100), IN `p_OBRA_ESTADO` VARCHAR(2), IN `p_OBRA_SOLICITANTE` VARCHAR(100), IN `p_OBRA_SOLICITANTE_TELEFONE` VARCHAR(100), IN `p_OBRA_SOLICITANTE_EMAIL` VARCHAR(120), IN `p_SERVICO_NOME` VARCHAR(100), IN `p_SERVICO_CONTATO` VARCHAR(100), IN `p_SERVICO_TELEFONE` VARCHAR(100), IN `p_SERVICO_EMAIL` VARCHAR(120), IN `p_SERVICO_VIAGEM` INT, IN `p_SERVICO_ORDEM` INT, IN `p_SERVICO_INICIO` VARCHAR(10), IN `p_SERVICO_TERMINIO` VARCHAR(10), IN `p_SERVICO_STATUS` VARCHAR(3), IN `p_CONTRATO_FORMA_PAGAMENTO` VARCHAR(50), IN `p_CONTRATO_FATURAMENTO_DIAS` INT, IN `p_CONTRATO_PERIODO_LOCACAO` INT, IN `p_CONTRATO_RETIRADA_AUTOMATICA` INT, IN `p_CONTRATO_VCTO_APOS_ENTREGA` INT, IN `p_CONTRATO_VALOR` VARCHAR(50), IN `p_CONTRATO_MULTA_MORA` VARCHAR(50), IN `p_CONTRATO_MULTA_DIA` VARCHAR(50), IN `p_CONTRATO_NFE` TINYINT, IN `p_CONTRATO_ISS` TINYINT, IN `p_CONTRATO_CTR` TINYINT, IN `p_COBRANCA_TIPO` VARCHAR(2), IN `p_COBRANCA_INSCRICAO` VARCHAR(14), IN `p_COBRANCA_SACADO` VARCHAR(30), IN `p_COBRANCA_LOGRADOURO` VARCHAR(40), IN `p_COBRANCA_BAIRRO` VARCHAR(12), IN `p_COBRANCA_CEP` VARCHAR(8), IN `p_COBRANCA_CIDADE` VARCHAR(15), IN `p_COBRANCA_ESTADO` VARCHAR(2), IN `p_COBRANCA_CONTATO` VARCHAR(15), IN `p_COBRANCA_TELEFONE` VARCHAR(50), IN `p_COBRANCA_EMAIL` VARCHAR(120), IN `p_CLIENTE_STATUS` VARCHAR(10), IN `p_REGISTRO_ATRIBUTO` INT, IN `p_REGISTRO_USUARIO` VARCHAR(10))
BEGIN
-- [CONTROLE DE REGISTRO]
-- p_REGISTRO_CATEGORIA 	-> CATEGORIA DE CADASTROS
-- p_REGISTRO_USUARIO		-> USUÁRIO RESPONSÁVEL
-- p_REGISTRO_ATRIBUTO	 	-> 1 = EDITAR; 2 = HISTORICO; 3 = EXCLUIR

DECLARE p_REGISTRO_CATEGORIA VARCHAR(10);
-- DECLARE p_REGISTRO_USUARIO VARCHAR(10);
-- DECLARE p_REGISTRO_ATRIBUTO INT;

-- [CONTROLE DE SERVIÇO]
DECLARE p_SERVICO_STATUS INT;

-- REGISTRO
SET p_REGISTRO_CATEGORIA =	"LIGACAO";

-- SERVIÇO
IF p_CLIENTE_STATUS = "LIBERADO" THEN
	SET p_SERVICO_STATUS = 1;
ELSE 
	SET p_SERVICO_STATUS = 0;
END IF;


IF p_ACAO = "INSERT" THEN

INSERT INTO servicos
			(
			ID_CADASTRO ,
			ID_OBRA ,
			ID_SOLICITANTE ,
			ID_MATERIAL ,

			PEDIDO_MATERIAL ,
			PEDIDO_COLOCA ,
			PEDIDO_TROCA ,
			PEDIDO_RETIRA ,
			PEDIDO_DT_COLOCA ,
			PEDIDO_DT_TROCA ,
			PEDIDO_DT_RETIRA ,
			PEDIDO_PR_COLOCA ,
			PEDIDO_PR_TROCA ,
			PEDIDO_PR_RETIRA ,
			PEDIDO_OBS_COLOCA ,
			PEDIDO_OBS_TROCA ,
			PEDIDO_OBS_RETIRA ,
			PEDIDO_OBS_LIGACAO ,

			OBRA_CEP ,
			OBRA_NUMERO ,
			OBRA_COMPLEMENTO ,
			OBRA_ENDERECO ,
			OBRA_BAIRRO ,
			OBRA_CIDADE ,
			OBRA_ESTADO ,
			OBRA_SOLICITANTE ,
			OBRA_SOLICITANTE_TELEFONE ,
			OBRA_SOLICITANTE_EMAIL ,

			SERVICO_NOME ,
			SERVICO_CONTATO ,
			SERVICO_TELEFONE ,
			SERVICO_EMAIL ,

			SERVICO_VIAGEM ,
			SERVICO_ORDEM ,
			SERVICO_INICIO ,
			SERVICO_TERMINIO ,
			SERVICO_STATUS ,
			
			CONTRATO_FORMA_PAGAMENTO ,
			CONTRATO_FATURAMENTO_DIAS ,
			CONTRATO_PERIODO_LOCACAO ,
			CONTRATO_RETIRADA_AUTOMATICA ,
			CONTRATO_VCTO_APOS_ENTREGA ,
			CONTRATO_VALOR ,
			CONTRATO_MULTA_MORA ,
			CONTRATO_MULTA_DIA ,
			CONTRATO_NFE ,
			CONTRATO_ISS ,
			CONTRATO_CTR ,

			COBRANCA_TIPO ,
			COBRANCA_INSCRICAO ,
			COBRANCA_SACADO ,
			COBRANCA_LOGRADOURO ,
			COBRANCA_BAIRRO ,
			COBRANCA_CEP ,
			COBRANCA_CIDADE ,
			COBRANCA_ESTADO ,
			COBRANCA_CONTATO ,
			COBRANCA_TELEFONE ,
			COBRANCA_EMAIL ,

			REGISTRO_INSERT_EMISSAO ,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO ,
			REGISTRO_UPDATE_USUARIO ,
			REGISTRO_CATEGORIA ,
			REGISTRO_ATRIBUTO 
			)
    VALUES 
			(
			p_ID_CADASTRO ,
			p_ID_OBRA ,
			p_ID_SOLICITANTE ,
			p_ID_MATERIAL ,

			p_PEDIDO_MATERIAL ,
			p_PEDIDO_COLOCA ,
			p_PEDIDO_TROCA ,
			p_PEDIDO_RETIRA ,
			p_PEDIDO_DT_COLOCA ,
			p_PEDIDO_DT_TROCA ,
			p_PEDIDO_DT_RETIRA ,
			p_PEDIDO_PR_COLOCA ,
			p_PEDIDO_PR_TROCA ,
			p_PEDIDO_PR_RETIRA ,
			p_PEDIDO_OBS_COLOCA ,
			p_PEDIDO_OBS_TROCA ,
			p_PEDIDO_OBS_RETIRA ,
			p_PEDIDO_OBS_LIGACAO ,

			p_OBRA_CEP ,
			p_OBRA_NUMERO ,
			p_OBRA_COMPLEMENTO ,
			p_OBRA_ENDERECO ,
			p_OBRA_BAIRRO ,
			p_OBRA_CIDADE ,
			p_OBRA_ESTADO ,
			p_OBRA_SOLICITANTE ,
			p_OBRA_SOLICITANTE_TELEFONE ,
			p_OBRA_SOLICITANTE_EMAIL ,

			p_SERVICO_NOME ,
			p_SERVICO_CONTATO ,
			p_SERVICO_TELEFONE ,
			p_SERVICO_EMAIL ,

			p_SERVICO_VIAGEM ,
			p_SERVICO_ORDEM ,
			p_SERVICO_INICIO ,
			p_SERVICO_TERMINIO ,
			p_SERVICO_STATUS ,

			p_CONTRATO_FORMA_PAGAMENTO ,
			p_CONTRATO_FATURAMENTO_DIAS ,
			p_CONTRATO_PERIODO_LOCACAO ,
			p_CONTRATO_RETIRADA_AUTOMATICA ,
			p_CONTRATO_VCTO_APOS_ENTREGA ,
			p_CONTRATO_VALOR ,
			p_CONTRATO_MULTA_MORA ,
			p_CONTRATO_MULTA_DIA ,
			p_CONTRATO_NFE ,
			p_CONTRATO_ISS ,
			p_CONTRATO_CTR ,

			p_COBRANCA_TIPO ,
			p_COBRANCA_INSCRICAO ,
			p_COBRANCA_SACADO ,
			p_COBRANCA_LOGRADOURO ,
			p_COBRANCA_BAIRRO ,
			p_COBRANCA_CEP ,
			p_COBRANCA_CIDADE ,
			p_COBRANCA_ESTADO ,
			p_COBRANCA_CONTATO ,
			p_COBRANCA_TELEFONE ,
			p_COBRANCA_EMAIL ,
						
			now()		,
			p_REGISTRO_USUARIO,
			now()		,
			p_REGISTRO_USUARIO,
			p_REGISTRO_CATEGORIA ,
			p_REGISTRO_ATRIBUTO 
			
);

ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE servicos
		SET		
			ID_CADASTRO = p_ID_CADASTRO ,
			ID_OBRA	=	p_ID_OBRA ,
			ID_SOLICITANTE	=	p_ID_SOLICITANTE ,
			ID_MATERIAL	=	p_ID_MATERIAL ,

			PEDIDO_MATERIAL	=	p_PEDIDO_MATERIAL ,
			PEDIDO_COLOCA	=	p_PEDIDO_COLOCA ,
			PEDIDO_TROCA	=	p_PEDIDO_TROCA ,
			PEDIDO_RETIRA	=	p_PEDIDO_RETIRA ,
			PEDIDO_DT_COLOCA	=	p_PEDIDO_DT_COLOCA ,
			PEDIDO_DT_TROCA	=	p_PEDIDO_DT_TROCA ,
			PEDIDO_DT_RETIRA	=	p_PEDIDO_DT_RETIRA ,
			PEDIDO_PR_COLOCA	=	p_PEDIDO_PR_COLOCA ,
			PEDIDO_PR_TROCA	=	p_PEDIDO_PR_TROCA ,
			PEDIDO_PR_RETIRA	=	p_PEDIDO_PR_RETIRA ,
			PEDIDO_OBS_COLOCA	=	p_PEDIDO_OBS_COLOCA ,
			PEDIDO_OBS_TROCA	=	p_PEDIDO_OBS_TROCA ,
			PEDIDO_OBS_RETIRA	=	p_PEDIDO_OBS_RETIRA ,
			PEDIDO_OBS_LIGACAO	=	p_PEDIDO_OBS_LIGACAO ,

			OBRA_CEP	=	p_OBRA_CEP ,
			OBRA_NUMERO	=	p_OBRA_NUMERO ,
			OBRA_COMPLEMENTO	=	p_OBRA_COMPLEMENTO ,
			OBRA_ENDERECO	=	p_OBRA_ENDERECO ,
			OBRA_BAIRRO	=	p_OBRA_BAIRRO ,
			OBRA_CIDADE	=	p_OBRA_CIDADE ,
			OBRA_ESTADO	=	p_OBRA_ESTADO ,
			OBRA_SOLICITANTE	=	p_OBRA_SOLICITANTE ,
			OBRA_SOLICITANTE_TELEFONE	=	p_OBRA_SOLICITANTE_TELEFONE ,
			OBRA_SOLICITANTE_EMAIL	=	p_OBRA_SOLICITANTE_EMAIL ,

			SERVICO_NOME	=	p_SERVICO_NOME ,
			SERVICO_CONTATO	=	p_SERVICO_CONTATO ,
			SERVICO_TELEFONE	=	p_SERVICO_TELEFONE ,
			SERVICO_EMAIL	=	p_SERVICO_EMAIL ,

			SERVICO_VIAGEM	=	p_SERVICO_VIAGEM ,
			SERVICO_ORDEM	=	p_SERVICO_ORDEM ,
			SERVICO_INICIO	=	p_SERVICO_INICIO ,
			SERVICO_TERMINIO	=	p_SERVICO_TERMINIO ,
			SERVICO_STATUS	=	p_SERVICO_STATUS ,

			CONTRATO_FORMA_PAGAMENTO	=	p_CONTRATO_FORMA_PAGAMENTO ,
			CONTRATO_FATURAMENTO_DIAS	=	p_CONTRATO_FATURAMENTO_DIAS ,
			CONTRATO_PERIODO_LOCACAO	=	p_CONTRATO_PERIODO_LOCACAO ,
			CONTRATO_RETIRADA_AUTOMATICA	=	p_CONTRATO_RETIRADA_AUTOMATICA ,
			CONTRATO_VCTO_APOS_ENTREGA	=	p_CONTRATO_VCTO_APOS_ENTREGA ,
			CONTRATO_VALOR	=	p_CONTRATO_VALOR ,
			CONTRATO_MULTA_MORA	=	p_CONTRATO_MULTA_MORA ,
			CONTRATO_MULTA_DIA	=	p_CONTRATO_MULTA_DIA ,
			CONTRATO_NFE	=	p_CONTRATO_NFE ,
			CONTRATO_ISS	=	p_CONTRATO_ISS ,
			CONTRATO_CTR	=	p_CONTRATO_CTR ,

			COBRANCA_TIPO	=	p_COBRANCA_TIPO ,
			COBRANCA_INSCRICAO	=	p_COBRANCA_INSCRICAO ,
			COBRANCA_SACADO	=	p_COBRANCA_SACADO ,
			COBRANCA_LOGRADOURO	=	p_COBRANCA_LOGRADOURO ,
			COBRANCA_BAIRRO	=	p_COBRANCA_BAIRRO ,
			COBRANCA_CEP	=	p_COBRANCA_CEP ,
			COBRANCA_CIDADE	=	p_COBRANCA_CIDADE ,
			COBRANCA_ESTADO	=	p_COBRANCA_ESTADO ,
			COBRANCA_CONTATO	=	p_COBRANCA_CONTATO ,
			COBRANCA_TELEFONE	=	p_COBRANCA_TELEFONE ,
			COBRANCA_EMAIL	=	p_COBRANCA_EMAIL ,

			REGISTRO_UPDATE_EMISSAO	=	p_REGISTRO_UPDATE_EMISSAO ,
			REGISTRO_UPDATE_USUARIO	=	p_REGISTRO_USUARIO ,
			REGISTRO_CATEGORIA		=	p_REGISTRO_CATEGORIA ,
			REGISTRO_ATRIBUTO		=	p_REGISTRO_ATRIBUTO 
						
	WHERE
		ID = p_ID_SERVICO;
END IF; 
         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
