CALL `ADM_setAdministracao`('0', 'TRANSPORTADOR', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'TRANSPORTADOR', 'procedure', 'spCadastroTransportador', '', '');
CALL `ADM_setAdministracao`('0', 'TRANSPORTADOR', 'view', 'vw_transportadores', '', '');
CALL `ADM_setAdministracao`('0', 'TRANSPORTADOR', 'filter', 'Nome', 'Transportador', '1');

CALL `ADM_setAdministracao`('0', 'CLIENTE', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'CLIENTE', 'procedure', 'spCadastroCliente', '', '');
CALL `ADM_setAdministracao`('0', 'CLIENTE', 'view', 'vw_clientes', '', '');
CALL `ADM_setAdministracao`('0', 'CLIENTE', 'filter', 'CLIENTE', 'CLIENTE', '1');
CALL `ADM_setAdministracao`('0', 'CLIENTE', 'filter', 'CNPJ_CPF', 'CNPJ / CPF', '2');
CALL `ADM_setAdministracao`('0', 'CLIENTE', 'filter', 'TELEFONE', 'TELEFONE', '3');

CALL `ADM_setAdministracao`('0', 'CONTATOS', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'CONTATOS', 'procedure', 'spCadastroContato', '', '');
CALL `ADM_setAdministracao`('0', 'CONTATOS', 'view', 'vw_contatos', '', '');
CALL `ADM_setAdministracao`('0', 'CONTATOS', 'filter', 'CONTATO', 'CONTATO', '1');
CALL `ADM_setAdministracao`('0', 'CONTATOS', 'filter', 'TELEFONE', 'TELEFONE', '2');
CALL `ADM_setAdministracao`('0', 'CONTATOS', 'filter', 'EMAIL', 'E-MAIL', '3');

CALL `ADM_setAdministracao`('0', 'HISTORICO', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'HISTORICO', 'procedure', 'spCadastroHistorico', '', '');
CALL `ADM_setAdministracao`('0', 'HISTORICO', 'view', 'vw_clientes_historicos', '', '');
CALL `ADM_setAdministracao`('0', 'HISTORICO', 'filter', 'HISTORICO', 'HISTORICO', '1');

CALL `ADM_setAdministracao`('0', 'OBRA', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'OBRA', 'procedure', 'spCadastroObra', '', '');
CALL `ADM_setAdministracao`('0', 'OBRA', 'view', 'vw_clientes_obras', '', '');
CALL `ADM_setAdministracao`('0', 'OBRA', 'filter', 'OBRA', 'OBRA', '1');

CALL `ADM_setAdministracao`('0', 'FLUXO', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'FLUXO', 'procedure', 'spMovimentoFluxo', '', '');
CALL `ADM_setAdministracao`('0', 'FLUXO', 'view', 'vw_movimentos_fluxos', '', '');
CALL `ADM_setAdministracao`('0', 'FLUXO', 'filter', 'CONTA', 'CONTA', '1');

CALL `ADM_setAdministracao`('0', 'PLANOS DE CONTAS', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'PLANOS DE CONTAS', 'procedure', 'spMovimentoPlanoContas', '', '');
CALL `ADM_setAdministracao`('0', 'PLANOS DE CONTAS', 'view', 'vw_movimentos_pcontas', '', '');
CALL `ADM_setAdministracao`('0', 'PLANOS DE CONTAS', 'filter', 'GRUPO', 'GRUPO', '1');

CALL `ADM_setAdministracao`('0', 'CONDIÇÕES', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'CONDIÇÕES', 'procedure', 'spMovimentoPlanoCondicoes', '', '');
CALL `ADM_setAdministracao`('0', 'CONDIÇÕES', 'view', 'vw_movimentos_condicoes', '', '');
CALL `ADM_setAdministracao`('0', 'CONDIÇÕES', 'filter', 'DESCRICAO', 'DESCRIÇÃO', '1');

CALL `ADM_setAdministracao`('0', 'TRANSAÇÕES', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'TRANSAÇÕES', 'procedure', 'spMovimentoPlanoTransacao', '', '');
CALL `ADM_setAdministracao`('0', 'TRANSAÇÕES', 'view', 'vw_movimentos_transacao', '', '');
CALL `ADM_setAdministracao`('0', 'TRANSAÇÕES', 'filter', 'TRANSACAO', 'TRANSAÇÃO', '1');

CALL `ADM_setAdministracao`('0', 'ATERRO', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'ATERRO', 'procedure', 'spCadastroAterro', '', '');
CALL `ADM_setAdministracao`('0', 'ATERRO', 'view', 'vw_aterros', '', '');
CALL `ADM_setAdministracao`('0', 'ATERRO', 'filter', 'NOME', 'ATERRO', '1');
CALL `ADM_setAdministracao`('0', 'ATERRO', 'filter', 'APELIDO', 'APELIDO', '2');

CALL `ADM_setAdministracao`('0', 'CEP', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'CEP', 'procedure', 'spCadastroCep', '', '');
CALL `ADM_setAdministracao`('0', 'CEP', 'view', 'vw_cep', '', '');
CALL `ADM_setAdministracao`('0', 'CEP', 'filter', 'CEP', 'CEP', '1');
CALL `ADM_setAdministracao`('0', 'CEP', 'filter', 'ENDERECO', 'ENDERECO', '2');

CALL `ADM_setAdministracao`('0', 'FUNCIONARIO', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'FUNCIONARIO', 'procedure', 'spCadastroFuncionario', '', '');
CALL `ADM_setAdministracao`('0', 'FUNCIONARIO', 'view', 'vw_funcionarios', '', '');
CALL `ADM_setAdministracao`('0', 'FUNCIONARIO', 'filter', 'NOME', 'FUNCIONARIO', '1');
CALL `ADM_setAdministracao`('0', 'FUNCIONARIO', 'filter', 'CARGO', 'CARGO', '2');

