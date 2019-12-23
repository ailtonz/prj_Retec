Select * FROM vw_cad_clientes WHERE nome like '%sgtm%';
Select * from vw_cad_clientes_obras where ID_CLIENTE = (select ID_CLIENTE from vw_cad_clientes where nome like '%sgtm%');
Select * from vw_cad_clientes_contatos where ID_CLIENTE = (select ID_CLIENTE from vw_cad_clientes where nome like '%sgtm%');
Select * from vw_cad_clientes_cobranca where ID_CLIENTE = (select ID_CLIENTE from vw_cad_clientes where nome like '%sgtm%');
Select * from vw_cad_clientes_historico where ID_CLIENTE = (select ID_CLIENTE from vw_cad_clientes where nome like '%sgtm%');
Select * from vw_servicos_ligacoes where ID_CLIENTE = (select ID_CLIENTE from vw_cad_clientes where nome like '%sgtm%');