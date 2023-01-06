using Bibliotec.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Logica
{
    internal class RegistroOcorrecia
    {
        public List<Ocorrencia> ListaOcorrencia { get; set; }

        public Ocorrencia OcorrenciaCliente { get; set; }

        public Ocorrencia ListaQtOcorrenciaCliente { get; set; }

        public void RegistrarOcorrencia(string login, int cdExemplar, int cdLivro, string dtEmprestimo, int cdTipoOcorrencia, string dsOcorrencia)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");

            banco.Conectar();

            dtEmprestimo = DateTime.Parse(dtEmprestimo).ToString("yyyy-MM-dd");

            banco.InserirComando($"INSERT INTO ocorrencia(nm_login, cd_exemplar, cd_livro, dt_emprestimo, cd_tipo_ocorrencia, ds_ocorrencia) " +
                $"VALUES('{login}', {cdExemplar}, {cdLivro}, '{dtEmprestimo}', {cdTipoOcorrencia}, '{dsOcorrencia}');");

            banco.Desconectar();
        }

        public void MostrarOcorrencias(string filtro)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");

            banco.Conectar();

            MySqlDataReader dados = banco.Consultar("select oc.nm_login, oc.cd_exemplar, oc.cd_livro, l.nm_livro, date_format(oc.dt_emprestimo, '%d/%m/%Y') as dt_emprestimo, oc.cd_tipo_ocorrencia, oc.ds_ocorrencia from ocorrencia oc " +
                "JOIN emprestimo em ON (em.dt_emprestimo = oc.dt_emprestimo) JOIN usuario us ON (us.nm_login = em.nm_login) and (us.nm_login = oc.nm_login) " +
                $"JOIN exemplar ex ON (ex.cd_exemplar = em.cd_exemplar) and (ex.cd_exemplar = oc.cd_exemplar) JOIN livro l ON (l.cd_livro = ex.cd_livro) and (l.cd_livro = oc.cd_livro) and (l.cd_livro = em.cd_livro) where us.nm_login = '{filtro}';");

            ListaOcorrencia = new List<Ocorrencia>();
            Usuario usuario = new Usuario(filtro);

            while (dados.Read())
            {
                Exemplar exemplar = new Exemplar(int.Parse(dados["cd_exemplar"].ToString()));
                Livro livro = new Livro(int.Parse(dados["cd_livro"].ToString()), dados["nm_livro"].ToString());
                Emprestimo emprestimo = new Emprestimo(dados["dt_emprestimo"].ToString());
                TipoOcorrencia tipoOcorrencia = new TipoOcorrencia(int.Parse(dados["cd_tipo_ocorrencia"].ToString()));

                Ocorrencia ocorrencia = new Ocorrencia(usuario, exemplar, livro, emprestimo, tipoOcorrencia, dados["ds_ocorrencia"].ToString());

                ListaOcorrencia.Add(ocorrencia);
            }

            banco.Desconectar();
        }

        public void PegarOcorrencia(string login, int cdLivro, int cdExemplar, string dtEmprestimo)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");

            banco.Conectar();

            dtEmprestimo = DateTime.Parse(dtEmprestimo).ToString("yyyy-MM-dd"); 

            string comando = "select oc.nm_login, oc.cd_exemplar, oc.cd_livro, l.nm_livro, date_format(oc.dt_emprestimo, '%d/%m/%Y') as dt_emprestimo, date_format(em.dt_devolucao, '%d/%m/%Y') as dt_devolucao, oc.cd_tipo_ocorrencia, oc.ds_ocorrencia from ocorrencia oc " +
                "JOIN emprestimo em ON (em.dt_emprestimo = oc.dt_emprestimo) JOIN usuario us ON (us.nm_login = em.nm_login) and (us.nm_login = oc.nm_login) " +
                $"JOIN exemplar ex ON (ex.cd_exemplar = em.cd_exemplar) and (ex.cd_exemplar = oc.cd_exemplar) JOIN livro l ON (l.cd_livro = ex.cd_livro) and (l.cd_livro = oc.cd_livro) and (l.cd_livro = em.cd_livro) " +
                $"where us.nm_login = '{login}' and l.cd_livro = {cdLivro} and ex.cd_exemplar = {cdExemplar} and em.dt_emprestimo = '{dtEmprestimo}';";

            MySqlDataReader dados = banco.Consultar(comando);

            ListaOcorrencia = new List<Ocorrencia>();
            Usuario usuario = new Usuario(login);

            if (dados.Read())
            {
                Exemplar exemplar = new Exemplar(int.Parse(dados["cd_exemplar"].ToString()));
                Livro livro = new Livro(int.Parse(dados["cd_livro"].ToString()), dados["nm_livro"].ToString());
                Emprestimo emprestimo = new Emprestimo(dados["dt_emprestimo"].ToString(), dados["dt_devolucao"].ToString());
                TipoOcorrencia tipoOcorrencia = new TipoOcorrencia(int.Parse(dados["cd_tipo_ocorrencia"].ToString()));

                OcorrenciaCliente = new Ocorrencia(usuario, exemplar, livro, emprestimo, tipoOcorrencia, dados["ds_ocorrencia"].ToString());
            }

            banco.Desconectar();
        }

        public int MostrarQuantidadeOcorrenciasCliente(string login)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");

            banco.Conectar();

            MySqlDataReader dados = banco.Consultar($"select cd_exemplar from ocorrencia where nm_login = '{login}';");

            int contador = 0;

            while (dados.Read())
            {
                contador++;
            }

            banco.Desconectar();

            return contador;
        }
    }
}