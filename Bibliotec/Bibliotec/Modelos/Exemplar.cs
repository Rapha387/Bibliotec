using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Modelos
{
    public class Exemplar
    {
        public int Codigo { get; set; } 
        public Livro Livro { get; set; }    
        public bool Fixo { get; set; }
        public Localizacao Localizacao { get; set; }

        public Exemplar(int codigo, Livro cdLivro, Localizacao localizacao, bool fixo)
        {
            this.Codigo = codigo;
            this.Livro = cdLivro;
            this.Localizacao = localizacao;
            this.Fixo = fixo;
        }

        public Exemplar(int codigo)
        {
            this.Codigo = codigo;
        }

    }
}
