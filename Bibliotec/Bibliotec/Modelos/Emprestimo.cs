using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Modelos
{
    public class Emprestimo
    {
        public Usuario Usuario { get; set; }
        public Exemplar Exemplar { get; set; }
        public Livro Livro { get; set; }
        public string DataEmprestimo { get; set; }
        public string HoraEmprestimo { get; set; }
        public string DataDevolucaoEstimada { get; set; }
        public string DataDevolucao { get; set; }
        public TipoEmprestimo TipoEprestmo { get; set; }

        public Emprestimo(Usuario login, Exemplar cdExemplar, Livro cdLivro, string dtEmprestimo, string hrEmprestimo, string dtDevolucaoEstimada, string dtDevolucao, TipoEmprestimo tipoEmprestimo)
        {
            this.Usuario = login;
            this.Exemplar = cdExemplar;
            this.Livro = cdLivro;
            this.DataEmprestimo = dtEmprestimo;
            this.HoraEmprestimo = hrEmprestimo;
            this.DataDevolucaoEstimada = dtDevolucaoEstimada;
            this.DataDevolucao = dtDevolucao;
            this.TipoEprestmo = tipoEmprestimo;
        }

        public Emprestimo(Livro livro, Exemplar cdExemplar, string dtEmprestimo, string dtDevolucaoEstimada)
        {
            this.Livro = livro;
            this.Exemplar = cdExemplar;
            this.DataEmprestimo = dtEmprestimo;
            this.DataDevolucaoEstimada = dtDevolucaoEstimada;
        }

        public Emprestimo(Usuario login, Livro livro, Exemplar cdExemplar, string dtEmprestimo)
        {
            this.Usuario = login;
            this.Livro = livro;
            this.Exemplar = cdExemplar;
            this.DataEmprestimo = dtEmprestimo;
        }

        public Emprestimo(string dtEmprestimo)
        {
            this.DataEmprestimo = dtEmprestimo;
        }

        public Emprestimo(string dtEmprestimo, string dtDevolucao)
        {
            this.DataEmprestimo = dtEmprestimo;
            this.DataDevolucao = dtDevolucao;
        }
    }
}
