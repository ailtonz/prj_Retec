CREATE DEFINER=`root`@`localhost` 
	PROCEDURE `sp_CADASTRO_CLIENTE_INSERT_OBSERVACAO`
	(
		IN `p_ID_RELACAO` int    		     ,
		IN `p_CLIENTE_OBSERVACAO` VARCHAR(255)   ,
		IN `p_USUARIO` VARCHAR(10)

)
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
 INSERT INTO cadastros
         (
            ID_RELACAO                      ,
            CADASTRO_OBSERVACAO             ,
            CADASTRO_CATEGORIA              ,
            SISTEMA_USUARIO                 ,            
            SISTEMA_EMISSAO
         )
    VALUES 
         (
            p_ID_RELACAO                     , 
            ucase(p_CLIENTE_OBSERVACAO)      , 
            "OBSERVACAO"                     ,
            ucase(p_USUARIO)                 ,
            curdate()
         );
END