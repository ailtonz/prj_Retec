INSERT INTO cadastros
         (
            ID_RELACAO              ,
            CONTATO					, 
            TELEFONE				,
            EMAIL					,
			CADASTRO_TIPO			,			
            CADASTRO_CATEGORIA		,
            SISTEMA_USUARIO			,
            SISTEMA_EMISSAO					
         )
    SELECT ID,CONTATO,TELEFONE,EMAIL,TRUE,'CLIENTE_CONTATO','ADM',curdate() FROM cadastros WHERE CADASTRO_TIPO = 'PJ';