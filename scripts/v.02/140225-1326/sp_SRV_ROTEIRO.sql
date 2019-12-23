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

-- Dumping structure for procedure dbretec.sp_SRV_ROTEIRO
DROP PROCEDURE IF EXISTS `sp_SRV_ROTEIRO`;
DELIMITER //
CREATE DEFINER=`userRETEC`@`%` PROCEDURE `sp_SRV_ROTEIRO`(IN `p_ID_MOTORISTA` INT, IN `p_ID_VEICULO` INT, IN `p_EMISSAO` DATE, IN `p_INICIO` TIME, IN `p_TERMINIO` TIME, IN `p_USUARIO` VARCHAR(10), IN `p_ACAO` VARCHAR(10))
BEGIN

DECLARE p_MOTORISTA 	VARCHAR(100);
DECLARE p_VEICULO 	VARCHAR(100);

SET p_MOTORISTA 	= (SELECT NOME FROM vw_motoristas WHERE ID = p_ID_MOTORISTA);
SET p_VEICULO 		= (SELECT PLACA FROM vw_veiculos WHERE ID = p_ID_VEICULO);

IF p_ACAO = "INSERT" THEN

INSERT INTO servicos
			(
			ID_CADASTRO			,
			SERVICO_EMISSAO		,
			SERVICO_INICIO			,
			SERVICO_TERMINIO		,			
			SERVICO_DESCRICAO		,
			SERVICO_SOLICITANTE	,
			SISTEMA_USUARIO		,            
			SERVICO_CATEGORIA		,
			SERVICO_STATUS			,	 
			SISTEMA_EMISSAO
			)
    VALUES 
			(
			p_ID_MOTORISTA						,
			p_EMISSAO							,
			p_INICIO								,
			p_TERMINIO							,
			trim(ucase(p_MOTORISTA))		,
			trim(ucase(p_VEICULO))			,
			trim(ucase(p_USUARIO))			,
			"ROTEIRO"							,
			FALSE									,				
			curdate()
);

ELSEIF p_ACAO = "UPDATE" THEN
	UPDATE vw_srv_roteiros
		SET
			ID_CADASTRO 	= p_ID_CADASTRO,	
			DATA_ROTEIRO 	= p_DATA_ROTEIRO,
			INICIO 			= p_INICIO,
			TERMINIO 		= p_TERMINIO,
			MOTORISTA 		= p_MOTORISTA,
			VEICULO 			= p_VEICULO,
			CAD_USUARIO 	= p_USUARIO,
			CAD_EMISSAO 	= curdate()			
	WHERE
		ID = p_ID_ROTEIRO;
ELSEIF p_ACAO = "DELETE" THEN
	DELETE FROM vw_srv_roteiros
	WHERE ID = p_ID_ROTEIRO;
END IF; 
         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
