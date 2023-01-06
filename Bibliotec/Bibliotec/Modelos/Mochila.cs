using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Modelos
{
    public class Mochila
    {
        public Usuario Usuario { get; set; }

        public Livro Livro { get; set; }

        public Exemplar Exemplar { get; set; }

        public TipoEmprestimo TipoEmprestimo { get; set; }

        public Mochila(Usuario usuario, Livro livro, Exemplar exemplar, TipoEmprestimo tipoEmprestimo)
        {
            this.Usuario = usuario;
            this.Livro = livro;
            this.Exemplar = exemplar;
            this.TipoEmprestimo = tipoEmprestimo;
        }
    }
}
