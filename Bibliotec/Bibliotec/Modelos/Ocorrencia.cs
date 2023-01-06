using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Modelos
{
    internal class Ocorrencia
    {
        public Usuario Usuario { get; set; }
        public Exemplar Exemplar { get; set; }
        public Livro Livro { get; set; }
        public Emprestimo Emprestimo { get; set; }
        public TipoOcorrencia TipoOcorrencia { get; set; }
        public string DsOcorrencia { get; set; }
        
        public Ocorrencia(Usuario login, Exemplar cdExemplar, Livro cdLivro, Emprestimo dtEmprestimo, TipoOcorrencia tipoOcorrencia, string dsOcorrencia)
        {
            this.Usuario = login;
            this.Exemplar = cdExemplar;
            this.Livro = cdLivro;
            this.Emprestimo = dtEmprestimo;
            this.TipoOcorrencia = tipoOcorrencia;
            this.DsOcorrencia = dsOcorrencia;
        }
    }
}
