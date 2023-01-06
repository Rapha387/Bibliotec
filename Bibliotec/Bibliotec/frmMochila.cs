using Bibliotec.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotec.Logica;

namespace Bibliotec
{
    public partial class frmMochila : Form
    {
        
        public List<Mochila> ListaMochila { get; set; }

        public bool EmprestimoCancelado { get; set; }

        public bool EmprestimoFinalizado { get; set; }

        public frmMochila()
        {
            InitializeComponent();
        }

        private void frmMochila_Load(object sender, EventArgs e)
        {
            EmprestimoCancelado = false;

            EmprestimoFinalizado = false;

            tblMochila.Rows.Clear();

            txtRM.Text = ListaMochila[0].Usuario.Login;
            txtNome.Text = ListaMochila[0].Usuario.Nome;

            int tipoEmprestimo = 0;

            for (int i = 0; i < ListaMochila.Count; i++)
            {
                if (ListaMochila[i].TipoEmprestimo.codigo == 2)
                    tipoEmprestimo = 0;
                else
                    tipoEmprestimo = 1;

                tblMochila.Rows.Add(ListaMochila[i].Livro.Codigo, ListaMochila[i].Livro.Titulo, ListaMochila[i].Exemplar.Codigo, tipoEmprestimo);
            }
        }

        private void btnFinalizarEmprestimo_Click(object sender, EventArgs e)
        {
            EmprestarLivro emprestimo = new EmprestarLivro();

            for (int i = 0; i < ListaMochila.Count; i++)
            {
                emprestimo.Emprestar(ListaMochila[0].Usuario.Login, ListaMochila[i].Exemplar.Codigo, ListaMochila[i].Livro.Codigo, ListaMochila[i].TipoEmprestimo.codigo);
            }

            EmprestimoFinalizado = true;

            Close();

            MessageBox.Show("Empréstimo realizado com sucesso!");
            
        }

        private void btnCancelarEmprestimo_Click(object sender, EventArgs e)
        {
            frmLivros frmLivros = new frmLivros();

            EmprestimoCancelado = true;
            ListaMochila.Clear();
            Close();
        }
    }
}
