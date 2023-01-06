using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotec.Modelos;
using MySql.Data.MySqlClient;

namespace Bibliotec.Logica
{
    internal class ListaCliente
    {
        public List<Usuario> ListaUsuario { get; set; }

        //public Usuario Usuario { get; set; }

        public void ListarCliente(string filtro)
        {
            ListaUsuario = new List<Usuario>();
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");
            banco.Conectar();
            MySqlDataReader dados = banco.Consultar($"select u.nm_login, u.nm_usuario, u.ic_bloqueado, date_format(u.dt_bloqueio, '%d/%m/%Y') as dt_bloqueio, u.cd_tipo_usuario, t.nm_tipo_usuario " +
                $"from usuario u join tipo_usuario t on (u.cd_tipo_usuario = t.cd_tipo_usuario) where nm_login = '{filtro}' or nm_usuario like '{filtro}%'");

            while (dados.Read())
            {
                TipoUsuario tipoUsuario = new TipoUsuario(dados["cd_tipo_usuario"].ToString(), dados["nm_tipo_usuario"].ToString());

                Usuario usuario = new Usuario(dados["nm_login"].ToString(), dados["nm_usuario"].ToString(), bool.Parse(dados["ic_bloqueado"].ToString()), dados["dt_bloqueio"].ToString(), tipoUsuario);

                ListaUsuario.Add(usuario);
            }

            banco.Desconectar();
        }

        public Usuario PegarCliente(string cod)
        {
            Usuario Usuario = new Usuario();
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec"); 
            banco.Conectar();
            MySqlDataReader dados = banco.Consultar($"select u.nm_login, u.nm_usuario, u.ic_bloqueado, u.dt_bloqueio, u.cd_tipo_usuario, t.nm_tipo_usuario " +
                $"from usuario u join tipo_usuario t on (u.cd_tipo_usuario = t.cd_tipo_usuario) where nm_login = '{cod}'");

            if (dados.Read())
            {
                TipoUsuario tipoUsuario = new TipoUsuario(dados["cd_tipo_usuario"].ToString(), dados["nm_tipo_usuario"].ToString());

                Usuario = new Usuario(dados["nm_login"].ToString(), dados["nm_usuario"].ToString(), bool.Parse(dados["ic_bloqueado"].ToString()), dados["dt_bloqueio"].ToString(), tipoUsuario);
            }

            banco.Desconectar();
            return Usuario;
        }

        public void BloquearCliente(string login)
        {
            Banco banco = new Banco("localhost", "root", "root", "Bibliotec");

            banco.Conectar();

            banco.InserirComando($"update usuario set ic_bloqueado = 1 where nm_login = '{login}';");
            banco.InserirComando($"update usuario set dt_bloqueio = current_date() where nm_login = '{login}';");

            banco.Desconectar();
        }
    }
}
