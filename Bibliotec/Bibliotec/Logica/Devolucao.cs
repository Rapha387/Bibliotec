using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bibliotec.Logica
{
    internal class Devolucao
    {
        public EmprestarLivro Emprestimo { get; set; }

        public void DevolverLivro(string login, int cdLivro, int cdExemplar, string dtEmprestimo)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");

            banco.Conectar();

            dtEmprestimo = DateTime.Parse(dtEmprestimo).ToString("yyyy-MM-dd");

            banco.InserirComando($"update emprestimo set dt_devolucao = current_date() where nm_login = '{login}' and cd_livro = {cdLivro} and cd_exemplar = {cdExemplar} and dt_emprestimo = '{dtEmprestimo}';");

            banco.Desconectar();
        }

        public bool VerificarAtrasoLivro(string login, int cdLivro, int cdExemplar, string dtEmprestimo)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");

            banco.Conectar();

            dtEmprestimo = DateTime.Parse(dtEmprestimo).ToString("yyyy-MM-dd");

            string comando = $"select dt_devolucao_estimada, dt_devolucao from emprestimo where nm_login = '{login}' and cd_livro = {cdLivro} and cd_exemplar = {cdExemplar} and dt_emprestimo = '{dtEmprestimo}';";

            MySqlDataReader dados = banco.Consultar(comando);


            bool verifica = false;

            if (dados.Read())
            {
                DateTime dataEmprestimoEstimada = DateTime.Parse(dados["dt_devolucao_estimada"].ToString());
                DateTime dataDevolucao = DateTime.Parse(dados["dt_devolucao"].ToString());

                if (dataDevolucao > dataEmprestimoEstimada)
                {
                    verifica = true;
                }
            }

            banco.Desconectar();


            if (verifica == true)
                return true;
            else
                return false;
        }
    }
}
