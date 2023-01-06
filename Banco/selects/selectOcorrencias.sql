

select 
    oc.nm_login,
    oc.cd_exemplar,
    oc.cd_livro,
    l.nm_livro,
    date_format(oc.dt_emprestimo, '%d/%m/%Y'),
    oc.cd_tipo_ocorrencia,
    oc.ds_ocorrencia
from
    ocorrencia oc
        JOIN
    emprestimo em ON (em.dt_emprestimo = oc.dt_emprestimo)
        JOIN
    usuario us ON (us.nm_login = em.nm_login)
        and (us.nm_login = oc.nm_login)
        JOIN
    exemplar ex ON (ex.cd_exemplar = em.cd_exemplar)
        and (ex.cd_exemplar = oc.cd_exemplar)
        JOIN
    livro l ON (l.cd_livro = ex.cd_livro)
        and (l.cd_livro = oc.cd_livro)
        and (l.cd_livro = em.cd_livro)
where
    us.nm_login = 'admin';