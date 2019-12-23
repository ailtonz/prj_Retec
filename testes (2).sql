select * from vw_cad_clientes where ID_CLIENTE in(select ID_CLIENTE from vw_cad_clientes where NOME like 'ailton zacarias%');
select * from vw_cad_clientes_contatos where ID_CLIENTE in(select ID_CLIENTE from vw_cad_clientes where NOME like 'ailton zacarias%');
select * from vw_cad_clientes_obras where ID_CLIENTE in(select ID_CLIENTE from vw_cad_clientes where NOME like 'ailton zacarias%');