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

-- Dumping structure for procedure dbretec.sp_MOV_FLUXO
DROP PROCEDURE IF EXISTS `sp_MOV_FLUXO`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_MOV_FLUXO`(IN `p_ACAO` VARCHAR(10), IN `p_ID_MOVIMENTO` INT, IN `p_MOVIMENTO` VARCHAR(50), IN `p_DataDeEmissao` VARCHAR(50), IN `p_CONTA` VARCHAR(50), IN `p_DataDeVencimento` VARCHAR(50), IN `p_ValorOriginal` VARCHAR(50), IN `p_DataDePagamento` VARCHAR(50), IN `p_ValorFinal` VARCHAR(50), IN `p_FormaDePagamento` VARCHAR(50), IN `p_Documento` VARCHAR(50), IN `p_Observacao` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
BEGIN
DECLARE p_ID_PLANO 	INT;
DECLARE p_CATEGORIA 	VARCHAR(50);
DECLARE p_PLANO 		VARCHAR(50);
DECLARE p_CONTROLE 	VARCHAR(50);
DECLARE p_GRUPO 		VARCHAR(50);

SET p_CATEGORIA = "MOVIMENTO";
SET p_PLANO = "PROFISSIONAL";

SET p_ID_PLANO 	= (SELECT idMOVIMENTO FROM vw_mov_fluxo WHERE idMOVIMENTO = p_ID_MOVIMENTO LIMIT 1);
SET p_CONTROLE 	= (SELECT frequencia FROM vw_mov_plano_contas where conta=p_CONTA and plano=p_PLANO and movimento=p_MOVIMENTO);
SET p_GRUPO 	   = (SELECT grupo FROM vw_mov_plano_contas where conta=p_CONTA and plano=p_PLANO and movimento=p_MOVIMENTO);


IF p_CONTROLE IS NULL THEN
	SET p_CONTROLE = "VARIAVEL";
END IF;

IF p_GRUPO IS NULL THEN
	SET p_GRUPO = "CLIENTES";
END IF;


IF p_ACAO = "INSERT" THEN
 INSERT INTO vw_mov_fluxo
         (
				MOVIMENTO   		,
				DataDeEmissao		,
				CONTA					,
				DataDeVencimento	,
				ValorOriginal		,
				DataDePagamento	,
				ValorFinal			,
				FormaDePagamento	,
				DOCUMENTO			,
				OBSERVACAO			,
				PLANO       		,
				GRUPO					,
				CONTROLE				,
				CADASTRO_CATEGORIA,
				CADASTRO_USUARIO	,
				CADASTRO_EMISSAO
         )
    VALUES 
         (
         
				trim(ucase(p_MOVIMENTO))   	,
				p_DataDeEmissao					,
				trim(ucase(p_CONTA))				,
				p_DataDeVencimento				,
				REPLACE(p_ValorOriginal,',','.'),
				p_DataDePagamento					,
				REPLACE(p_ValorFinal,',','.')	,
				trim(ucase(p_FormaDePagamento)),
				trim(ucase(p_DOCUMENTO))		,
				trim(ucase(p_OBSERVACAO))		,
				trim(ucase(p_PLANO))       	,
				trim(ucase(p_GRUPO))				,
				trim(ucase(p_CONTROLE))			,
             p_CATEGORIA   		  			,
             ucase(p_USUARIO)      			,
             curdate()
         );
ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE vw_mov_fluxo
		SET 
         MOVIMENTO   		= trim(ucase(p_MOVIMENTO))	,
			DataDeEmissao		= p_DataDeEmissao			,
			CONTA					= trim(ucase(p_CONTA))		,
			DataDeVencimento	= p_DataDeVencimento	,
			ValorOriginal		= REPLACE(p_ValorOriginal,',','.')		,
			DataDePagamento	= p_DataDePagamento	,
			ValorFinal			= REPLACE(p_ValorFinal,',','.')			,
			FormaDePagamento 	= trim(ucase(p_FormaDePagamento)),
			DOCUMENTO			= trim(ucase(p_DOCUMENTO))	,
			OBSERVACAO			= trim(ucase(p_MOVIMENTO))	,
         PLANO       		= trim(ucase(p_PLANO))		, 
			GRUPO					= trim(ucase(p_GRUPO))		,
			CONTROLE				= trim(ucase(p_CONTROLE))	,
         CADASTRO_USUARIO  = ucase(p_USUARIO)			,
         CADASTRO_EMISSAO	= curdate()	
         
	WHERE idMOVIMENTO = p_ID_PLANO;
	
ELSEIF p_ACAO = "DELETE_ALL" THEN
	DELETE FROM vw_mov_fluxo WHERE idMOVIMENTO = p_ID_MOVIMENTO;
END IF;  

END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
