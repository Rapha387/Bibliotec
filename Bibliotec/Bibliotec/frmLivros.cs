using Bibliotec.Logica;
using Bibliotec.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotec
{
    public partial class frmLivros : Form
    {
        public int Contador {get; set;}

        public List<Mochila> Mochila { get; set; }

        public frmLivros()
        {
            InitializeComponent();
        }

        frmCliente frmCliente = new frmCliente();

        frmMochila frmMochila = new frmMochila();

        public void frmLivros_Load(object sender, EventArgs e)
        {
            Mochila = new List<Mochila>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarLivro.Text == "")
                return;

            tblLivros.Rows.Clear();

            ListaLivro listaLivro = new ListaLivro();

            listaLivro.ListarLivro(txtBuscarLivro.Text);

            if (listaLivro.Lista.Count == 0)
            {
                return;
            }

            for (int i = 0; i < listaLivro.Lista.Count; i++)
            {
                string autor = "";
                string categoria = "";

                for (int a = 0; a < listaLivro.Lista[i].Autor.Count; a++)
                {
                    autor += listaLivro.Lista[i].Autor[a].Nome + ", ";
                }

                autor = autor.Substring(0, autor.Length - 2);

                for (int a = 0; a < listaLivro.Lista[i].Categoria.Count; a++)
                {
                    categoria += listaLivro.Lista[i].Categoria[a].Nome + ", ";
                }

                categoria = categoria.Substring(0, categoria.Length - 2);

                listaLivro.GerarExemplar(listaLivro.Lista[i].Codigo);

                int disponibilidade = listaLivro.ListaExemplar.Count;

                listaLivro.Exemplares(listaLivro.Lista[i].Codigo);

                int qtMaximaExemplares = listaLivro.ListaExemplares.Count;

                string exemplar = disponibilidade + " / "  + qtMaximaExemplares;

                tblLivros.Rows.Add(listaLivro.Lista[i].Codigo,listaLivro.Lista[i].ISBN, listaLivro.Lista[i].Titulo, listaLivro.Lista[i].Editora.Nome, autor, categoria, exemplar);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtBuscarLivro.Text = "";
            tblLivros.Rows.Clear();
            txtTitulo.Text = "";
            txtCategoria.Text = "";
            txtCodigo.Text = "";
            txtEdicao.Text = "";
            txtEditora.Text = "";
            txtAutor.Text = "";
            txtSinopse.Text = "";
            txtISBN.Text = "";
            txtDisponibilidade.Text = "";
            lstExemplares.Items.Clear();
            imgCapa.Image = null;
            rdbTipoEmprestimo.Checked = false;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente.ShowDialog();
            Limpar();

            if (frmCliente.Cliente != null)
            {
                lblCliente.Text = "Cliente: " + frmCliente.Cliente.Nome;
                if (frmCliente.Cliente.TipoBloqueio == true)
                {
                    rdbTipoEmprestimo.Checked = true;
                    rdbTipoEmprestimo.Enabled = false;
                }
            }
        }

        private void tblLivros_SelectionChanged(object sender, EventArgs e)
        {
            lstExemplares.Items.Clear();

            ListaLivro listaLivro = new ListaLivro();

            string cod = tblLivros.Rows[tblLivros.CurrentRow.Index].Cells[0].Value.ToString();

            listaLivro.ListarLivro(cod);

            string autor = "";
            string categoria = "";

            txtCodigo.Text = listaLivro.Lista[0].Codigo.ToString();
            txtTitulo.Text = listaLivro.Lista[0].Titulo;
            txtISBN.Text = listaLivro.Lista[0].ISBN;
            txtEditora.Text = listaLivro.Lista[0].Editora.Nome;
            txtSinopse.Text = listaLivro.Lista[0].Sinopse;
            txtEdicao.Text = (listaLivro.Lista[0].AnoEdicao).ToString();
            txtDisponibilidade.Text = tblLivros.Rows[tblLivros.CurrentRow.Index].Cells[6].Value.ToString();

            for (int a = 0; a < listaLivro.Lista[0].Autor.Count; a++)
            {
                autor += listaLivro.Lista[0].Autor[a].Nome + ", ";
            }

            txtAutor.Text = autor.Substring(0, autor.Length - 2);

            for (int a = 0; a < listaLivro.Lista[0].Categoria.Count; a++)
            {
                categoria += listaLivro.Lista[0].Categoria[a].Nome + ", ";
            }

            txtCategoria.Text = categoria.Substring(0, categoria.Length - 2);

            listaLivro.GerarExemplar(int.Parse(cod));

            for (int a = 0; a < listaLivro.ListaExemplar.Count; a++)
            {
                lstExemplares.Items.Add(listaLivro.ListaExemplar[a].Codigo);
            }

            if (!String.IsNullOrEmpty(listaLivro.Lista[0].Capa))
            {
                byte[] imageBytes = Convert.FromBase64String(listaLivro.Lista[0].Capa);
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    imgCapa.Image = Image.FromStream(ms, true);
                }
            }
            else
            {
                imgCapa.Image = null;
            }
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            if (tblLivros.Rows.Count == 0)
            {
                MessageBox.Show("Livro não selecionado!");
                return;
            }

            if (lstExemplares.SelectedIndex == -1)
            {
                MessageBox.Show("Exemplar não selecionado!");
                return;
            }


            if (frmCliente.Cliente != null)
            {
                if (frmCliente.Cliente.TipoBloqueio == true)
                    rdbTipoEmprestimo.Checked = true;

                ListaEmprestimo listaEmprestimo = new ListaEmprestimo();
                listaEmprestimo.ListarEmprestimosCliente(frmCliente.Cliente.Login);

                if (listaEmprestimo.ListaEmprestimosCliente.Count > 2)
                {
                    MessageBox.Show("Cliente possui 3 livros!");
                    return;
                }

                int indexExemplar = lstExemplares.SelectedIndex;

                int codExemplar = int.Parse(lstExemplares.Items[indexExemplar].ToString());

                int codLivro = int.Parse(tblLivros.Rows[tblLivros.CurrentRow.Index].Cells[0].Value.ToString());
                int codEmprestimo;

                if (rdbTipoEmprestimo.Checked)
                    codEmprestimo = 1;
                else
                    codEmprestimo = 2;

                Exemplar exemplar = new Exemplar(codExemplar);

                string titulo = txtTitulo.Text; 

                Livro livro = new Livro(codLivro, titulo);

                TipoEmprestimo tipoEmprestimo = new TipoEmprestimo(codEmprestimo);

                Mochila mochila = new Mochila(frmCliente.Cliente, livro, exemplar, tipoEmprestimo);

                for(int i = 0; i < Mochila.Count; i++)
                {
                    if (Mochila[i].Exemplar.Codigo == mochila.Exemplar.Codigo && Mochila[i].Livro.Codigo  == mochila.Livro.Codigo)
                    {
                        MessageBox.Show("Não é possível emprestar o mesmo exemplar do livro!");
                        return;
                    }
                }

                int qtLivrosCliente = listaEmprestimo.ListaEmprestimosCliente.Count;
                Contador = int.Parse(lblContador.Text.Substring(2, 1));

                int qtLivrosPodemEmprestar = 3 - qtLivrosCliente;

                if (Mochila.Count < qtLivrosPodemEmprestar)
                {
                    Mochila.Add(mochila);
                    Contador++;
                    lblContador.Text = "x " + Contador;
                }
                else
                {
                    MessageBox.Show("Limite de Emprestimos Atingido");
                }
               
                Limpar();
            }
            else
            {
                if (MessageBox.Show("Cliente não identificado, deseja procurar?", "Cliente não identificado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    frmCliente.ShowDialog();
                    if (frmCliente.Cliente != null)
                    {
                        lblCliente.Text = "Cliente: " + frmCliente.Cliente.Nome;
                    }
                }
            }
        }

        private void lstExemplares_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaLivro exemplares = new ListaLivro();
            string cod = tblLivros.Rows[tblLivros.CurrentRow.Index].Cells[0].Value.ToString();

            exemplares.GerarExemplar(int.Parse(cod));

            int index = lstExemplares.SelectedIndex;

            if (index == -1) return;

            if (frmCliente.Cliente == null)
            {
                if (exemplares.ListaExemplar[index].Fixo == true)
                {
                    rdbTipoEmprestimo.Checked = true;
                    rdbTipoEmprestimo.Enabled = false;
                    return;
                }
                else
                {
                    rdbTipoEmprestimo.Checked = false;
                    rdbTipoEmprestimo.Enabled = true;
                    return;
                }
            }

            if (frmCliente.Cliente.TipoBloqueio == false)
            {
                if (exemplares.ListaExemplar[index].Fixo == true)
                {
                    rdbTipoEmprestimo.Checked = true;
                    rdbTipoEmprestimo.Enabled = false;
                }
                else
                {
                    rdbTipoEmprestimo.Checked = false;
                    rdbTipoEmprestimo.Enabled = true;
                }
            }
        }

        private void btnMochila_Click(object sender, EventArgs e)
        {
            if (frmCliente.Cliente == null)
            {
                MessageBox.Show("Cliente não identificado");
                return;
            }

            if (Mochila.Count == 0) 
            {
                MessageBox.Show("Mochila vazia");
                return;
            }
           
            frmMochila.ListaMochila = new List<Mochila>();

            frmMochila.ListaMochila = Mochila;

            frmMochila.ShowDialog();
            Limpar();

            if (frmMochila.EmprestimoFinalizado == true)
            {
                frmCliente.Cliente = null;
                Mochila.Clear();
                lblContador.Text = "x 0";
                lblCliente.Text = "Cliente:";
                Contador = 0;
            }

            if (frmMochila.EmprestimoCancelado == true)
            {
                lblContador.Text = "x 0";
                Contador = 0;
            }
        }
    }
}
