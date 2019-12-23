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

-- Dumping structure for procedure dbretec.ADM_getCategorias
DROP PROCEDURE IF EXISTS `ADM_getCategorias`;
DELIMITER //

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADM_getCategorias`(IN `p_CATEGORIA` VARCHAR(50))
    COMMENT 'Categorias do sistema'
BEGIN
IF p_CATEGORIA = "CADASTROS" THEN
	SELECT DISTINCT 
		cadastros.CADASTRO_CATEGORIA AS CADASTRO_CATEGORIA
	
	FROM 
		cadastros
	ORDER BY 
		cadastros.CADASTRO_CATEGORIA;
		
ELSEIF p_CATEGORIA = "MOVIMENTOS" THEN

	SELECT DISTINCT 
		movimentos.CADASTRO_CATEGORIA AS CADASTRO_CATEGORIA
	
	FROM 
		movimentos
	ORDER BY 
		movimentos.CADASTRO_CATEGORIA;	
		
ELSEIF p_CATEGORIA = "SERVICOS" THEN

	SELECT DISTINCT 
		servicos.SERVICO_CATEGORIA AS SERVICO_CATEGORIA
	
	FROM 
		servicos
	ORDER BY 
		servicos.SERVICO_CATEGORIA;				
		
END IF; 




         
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
