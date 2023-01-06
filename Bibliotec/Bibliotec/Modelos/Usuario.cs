using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Modelos
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Nome{ get; set; }
        public bool TipoBloqueio { get; set; }
        public string DataBloqueio { get; set; }
        public  TipoUsuario TipoUsuario{ get; set; }

        public Usuario(string login,string nome, bool bloqueado, string dataBlcok, TipoUsuario tipoUsuario)
        {
            this.Login = login;
            this.Nome = nome;
            this.TipoBloqueio = bloqueado;
            this.DataBloqueio = dataBlcok;
            this.TipoUsuario = tipoUsuario;
        }

        public Usuario(string login)
        {
            this.Login = login;
        }

        public Usuario()
        {

        }
    }
}
