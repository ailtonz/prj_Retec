-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               5.5.25a - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL version:             7.0.0.4053
-- Date/time:                    2013-01-25 11:48:16
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;

-- Dumping structure for procedure dbcacambas.sp_CADASTRO_TRANSPORTADOR_INSERT
DELIMITER //
CREATE DEFINER=`userRETEC`@`dbRETEC` PROCEDURE `sp_CADASTRO_TRANSPORTADOR_INSERT`(IN `p_NOME` VARCHAR(60)    , IN `p_CNPJ_CPF` VARCHAR(14)    , IN `p_LIMPURB` VARCHAR(12)    , IN `p_PRINCIPAL_TELEFONE` VARCHAR(50)    , IN `p_COMERCIAL_ENDERECO` VARCHAR(40)    , IN `p_COMERCIAL_NUMERO` VARCHAR(10)    , IN `p_COMERCIAL_COMPLEMENTO` VARCHAR(20)    , IN `p_COMERCIAL_BAIRRO` VARCHAR(35)    , IN `p_COMERCIAL_CEP` VARCHAR(9)     , IN `p_COMERCIAL_MUNICIPIO` VARCHAR(35)    , IN `p_COMERCIAL_ESTADO` VARCHAR(2)     , IN `p_USUARIO` VARCHAR(10)
    
)
BEGIN
 INSERT INTO cadastros
         (
            Nome                            , 
            CadastroTipo			           , 
            CNPJ_CPF                        , 
            IE_RG                           , 
            PrincipalTelefone               ,
            Endereco                        ,
            Numero                          ,
            Complemento                     ,
            Bairro                          ,
            Cep                             ,
            Municipio                       ,
            Estado                          ,
            CadastroCategoria               ,
            CadastroUsuario                 ,            
            CadastroEmissao
         )
    VALUES 
         (
         
                ucase(p_NOME)                   , 
                "PJ"                 				,
                p_CNPJ_CPF                      , 
                ucase(p_LIMPURB)                , 
                p_PRINCIPAL_TELEFONE            , 
                ucase(p_COMERCIAL_ENDERECO)     , 
                p_COMERCIAL_NUMERO              , 
                ucase(p_COMERCIAL_COMPLEMENTO)  , 
                ucase(p_COMERCIAL_BAIRRO)       , 
                p_COMERCIAL_CEP                 , 
                ucase(p_COMERCIAL_MUNICIPIO)    ,
                ucase(p_COMERCIAL_ESTADO)       ,
                "TRANSPORTADOR"                 ,
                ucase(p_USUARIO)                ,
                curdate()
         );
END//
DELIMITER ;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