CALL `ADM_setAdministracao`('0', 'LINKS', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'LINKS', 'procedure', 'spCadastroLink', '', '');
CALL `ADM_setAdministracao`('0', 'LINKS', 'view', 'vw_links', '', '');
CALL `ADM_setAdministracao`('0', 'LINKS', 'filter', 'DESCRICAO', 'DESCRICAO', '1');

CALL `ADM_setAdministracao`('0', 'MATERIAL', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'MATERIAL', 'procedure', 'spCadastroMaterial', '', '');
CALL `ADM_setAdministracao`('0', 'MATERIAL', 'view', 'vw_materiais', '', '');
CALL `ADM_setAdministracao`('0', 'MATERIAL', 'filter', 'MATERIAL', 'MATERIAL', '1');

CALL `ADM_setAdministracao`('0', 'TELEFONE', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'TELEFONE', 'procedure', 'spCadastroTelefone', '', '');
CALL `ADM_setAdministracao`('0', 'TELEFONE', 'view', 'vw_telefones', '', '');
CALL `ADM_setAdministracao`('0', 'TELEFONE', 'filter', 'DESCRICAO', 'DESCRICAO', '1');

CALL `ADM_setAdministracao`('0', 'VEICULO', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'VEICULO', 'procedure', 'spCadastroVeiculo', '', '');
CALL `ADM_setAdministracao`('0', 'VEICULO', 'view', 'vw_veiculos', '', '');
CALL `ADM_setAdministracao`('0', 'VEICULO', 'filter', 'PLACA', 'PLACA', '1');
CALL `ADM_setAdministracao`('0', 'VEICULO', 'filter', 'MODELO', 'MODELO', '2');

CALL `ADM_setAdministracao`('0', 'CARGO', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'CARGO', 'procedure', 'spCadastroFuncionarioCargo', '', '');
CALL `ADM_setAdministracao`('0', 'CARGO', 'view', 'vw_funcionarios_cargos', '', '');
CALL `ADM_setAdministracao`('0', 'CARGO', 'filter', 'CARGO', 'CARGO', '1');

CALL `ADM_setAdministracao`('0', 'OBS DE CLIENTE', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'OBS DE CLIENTE', 'procedure', 'spCadastroObservacao', '', '');
CALL `ADM_setAdministracao`('0', 'OBS DE CLIENTE', 'view', 'vw_clientes_observacoes', '', '');
CALL `ADM_setAdministracao`('0', 'OBS DE CLIENTE', 'filter', 'OBSERVACAO', 'OBSERVACAO', '1');
CALL `ADM_setAdministracao`('0', 'OBS DE CLIENTE', 'filter', 'STATUS', 'STATUS', '2');

CALL `ADM_setAdministracao`('0', 'LIGAÇÕES STATUS', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'LIGAÇÕES STATUS', 'procedure', 'spCadastroLigacaoStatus', '', '');
CALL `ADM_setAdministracao`('0', 'LIGAÇÕES STATUS', 'view', 'vw_servicos_ligacoes_status', '', '');
CALL `ADM_setAdministracao`('0', 'LIGAÇÕES STATUS', 'filter', 'STATUS', 'STATUS', '1');

CALL `ADM_setAdministracao`('0', 'PRECIFICAÇÃO', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'PRECIFICAÇÃO', 'procedure', 'spCadastroPrecificacao', '', '');
CALL `ADM_setAdministracao`('0', 'PRECIFICAÇÃO', 'view', 'vw_clientes_precificacao', '', '');
CALL `ADM_setAdministracao`('0', 'PRECIFICAÇÃO', 'filter', 'DESCRICAO', 'DESCRICAO', '1');

CALL `ADM_setAdministracao`('0', 'PROPAGANDAS', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'PROPAGANDAS', 'procedure', 'spCadastroPropaganda', '', '');
CALL `ADM_setAdministracao`('0', 'PROPAGANDAS', 'view', 'vw_propagandas', '', '');
CALL `ADM_setAdministracao`('0', 'PROPAGANDAS', 'filter', 'DESCRICAO', 'DESCRICAO', '1');

CALL `ADM_setAdministracao`('0', 'SERVIÇOS', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'SERVIÇOS', 'procedure', 'spServicoStatus', '', '');
CALL `ADM_setAdministracao`('0', 'SERVIÇOS', 'view', 'vw_servicos_status', '', '');
CALL `ADM_setAdministracao`('0', 'SERVIÇOS', 'filter', 'STATUS', 'STATUS', '1');

CALL `ADM_setAdministracao`('0', 'TIPOS DE CADASTROS', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'TIPOS DE CADASTROS', 'procedure', 'spCadastroTipoCadastro', '', '');
CALL `ADM_setAdministracao`('0', 'TIPOS DE CADASTROS', 'view', 'vw_tipos_cadastros', '', '');
CALL `ADM_setAdministracao`('0', 'TIPOS DE CADASTROS', 'filter', 'TIPO', 'TIPO', '1');

CALL `ADM_setAdministracao`('0', 'BLOQUEIO DE OBS DE CLIENTE', '', '', '', '');
CALL `ADM_setAdministracao`('0', 'BLOQUEIO DE OBS DE CLIENTE', 'procedure', 'spCadastroObservacoesStatus', '', '');
CALL `ADM_setAdministracao`('0', 'BLOQUEIO DE OBS DE CLIENTE', 'view', 'vw_clientes_observacoes_status', '', '');
CALL `ADM_setAdministracao`('0', 'BLOQUEIO DE OBS DE CLIENTE', 'filter', 'STATUS', 'STATUS', '1');
