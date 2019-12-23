INSERT INTO 
	vw_uteis_cep(ENDERECO, COMPLEMENTO,BAIRRO,CEP,CIDADE,ESTADO,CADASTRO_CATEGORIA)
(select endereco_logradouro,endereco_complemento,bairro_descricao,endereco_cep,cidade_descricao,uf_sigla,CADASTRO_CATEGORIA from tmp_cep);