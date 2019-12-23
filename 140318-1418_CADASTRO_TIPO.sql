INSERT INTO cadastros 
	(
		cadastros.CADASTRO_TIPO ,
	
		cadastros.REGISTRO_CATEGORIA ,
		cadastros.REGISTRO_INSERT_EMISSAO ,
		cadastros.REGISTRO_INSERT_USUARIO ,
		cadastros.REGISTRO_UPDATE_EMISSAO ,
		cadastros.REGISTRO_UPDATE_USUARIO  
	)

SELECT 

		cadastros_140318_1258.CADASTRO_TIPO ,
		cadastros_140318_1258.REGISTRO_CATEGORIA ,
		cadastros_140318_1258.REGISTRO_INSERT_EMISSAO ,
		cadastros_140318_1258.REGISTRO_INSERT_USUARIO ,
		cadastros_140318_1258.REGISTRO_UPDATE_EMISSAO ,
		cadastros_140318_1258.REGISTRO_UPDATE_USUARIO  
		
	FROM 
		cadastros_140318_1258 
	WHERE 
		cadastros_140318_1258.REGISTRO_CATEGORIA = 'UTEIS_TIPO_CADASTRO';