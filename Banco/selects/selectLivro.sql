select l.cd_livro, l.cd_ISBN, l.nm_livro, l.aa_edicao, l.ds_sinopse, l.cd_editora, ed.nm_editora,
 group_concat(distinct(la.cd_autor)) as cd_autor, group_concat(distinct(a.nm_autor)), 
 group_concat(distinct(lc.cd_categoria)) as cd_categoria, group_concat(distinct(c.nm_categoria)) as nm_categoria, l.capa
	from livro l 
		JOIN editora ed ON (l.cd_editora = ed.cd_editora)
		JOIN livro_autor la ON (l.cd_livro = la.cd_livro)
		JOIN autor a ON (la.cd_autor = a.cd_autor)
		JOIN livro_categoria lc ON (lc.cd_livro = l.cd_livro)
		JOIN categoria c ON (lc.cd_categoria = c.cd_categoria)
		/*where l.cd_ISBN like '8%' or l.nm_livro like 'm%'*/
group by cd_livro;

