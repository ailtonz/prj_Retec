SELECT * FROM cadastros WHERE id not in (SELECT ID FROM cadastros where cadastro_categoria IS NULL);