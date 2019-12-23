BEGIN
 INSERT INTO cadastros
         (
            Nome                   , 
            Telefone               ,
            Cadastro_Categoria     ,
            SISTEMA_USUARIO        ,            
            SISTEMA_EMISSAO
         )
    VALUES 
         (
             trim(ucase(p_DESCRICAO))   , 
             p_CONDICAO            , 
             "ADM_FATURAMENTO_CONDICAO",
             ucase(p_USUARIO)      ,
             curdate()
         );
END

BEGIN
	UPDATE vw_adm_faturamento_condicao
		SET
			DESCRICAO 	= p_DESCRICAO,
			CONDICAO  	= p_CONDICAO,
			CAD_USUARIO = p_USUARIO,
			CAD_EMISSAO = curdate()			
	WHERE
		ID = p_ID_CONDICAO;
END

BEGIN
	DELETE FROM vw_adm_faturamento_condicao
	WHERE ID = p_ID_CONDICAO;
END

