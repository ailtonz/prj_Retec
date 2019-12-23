SELECT * FROM vw_cad_clientes where id_cliente in (Select id_cliente from vw_cad_clientes where cnpj_cpf = '24797483830');
SELECT * FROM vw_cad_clientes_obras where id_cliente in (Select id_cliente from vw_cad_clientes where cnpj_cpf = '24797483830');
SELECT * FROM vw_cad_clientes_obras_contatos where id_obra in (Select id from vw_cad_clientes_obras where id_cliente in (Select id_cliente from vw_cad_clientes where cnpj_cpf = '24797483830'));
SELECT * FROM vw_cad_clientes_contatos where id_cliente in (Select id_cliente from vw_cad_clientes where cnpj_cpf = '24797483830');
SELECT * FROM vw_cad_clientes_historicos where id_cliente in (Select id_cliente from vw_cad_clientes where cnpj_cpf = '24797483830');