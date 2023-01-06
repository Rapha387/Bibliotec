using Bibliotec.Logica;
using Bibliotec.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotec
{
    public partial class frmOcorrenciasCliente : Form
    {
        public Usuario Usuario { get; set; }

        public frmOcorrenciasCliente()
        {
            InitializeComponent();
        }

        public frmOcorrenciasCliente(Usuario usuario)
        {
            InitializeComponent();

            this.Usuario = usuario;
        }

        private void frmOcorrenciasCliente_Load(object sender, EventArgs e)
        {
            txtRM.Text = Usuario.Login;
            txtNome.Text = Usuario.Nome;

            RegistroOcorrecia ocorrencias = new RegistroOcorrecia();

            ocorrencias.MostrarOcorrencias(Usuario.Login);

            for (int i = 0; i < ocorrencias.ListaOcorrencia.Count; i++)
            {
                tblOcorrencias.Rows.Add(ocorrencias.ListaOcorrencia[i].Livro.Codigo, ocorrencias.ListaOcorrencia[i].Livro.Titulo, ocorrencias.ListaOcorrencia[i].Exemplar.Codigo, ocorrencias.ListaOcorrencia[i].Emprestimo.DataEmprestimo);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tblOcorrencias_SelectionChanged(object sender, EventArgs e)
        {
            RegistroOcorrecia ocorrencias = new RegistroOcorrecia();

            string login = Usuario.Login;
            int cdLivro = int.Parse(tblOcorrencias.Rows[tblOcorrencias.CurrentRow.Index].Cells[0].Value.ToString());
            int cdExemplar = int.Parse(tblOcorrencias.Rows[tblOcorrencias.CurrentRow.Index].Cells[2].Value.ToString());
            string dtEmprestimo = tblOcorrencias.Rows[tblOcorrencias.CurrentRow.Index].Cells[3].Value.ToString();

            ocorrencias.PegarOcorrencia(login, cdLivro, cdExemplar, dtEmprestimo);

            txtCodigoLivro.Text = ocorrencias.OcorrenciaCliente.Livro.Codigo.ToString();
            txtTitulo.Text = ocorrencias.OcorrenciaCliente.Livro.Titulo;
            txtExemplar.Text = ocorrencias.OcorrenciaCliente.Exemplar.Codigo.ToString();
            txtDtEmprestimo.Text = ocorrencias.OcorrenciaCliente.Emprestimo.DataEmprestimo;
            txtDtDevolucao.Text = ocorrencias.OcorrenciaCliente.Emprestimo.DataDevolucao;
            txtDsOcorrencia.Text = ocorrencias.OcorrenciaCliente.DsOcorrencia;

            if (ocorrencias.OcorrenciaCliente.TipoOcorrencia.codigo == 1)
                chkTipoOcorrencia.Checked = false;
            else
                chkTipoOcorrencia.Checked = true;

        }
    }
}
