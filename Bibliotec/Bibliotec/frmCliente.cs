using Bibliotec.Logica;
using Bibliotec.Modelos;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotec
{
    public partial class frmCliente : Form
    {
        public Usuario Cliente { get; set; }
        
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
                return;

            tblCliente.Rows.Clear();

            ListaCliente listaCliente = new ListaCliente();

            listaCliente.ListarCliente(txtCliente.Text);

            if (listaCliente.ListaUsuario.Count == 0)
            {
                return;
            }

            for (int i = 0; i < listaCliente.ListaUsuario.Count; i++)
            {
                tblCliente.Rows.Add(listaCliente.ListaUsuario[i].Login, listaCliente.ListaUsuario[i].Nome, listaCliente.ListaUsuario[i].TipoUsuario.nome, listaCliente.ListaUsuario[i].TipoBloqueio);
            }
        }

        private void btnIdentificarCliente_Click(object sender, EventArgs e)
        {
            ListaCliente cliente = new ListaCliente();
            string cod;

            if (tblCliente.Rows.Count == 0)
            {
                return;
            }
            else
            {
                cod = tblCliente.Rows[tblCliente.CurrentRow.Index].Cells[0].Value.ToString();
            }

            cliente.PegarCliente(cod);

            Cliente = cliente.PegarCliente(cod);

            Close();
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            tblCliente.Rows.Clear();
            tblEmprestimos.Rows.Clear();
            txtCliente.Text = "";
            txtRM.Text = "";
            txtDataBloqueio.Text = "";
            txtDesbloqueio.Text = "";
            txtNomeCliente.Text = "";
            txtOcorrencias.Text = "";
            txtTipoCliente.Text = "";
        }

        private void tblCliente_SelectionChanged(object sender, EventArgs e)
        {
            tblEmprestimos.Rows.Clear();

            if (tblCliente.Rows.Count == 0)
                return;

            if (txtCliente.Text == "")
                return;

            string filtro = txtCliente.Text;

            ListaCliente listaCliente = new ListaCliente();

            listaCliente.ListarCliente(filtro);

            txtRM.Text = listaCliente.ListaUsuario[0].Login;
            txtNomeCliente.Text = listaCliente.ListaUsuario[0].Nome;
            
            if(listaCliente.ListaUsuario[0].TipoBloqueio == true)
                chkSituacao.Checked = true;
            else
                chkSituacao.Checked = false;

            txtTipoCliente.Text = listaCliente.ListaUsuario[0].TipoUsuario.nome;

            if(listaCliente.ListaUsuario[0].TipoBloqueio == true)
            {
                txtDataBloqueio.Text = listaCliente.ListaUsuario[0].DataBloqueio;
                string dataDesbloqueio = DateTime.Parse(listaCliente.ListaUsuario[0].DataBloqueio).AddDays(7).ToString("dd/MM/yyyy");
                txtDesbloqueio.Text = dataDesbloqueio;
            }
            else
            {
                txtDataBloqueio.Text = "-";
                txtDesbloqueio.Text = "-";
            }

            RegistroOcorrecia ocorrecia = new RegistroOcorrecia();

            txtOcorrencias.Text = ocorrecia.MostrarQuantidadeOcorrenciasCliente(listaCliente.ListaUsuario[0].Login).ToString();

            ListaEmprestimo listaEmprestimo = new ListaEmprestimo();

            listaEmprestimo.ListarEmprestimosCliente(listaCliente.ListaUsuario[0].Login);

            for (int i = 0; i < listaEmprestimo.ListaEmprestimosCliente.Count; i++)
            {
                tblEmprestimos.Rows.Add(listaEmprestimo.ListaEmprestimosCliente[i].Livro.Codigo, listaEmprestimo.ListaEmprestimosCliente[i].Exemplar.Codigo, listaEmprestimo.ListaEmprestimosCliente[i].Livro.Titulo, listaEmprestimo.ListaEmprestimosCliente[i].DataEmprestimo, listaEmprestimo.ListaEmprestimosCliente[i].DataDevolucaoEstimada);
            }
        }

        private void frmCliente_FormClosed(object sender, FormClosedEventArgs e)
        
        {
            Limpar();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (tblEmprestimos.Rows.Count == 0) return;

            Devolucao devolucao = new Devolucao();

            ListaCliente cliente = new ListaCliente();

            string cod = tblCliente.Rows[tblCliente.CurrentRow.Index].Cells[0].Value.ToString();
            cliente.PegarCliente(cod);
            Cliente = cliente.PegarCliente(cod);

            string login = tblCliente.Rows[tblCliente.CurrentRow.Index].Cells[0].Value.ToString();
            int cdLivro = int.Parse(tblEmprestimos.Rows[tblEmprestimos.CurrentRow.Index].Cells[0].Value.ToString());
            int cdExemplar = int.Parse(tblEmprestimos.Rows[tblEmprestimos.CurrentRow.Index].Cells[1].Value.ToString());
            string dtEmprestimo = tblEmprestimos.Rows[tblEmprestimos.CurrentRow.Index].Cells[3].Value.ToString();
            
            Exemplar exemplar = new Exemplar(cdExemplar);
            Livro livro = new Livro(cdLivro);
            Emprestimo emprestimo = new Emprestimo(dtEmprestimo);

            frmRelatarOcorrencia frmOcorrencia = new frmRelatarOcorrencia(Cliente, exemplar, livro, emprestimo);

            if (MessageBox.Show("Deseja relatar uma ocorrência?", "Ocorrência", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                frmOcorrencia.ShowDialog();
            }

            devolucao.DevolverLivro(login, cdLivro, cdExemplar, dtEmprestimo);

            bool verificaAtrasoDevolucao = devolucao.VerificarAtrasoLivro(login, cdLivro, cdExemplar, dtEmprestimo);

            if (verificaAtrasoDevolucao == true)
            {
                cliente.BloquearCliente(Cliente.Login);
            }

            Limpar();
        }

        private void btnOcorrencias_Click(object sender, EventArgs e)
        {
            if (tblCliente.Rows.Count == 0) return;

            ListaCliente cliente = new ListaCliente();

            string cod = tblCliente.Rows[tblCliente.CurrentRow.Index].Cells[0].Value.ToString();
            cliente.PegarCliente(cod);
            Cliente = cliente.PegarCliente(cod);

            frmOcorrenciasCliente frmOcorrenciasCliente = new frmOcorrenciasCliente(Cliente);

            frmOcorrenciasCliente.ShowDialog();

        }
    }
}
