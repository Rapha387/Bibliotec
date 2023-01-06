using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Bibliotec.Modelos;
using MySql.Data.MySqlClient;

namespace Bibliotec.Logica
{
    internal class ListaEmprestimo
    {
        public List<Emprestimo> ListaEmprestimosCliente { get; set; }

        public void ListarEmprestimosCliente(string filtro)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");

            banco.Conectar();

            MySqlDataReader dados = banco.Consultar("select ex.cd_livro, ex.cd_exemplar, l.nm_livro, date_format(em.dt_emprestimo, '%d/%m/%Y') as dt_emprestimo, date_format(em.dt_devolucao_estimada, '%d/%m/%Y') as dt_devolucao_estimada from emprestimo em " +
                $"JOIN exemplar ex ON (ex.cd_exemplar = em.cd_exemplar) JOIN livro l ON (l.cd_livro = ex.cd_livro) and (l.cd_livro = em.cd_livro) JOIN usuario us ON (us.nm_login = em.nm_login) where us.nm_login = '{filtro}' and dt_devolucao is null;");

            ListaEmprestimosCliente = new List<Emprestimo>();

            while (dados.Read())
            {
                Livro livro = new Livro(int.Parse(dados["cd_livro"].ToString()), dados["nm_livro"].ToString());
                Exemplar exemplar = new Exemplar(int.Parse(dados["cd_exemplar"].ToString()));

                Emprestimo emprestimo = new Emprestimo(livro, exemplar, dados["dt_emprestimo"].ToString(), dados["dt_devolucao_estimada"].ToString());

                ListaEmprestimosCliente.Add(emprestimo); 
            }

            banco.Desconectar();
        }

    }
}
