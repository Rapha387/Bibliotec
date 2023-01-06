using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Modelos
{
    internal class TipoOcorrencia
    {
        public string nome { get; set; }
        public int codigo { get; set; }

        public TipoOcorrencia(string nome, int codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }

        public TipoOcorrencia(int codigo)
        {
            this.codigo = codigo;
        }
    }
}
