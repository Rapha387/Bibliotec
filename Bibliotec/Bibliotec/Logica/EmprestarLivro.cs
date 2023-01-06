using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotec.Modelos;

namespace Bibliotec.Logica
{
    internal class EmprestarLivro
    {
        public Emprestimo Emprestimo { get; set; } 

        public void Emprestar(string login ,int codExemplar, int cdLivro, int cdTipoEmprestimo)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");

            banco.Conectar();

            DateTime data = DateTime.Now;
            string dataAtual = data.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("H:m");
            string dataEstimada = data.AddDays(14).ToString("yyyy-MM-dd");

            banco.InserirComando($"insert into emprestimo (nm_login, cd_exemplar, cd_livro, dt_emprestimo, hr_emprestimo, dt_devolucao_estimada, dt_devolucao, cd_tipo_emprestimo) " +
                $"values ('{login}', {codExemplar}, {cdLivro}, '{dataAtual}', '{hora}', '{dataEstimada}', null, {cdTipoEmprestimo})");

            banco.Desconectar();
        }
    }
}
