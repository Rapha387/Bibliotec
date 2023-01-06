

select 
    ex.cd_livro as cd_livro,
    ex.cd_exemplar as cd_exemplar,
    l.nm_livro,
    ex.ic_fixo,
    lo.nm_localizacao
from
    exemplar ex
        JOIN
    livro l ON (ex.cd_livro = l.cd_livro)
        JOIN
    localizacao lo ON (lo.cd_localizacao = ex.cd_localizacao)
where
    ex.cd_livro like '1%'
        or l.nm_livro like 'ma%';
 