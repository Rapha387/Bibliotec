using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Modelos
{
    public class TipoEmprestimo
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        public TipoEmprestimo(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public TipoEmprestimo(int codigo)
        {
            this.codigo = codigo;
        }
    }
}
