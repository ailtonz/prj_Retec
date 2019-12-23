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

-- Dumping structure for procedure dbretec.sp_CAD_CLIENTE_OBRA
DROP PROCEDURE IF EXISTS `sp_CAD_CLIENTE_OBRA`;
DELIMITER //

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_CAD_CLIENTE_OBRA`(IN `p_ACAO` VARCHAR(10), IN `p_ID_CLIENTE` INT, IN `p_ID_OBRA` INT, IN `p_CEP` VARCHAR(8), IN `p_NUMERO` VARCHAR(10), IN `p_COMPLEMENTO` VARCHAR(100), IN `p_CONTATO` VARCHAR(50), IN `p_TELEFONE` VARCHAR(50), IN `p_EMAIL` VARCHAR(120), IN `p_COBRANCA_TIPO` VARCHAR(2), IN `p_COBRANCA_INSCRICAO` VARCHAR(14), IN `p_COBRANCA_SACADO` VARCHAR(30), IN `p_COBRANCA_CEP` VARCHAR(8), IN `p_COBRANCA_CONTATO` VARCHAR(15), IN `p_COBRANCA_TELEFONE` VARCHAR(50), IN `p_COBRANCA_EMAIL` VARCHAR(120), IN `p_CONTRATO_INICIO` VARCHAR(10), IN `p_CONTRATO_VALOR` VARCHAR(50), IN `p_CONTRATO_NF` TINYINT, IN `p_CONTRATO_ISS` TINYINT, IN `p_CONTRATO_CTR` TINYINT, IN `p_USUARIO` VARCHAR(10), IN `p_CONTRATO_FORMA_PAGAMENTO` VARCHAR(50), IN `P_CONTRATO_FATURAMENTO_DIAS` VARCHAR(50), IN `p_CONTRATO_PERIODO_LOCACAO` VARCHAR(50), IN `p_CONTRATO_RETIRADA_AUTOMATICA` VARCHAR(50), IN `p_CONTRATO_VCTO_APOS_ENTREGA` VARCHAR(50), IN `p_CONTRATO_MULTA_MORA` VARCHAR(50), IN `p_CONTRATO_MULTA_DIA` VARCHAR(50), IN `p_COBRANCA_LOGRADOURO` VARCHAR(40), IN `p_COBRANCA_BAIRRO` VARCHAR(12), IN `p_COBRANCA_CIDADE` VARCHAR(15), IN `p_COBRANCA_ESTADO` VARCHAR(2), IN `p_CADASTRO_OBSERVACAO` VARCHAR(1000), IN `p_CONTRATO_OBS_LIGACAO` VARCHAR(200), IN `p_CONTRATO_OBS_COLOCA` VARCHAR(200), IN `p_CONTRATO_OBS_TROCA` VARCHAR(200), IN `p_CONTRATO_OBS_RETIRA` VARCHAR(200), IN `p_ENDERECO` VARCHAR(200), IN `p_BAIRRO` VARCHAR(50), IN `p_CIDADE` VARCHAR(100), IN `p_ESTADO` VARCHAR(2))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = "CLIENTE_OBRA";

IF p_CONTRATO_FORMA_PAGAMENTO ="" THEN
	SET p_CONTRATO_FORMA_PAGAMENTO 		= (select CONTRATO_FORMA_PAGAMENTO 		from vw_adm_transportador LIMIT 1);
END IF;

IF P_CONTRATO_FATURAMENTO_DIAS ="" THEN
	SET P_CONTRATO_FATURAMENTO_DIAS 		= (select CONTRATO_FATURAMENTO_DIAS 	from vw_adm_transportador LIMIT 1);
END IF;

IF p_CONTRATO_FORMA_PAGAMENTO ="" THEN
	SET p_CONTRATO_VALOR 					= (select PRECO_VALOR 						from vw_adm_transportador LIMIT 1);
END IF;

IF p_CONTRATO_PERIODO_LOCACAO ="" THEN
	SET p_CONTRATO_PERIODO_LOCACAO 		= (select CONTRATO_PERIODO_LOCACAO 		from vw_adm_transportador LIMIT 1);
END IF;

IF p_CONTRATO_RETIRADA_AUTOMATICA ="" THEN
	SET p_CONTRATO_RETIRADA_AUTOMATICA 	= (select CONTRATO_RETIRADA_AUTOMATICA from vw_adm_transportador LIMIT 1);
END IF;

IF p_CONTRATO_VCTO_APOS_ENTREGA ="" THEN
	SET p_CONTRATO_VCTO_APOS_ENTREGA 	= (select CONTRATO_VCTO_APOS_ENTREGA 	from vw_adm_transportador LIMIT 1);
END IF;

IF p_CONTRATO_MULTA_MORA ="" THEN
	SET p_CONTRATO_MULTA_MORA 				= (select CONTRATO_MULTA_MORA 			from vw_adm_transportador LIMIT 1);
END IF;

IF p_CONTRATO_MULTA_DIA ="" THEN
	SET p_CONTRATO_MULTA_DIA 				= (select CONTRATO_MULTA_DIA 				from vw_adm_transportador LIMIT 1);
END IF;


IF p_ACAO = "INSERT" THEN

INSERT INTO cadastros
         (
			ID_RELACAO				,

			CEP                 	,
			NUMERO					,
			COMPLEMENTO				,
			
			ENDERECO,
			BAIRRO,
			CIDADE,
			ESTADO,
	

			CONTATO					,
			TELEFONE					,
			EMAIL						,
			
			COBRANCA_TIPO		   ,	
			COBRANCA_INSCRICAO	,
			COBRANCA_SACADO	   ,	

			COBRANCA_CEP			,
			COBRANCA_LOGRADOURO	,
			COBRANCA_BAIRRO		,
			COBRANCA_CIDADE		,
			COBRANCA_ESTADO		,

			COBRANCA_CONTATO		,
			COBRANCA_TELEFONE		,
			COBRANCA_EMAIL			,

			CONTRATO_FORMA_PAGAMENTO		,
			CONTRATO_FATURAMENTO_DIAS		,
			CONTRATO_VALOR						,
			
			CONTRATO_PERIODO_LOCACAO		,
			CONTRATO_RETIRADA_AUTOMATICA	,
			CONTRATO_VCTO_APOS_ENTREGA		,
			CONTRATO_MULTA_MORA				,
			CONTRATO_MULTA_DIA				,

			CONTRATO_INICIO		,
			CONTRATO_NF				,
			CONTRATO_ISS			,
			CONTRATO_CTR			,
			CADASTRO_OBSERVACAO,
			CONTRATO_OBS_LIGACAO,
			CONTRATO_OBS_COLOCA,
			CONTRATO_OBS_TROCA,
			CONTRATO_OBS_RETIRA,
			
			CADASTRO_CATEGORIA	,

		 	CAD_EMISSAO				,
			CAD_USUARIO      		,

		 	ALT_EMISSAO				,
			ALT_USUARIO      		

         )
    VALUES 
         (
			p_ID_CLIENTE			,

			p_CEP                ,
			p_NUMERO					,
			ucase(p_COMPLEMENTO)	,
			
			ucase(p_ENDERECO),
			ucase(p_BAIRRO),
			ucase(p_CIDADE),
			ucase(p_ESTADO),
			

			ucase(p_CONTATO)		,
			p_TELEFONE				,
			lcase(p_EMAIL)			,			
			
			ucase(p_COBRANCA_TIPO)				,	
			CONCAT(LEFT(REPEAT(0,14),(14 - LENGTH(p_COBRANCA_INSCRICAO))),p_COBRANCA_INSCRICAO),
			ucase(p_COBRANCA_SACADO)			,	

			p_COBRANCA_CEP						,
			ucase(p_COBRANCA_LOGRADOURO)	,
			ucase(p_COBRANCA_BAIRRO)		,
			ucase(p_COBRANCA_CIDADE)		,
			ucase(p_COBRANCA_ESTADO)		,

			ucase(p_COBRANCA_CONTATO)		,
			p_COBRANCA_TELEFONE				,
			lcase(p_COBRANCA_EMAIL)			,


			ucase(p_CONTRATO_FORMA_PAGAMENTO)	,
			P_CONTRATO_FATURAMENTO_DIAS		 	,
			REPLACE(p_CONTRATO_VALOR,',','.')	,

			p_CONTRATO_PERIODO_LOCACAO				,
			p_CONTRATO_RETIRADA_AUTOMATICA		,
			p_CONTRATO_VCTO_APOS_ENTREGA			,

			REPLACE(p_CONTRATO_MULTA_MORA,',','.'),
			REPLACE(p_CONTRATO_MULTA_DIA,',','.'),			

			p_CONTRATO_INICIO		,

			p_CONTRATO_NF					,
			p_CONTRATO_ISS					,
			p_CONTRATO_CTR					,
			
			ucase(p_CADASTRO_OBSERVACAO),
			ucase(p_CONTRATO_OBS_LIGACAO),
			ucase(p_CONTRATO_OBS_COLOCA),
			ucase(p_CONTRATO_OBS_TROCA),
			ucase(p_CONTRATO_OBS_RETIRA),

			p_CATEGORIA			         ,

			now()								,
			ucase(p_USUARIO)  , 
			now()								,
			ucase(p_USUARIO) 

         );

ELSEIF p_ACAO = "UPDATE" THEN

	UPDATE cadastros
		SET

		CEP							= 	p_CEP,
		NUMERO						= 	p_NUMERO,
		COMPLEMENTO					= 	ucase(p_COMPLEMENTO),
		ENDERECO						=	ucase(p_ENDERECO),
		BAIRRO						=	ucase(p_BAIRRO),
		CIDADE						=	ucase(p_CIDADE),
		ESTADO						=	ucase(p_ESTADO),	
		
		CONTATO						=		ucase(p_CONTATO),
		TELEFONE						=		p_TELEFONE	,
		EMAIL							=		lcase(p_EMAIL),			

		COBRANCA_SACADO			= 		p_COBRANCA_SACADO,
		COBRANCA_INSCRICAO		= 		CONCAT(LEFT(REPEAT(0,14),(14 - LENGTH(p_COBRANCA_INSCRICAO))),p_COBRANCA_INSCRICAO),

		COBRANCA_CEP				= 		p_COBRANCA_CEP,
		COBRANCA_LOGRADOURO		= 		p_COBRANCA_LOGRADOURO,
		COBRANCA_BAIRRO			= 		p_COBRANCA_BAIRRO,
		COBRANCA_CIDADE			= 		p_COBRANCA_CIDADE,
		COBRANCA_ESTADO			= 		p_COBRANCA_ESTADO,

		COBRANCA_CONTATO			= 		p_COBRANCA_CONTATO,
		COBRANCA_TELEFONE			= 		p_COBRANCA_TELEFONE,
		COBRANCA_EMAIL				= 		p_COBRANCA_EMAIL,

		CONTRATO_INICIO			= 		p_CONTRATO_INICIO,
		CONTRATO_VALOR				= 		REPLACE(p_CONTRATO_VALOR,',','.')	,
		CONTRATO_NF					= 		p_CONTRATO_NF,
		CONTRATO_ISS				= 		p_CONTRATO_ISS,
		CONTRATO_CTR				= 		p_CONTRATO_CTR,

		CONTRATO_PERIODO_LOCACAO		= 		p_CONTRATO_PERIODO_LOCACAO,
		CONTRATO_FORMA_PAGAMENTO		= 		p_CONTRATO_FORMA_PAGAMENTO,
		CONTRATO_FATURAMENTO_DIAS		=		p_CONTRATO_FATURAMENTO_DIAS,
		CONTRATO_RETIRADA_AUTOMATICA	= 		p_CONTRATO_RETIRADA_AUTOMATICA,
		CONTRATO_VCTO_APOS_ENTREGA		= 		p_CONTRATO_VCTO_APOS_ENTREGA,
		CONTRATO_MULTA_MORA				= 		REPLACE(p_CONTRATO_MULTA_MORA,',','.'),
		CONTRATO_MULTA_DIA				= 		REPLACE(p_CONTRATO_MULTA_DIA,',','.'),
		
		CADASTRO_OBSERVACAO				=	ucase(p_CADASTRO_OBSERVACAO),
		CONTRATO_OBS_LIGACAO				= 	ucase(p_CONTRATO_OBS_LIGACAO),
		CONTRATO_OBS_COLOCA 				= 	ucase(p_CONTRATO_OBS_COLOCA),
		CONTRATO_OBS_TROCA 				= 	ucase(p_CONTRATO_OBS_TROCA),
		CONTRATO_OBS_RETIRA 				= 	ucase(p_CONTRATO_OBS_RETIRA),		
		
		ALT_USUARIO   	=	trim(ucase(p_USUARIO)),            
		ALT_EMISSAO		= 	now()			
	WHERE
		ID = p_ID_OBRA;

ELSEIF p_ACAO = "DELETE_ALL" THEN

	DELETE FROM	vw_dgv_clientes_contatos_obras WHERE ID_OBRA IN (p_ID_OBRA);
	DELETE FROM	vw_dgv_clientes_obras WHERE ID = p_ID_OBRA;

END IF;



         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;