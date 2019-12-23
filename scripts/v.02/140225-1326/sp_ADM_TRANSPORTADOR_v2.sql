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

-- Dumping structure for procedure dbretec.sp_ADM_TRANSPORTADOR
DROP PROCEDURE IF EXISTS `sp_ADM_TRANSPORTADOR`;
DELIMITER //
CREATE DEFINER=`root`@`127.0.0.1` PROCEDURE `sp_ADM_TRANSPORTADOR`(IN `p_ACAO` VARCHAR(10), IN `p_ID_TRANSPORTADOR` INT, IN `p_NOME` VARCHAR(60) , IN `p_CPF_CCM` VARCHAR(14), IN `p_LIMPURB` VARCHAR(12), IN `p_ENDERECO` VARCHAR(40), IN `p_BAIRRO` VARCHAR(35), IN `p_MUNICIPIO` VARCHAR(35), IN `p_TELEFONE` VARCHAR(50), IN `p_CONTRATO_FORMA_PAGAMENTO` VARCHAR(50), IN `p_CONTRATO_FATURAMENTO_DIAS` VARCHAR(50), IN `p_CONTRATO_PERIODO_LOCACAO` INT, IN `p_CONTRATO_RETIRADA_AUTOMATICA` INT, IN `p_CONTRATO_VCTO_APOS_ENTREGA` INT, IN `p_CONTRATO_MULTA_MORA` INT, IN `p_CONTRATO_MULTA_DIA` INT, IN `p_FATURAMENTO_COLOCA` INT, IN `p_FATURAMENTO_TROCA` INT, IN `p_FATURAMENTO_RETIRA` INT, IN `p_PRECO_TIPO` TINYINT, IN `p_PRECO_VALOR` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'ADM_TRANSPORTADOR';

IF p_ACAO = "INSERT" THEN

 INSERT INTO vw_adm_transportador
         (				         
				NOME							,

				ENDERECO						,
				BAIRRO						,
				MUNICIPIO					,

				CPF_CCM						,
				LIMPURB						,

				TELEFONE						,
				
				CONTRATO_FORMA_PAGAMENTO		,
				CONTRATO_FATURAMENTO_DIAS		,
				CONTRATO_PERIODO_LOCACAO		,
				CONTRATO_RETIRADA_AUTOMATICA	,
				CONTRATO_VCTO_APOS_ENTREGA		,
				CONTRATO_MULTA_MORA				,
				CONTRATO_MULTA_DIA				,
				
				FATURAMENTO_COLOCA		,
				FATURAMENTO_TROCA			,
				FATURAMENTO_RETIRA		,
				
				PRECO_TIPO					,
				PRECO_VALOR					,
	
				CADASTRO_CATEGORIA      ,
	         
				CAD_EMISSAO,
	         CAD_USUARIO,
	         
				ALT_EMISSAO,
	         ALT_USUARIO
         )
    VALUES 
         (
			trim(ucase(p_NOME))           , 
			trim(ucase(p_ENDERECO))		   , 
			trim(ucase(p_BAIRRO))  		   , 
			trim(ucase(p_MUNICIPIO))	   ,
			p_CPF_CCM                     , 
			trim(ucase(p_LIMPURB))		   ,
			p_TELEFONE                    ,
			
			p_CONTRATO_FORMA_PAGAMENTO		,
			p_CONTRATO_FATURAMENTO_DIAS 	,
			p_CONTRATO_PERIODO_LOCACAO	  	,
			p_CONTRATO_RETIRADA_AUTOMATICA,
			p_CONTRATO_VCTO_APOS_ENTREGA  ,
			p_CONTRATO_MULTA_MORA		   ,
			p_CONTRATO_MULTA_DIA		      ,
		
			p_FATURAMENTO_COLOCA		  ,
			p_FATURAMENTO_TROCA		  ,
			p_FATURAMENTO_RETIRA		  ,
			p_PRECO_TIPO				  ,
			REPLACE(p_PRECO_VALOR,',','.'),

			p_CATEGORIA       	 ,
			now()						 , 				
			trim(ucase(p_USUARIO)),
			now()						 , 				
			trim(ucase(p_USUARIO)) 			
         );
         
ELSEIF p_ACAO = "UPDATE" THEN

	UPDATE vw_adm_transportador
		SET
			NOME 				= trim(ucase(p_NOME)) ,

			ENDERECO 		= trim(ucase(p_ENDERECO)) ,
			BAIRRO 			= trim(ucase(p_BAIRRO)) ,
			MUNICIPIO		= trim(ucase(p_MUNICIPIO)) ,

			CPF_CCM 			= p_CPF_CCM ,
			LIMPURB 			= trim(ucase(p_LIMPURB)) ,

			TELEFONE 		= p_TELEFONE ,

			CONTRATO_FORMA_PAGAMENTO	=	p_CONTRATO_FORMA_PAGAMENTO		,
			CONTRATO_FATURAMENTO_DIAS	=	p_CONTRATO_FATURAMENTO_DIAS 	,

			CONTRATO_PERIODO_LOCACAO 		= p_CONTRATO_PERIODO_LOCACAO ,
			CONTRATO_RETIRADA_AUTOMATICA 	= p_CONTRATO_RETIRADA_AUTOMATICA ,
			CONTRATO_VCTO_APOS_ENTREGA 	= p_CONTRATO_VCTO_APOS_ENTREGA ,
			CONTRATO_MULTA_MORA 				= p_CONTRATO_MULTA_MORA ,
			CONTRATO_MULTA_DIA 				= p_CONTRATO_MULTA_DIA ,

			FATURAMENTO_COLOCA 			= p_FATURAMENTO_COLOCA ,
			FATURAMENTO_TROCA 			= p_FATURAMENTO_TROCA ,
			FATURAMENTO_RETIRA 			= p_FATURAMENTO_RETIRA ,

			PRECO_TIPO 						= p_PRECO_TIPO ,
			PRECO_VALOR 					= REPLACE(p_PRECO_VALOR,',','.') ,

			ALT_USUARIO   =	trim(ucase(p_USUARIO)),            
			ALT_EMISSAO	= 	now()	

	WHERE
		ID = p_ID_TRANSPORTADOR;	
		
ELSEIF p_ACAO = "DELETE_ALL" THEN

	DELETE FROM vw_adm_transportador WHERE ID = p_ID_TRANSPORTADOR;
	
END IF;  

END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
