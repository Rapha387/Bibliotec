using Bibliotec.Logica;
using Bibliotec.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Bibliotec
{
    public partial class frmRelatarOcorrencia : Form
    {
        public Usuario Usuario { get; set; }
        public Exemplar Exemplar { get; set; }
        public Livro Livro { get; set; }
        public Emprestimo Emprestimo { get; set; }

        public frmRelatarOcorrencia()
        {
            InitializeComponent();
        }

        public frmRelatarOcorrencia(Usuario login, Exemplar cdExemplar, Livro cdLivro, Emprestimo dtEmprestimo)
        {
            InitializeComponent();

            this.Usuario = login;
            this.Exemplar = cdExemplar;
            this.Livro = cdLivro;
            this.Emprestimo = dtEmprestimo;
        }

        private void btnRelatarOcorrencia_Click(object sender, EventArgs e)
        {
            if (txtOcorrencia.Text == "") return;

            string dsOcorrencia = txtOcorrencia.Text;

            int tipoOcorrencia = chkDanoGrave.Checked ? 2 :  1;

            RegistroOcorrecia ocorrencia = new RegistroOcorrecia();

            ocorrencia.RegistrarOcorrencia(Usuario.Login, Exemplar.Codigo, Livro.Codigo, Emprestimo.DataEmprestimo, tipoOcorrencia, dsOcorrencia);

            txtOcorrencia.Text = "";
            chkDanoGrave.Checked = false;

            Close();

            MessageBox.Show("Ocorrência relatada, devolução realizada com sucesso!");

        }

        private void frmOcorrencia_Load(object sender, EventArgs e)
        {

        }
    }
}
