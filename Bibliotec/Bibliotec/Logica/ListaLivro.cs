using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotec.Modelos;
using MySql.Data.MySqlClient;

namespace Bibliotec.Logica
{
    internal class ListaLivro
    {
        public List<Livro> Lista { get; set; }
        public List<Autor> ListaAutor { get; set; }
        public List<Categoria> ListaCategoria { get; set; }
        public List<Exemplar> ListaExemplar { get; set; }
        public List<Exemplar> ListaExemplares { get; set; }

        public void ListarLivro(string filtro)
        {
            Lista = new List<Livro>();

            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");
            banco.Conectar();

            MySqlDataReader dados = banco.Consultar("select l.cd_livro, l.cd_ISBN, l.nm_livro, l.aa_edicao, l.ds_sinopse, l.cd_editora, ed.nm_editora, " +
                "group_concat(distinct(la.cd_autor)) as cd_autor, group_concat(distinct(a.nm_autor)) as nm_autor, group_concat(distinct(lc.cd_categoria)) as cd_categoria, " +
                "group_concat(distinct(c.nm_categoria)) as nm_categoria, l.capa from livro l JOIN editora ed ON (l.cd_editora = ed.cd_editora) JOIN livro_autor la ON (l.cd_livro = la.cd_livro) " +
                "JOIN autor a ON (la.cd_autor = a.cd_autor) JOIN livro_categoria lc ON (lc.cd_livro = l.cd_livro) JOIN categoria c ON (lc.cd_categoria = c.cd_categoria) " +
                $"where l.cd_livro = '{filtro}' or l.cd_ISBN = '{filtro}' or l.nm_livro like '{filtro}%' group by cd_livro");

            while (dados.Read())
            {
                ListaAutor = new List<Autor>();
                ListaCategoria = new List<Categoria>();

                Editora editora = new Editora(int.Parse(dados[5].ToString()), dados[6].ToString());

                string[] codigoAutor = dados["cd_autor"].ToString().Split(',');
                string[] nomeAutor = dados["nm_autor"].ToString().Split(',');

                for (int i = 0; i < codigoAutor.Length; i++)
                {
                    Autor autor = new Autor(int.Parse(codigoAutor[i]), nomeAutor[i]);
                    ListaAutor.Add(autor);
                }

                string[] codigoCategoria = dados["cd_categoria"].ToString().Split(',');
                string[] nomeCategoria = dados["nm_categoria"].ToString().Split(',');

                for (int i = 0; i < codigoCategoria.Length; i++)
                {
                    Categoria categoria = new Categoria(int.Parse(codigoCategoria[i]), nomeCategoria[i]);
                    ListaCategoria.Add(categoria);
                }
      
                Livro livro = new Livro(int.Parse(dados[0].ToString()), dados[1].ToString(), dados[2].ToString(), int.Parse(dados[3].ToString()), dados[4].ToString(), editora, ListaAutor, ListaCategoria);
                Lista.Add(livro);

                livro.Capa = "";
                if (!String.IsNullOrEmpty(dados["capa"].ToString()))
                {
                    byte[] foto = null;
                    foto = (byte[])dados["capa"];
                    string base64String = Convert.ToBase64String(foto, 0, foto.Length);
                    livro.Capa = base64String;
                }
            }

            banco.Desconectar();
        }

        public void GerarExemplar(int cdLivro)
        { 
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");
            banco.Conectar();

            string comando = "select ex.cd_livro as cd_livro, ex.cd_exemplar as cd_exemplar, l.nm_livro, ex.ic_fixo as ic_fixo,lo.cd_localizacao as cd_localizacao, lo.nm_localizacao as nm_localizacao from exemplar ex " +
                $"JOIN livro l ON (ex.cd_livro = l.cd_livro) JOIN localizacao lo ON (lo.cd_localizacao = ex.cd_localizacao) where ex.cd_livro = {cdLivro} and ex.cd_exemplar not in (select cd_exemplar from emprestimo where cd_livro = {cdLivro} and dt_devolucao is null); ";

            MySqlDataReader dados = banco.Consultar(comando);

            Livro livro = new Livro(cdLivro);

            ListaExemplar = new List<Exemplar>();

            while (dados.Read())
            {
                Localizacao localizacao = new Localizacao(int.Parse(dados["cd_localizacao"].ToString()), dados["nm_localizacao"].ToString());

                Exemplar exemplar = new Exemplar(int.Parse(dados["cd_exemplar"].ToString()), livro, localizacao, bool.Parse(dados["ic_fixo"].ToString()));

                ListaExemplar.Add(exemplar);
            }
            
            banco.Desconectar();
        }

        public void Exemplares(int cdLivro)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");
            banco.Conectar();

            string comando = $"select cd_exemplar from exemplar where cd_livro = {cdLivro}";

            MySqlDataReader dados = banco.Consultar(comando);

            ListaExemplares = new List<Exemplar>();

            while (dados.Read())
            {
                Exemplar exemplar = new Exemplar(int.Parse(dados["cd_exemplar"].ToString()));

                ListaExemplares.Add(exemplar);
            }

            banco.Desconectar();
        }
    }
}
