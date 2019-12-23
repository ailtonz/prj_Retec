SELECT codControle, Descricao01 as PERFIL FROM administracao WHERE codRelacao = (Select codControle from administracao where Descricao01 = 'DEPARTAMENTOS' limit 1) order by Ordem;

SELECT codControle, Descricao01 as USUARIO,Descricao02 as SENHA FROM administracao WHERE codRelacao = (Select codControle from administracao where Descricao01 = 'USUARIOS' limit 1) order by Ordem;

SELECT codControle, Descricao01 as OPERACAO,Descricao02 as COMANDO FROM administracao WHERE codRelacao = (Select codControle from administracao where Descricao01 = 'OPERACOES' limit 1) order by Descricao01;

SELECT codControle, Descricao01 as FUNCAO ,Descricao02 as COMANDO FROM administracao WHERE codRelacao = (Select codControle from administracao where Descricao01 = 'FUNCOES' limit 1) order by Ordem;