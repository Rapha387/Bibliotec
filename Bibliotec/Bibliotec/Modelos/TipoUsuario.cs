using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Modelos
{
    public class TipoUsuario
    {
        public string nome { get; set; } 

        public string codigo { get; set; }


        public TipoUsuario(string codigo, string nome)
        {
            this.nome = nome;
            this.codigo = codigo;  
        }
    }
}
