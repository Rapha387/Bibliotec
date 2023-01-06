select 
    ex.cd_livro as cd_livro,
    ex.cd_exemplar as cd_exemplar,
    l.nm_livro,
    ex.ic_fixo as ic_fixo,
    lo.cd_localizacao as cd_localizacao,
    lo.nm_localizacao as nm_localizacao
from
    exemplar ex
        JOIN
    livro l ON (ex.cd_livro = l.cd_livro)
        JOIN
    localizacao lo ON (lo.cd_localizacao = ex.cd_localizacao)
where
    ex.cd_livro = 1
and 
  ex.cd_exemplar not in (select cd_exemplar from emprestimo where cd_livro = 1);