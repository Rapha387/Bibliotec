namespace Bibliotec
{
    partial class frmLivros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivros));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.txtDisponibilidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstExemplares = new System.Windows.Forms.ListBox();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.rdbTipoEmprestimo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSinopse = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.tblLivros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarLivro = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnMochila = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.imgCapa = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(570, 35);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(71, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestar.Location = new System.Drawing.Point(791, 319);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(136, 23);
            this.btnEmprestar.TabIndex = 24;
            this.btnEmprestar.Text = "Adicionar na Mochila";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // txtDisponibilidade
            // 
            this.txtDisponibilidade.Location = new System.Drawing.Point(636, 32);
            this.txtDisponibilidade.Name = "txtDisponibilidade";
            this.txtDisponibilidade.ReadOnly = true;
            this.txtDisponibilidade.Size = new System.Drawing.Size(139, 20);
            this.txtDisponibilidade.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(633, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Disponibilidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(302, 135);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(139, 20);
            this.txtCodigo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(788, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Exemplares:";
            // 
            // lstExemplares
            // 
            this.lstExemplares.FormattingEnabled = true;
            this.lstExemplares.Location = new System.Drawing.Point(791, 35);
            this.lstExemplares.Name = "lstExemplares";
            this.lstExemplares.Size = new System.Drawing.Size(136, 277);
            this.lstExemplares.TabIndex = 18;
            this.lstExemplares.SelectedIndexChanged += new System.EventHandler(this.lstExemplares_SelectedIndexChanged);
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.rdbTipoEmprestimo);
            this.grbDados.Controls.Add(this.btnEmprestar);
            this.grbDados.Controls.Add(this.txtDisponibilidade);
            this.grbDados.Controls.Add(this.label10);
            this.grbDados.Controls.Add(this.label9);
            this.grbDados.Controls.Add(this.txtCodigo);
            this.grbDados.Controls.Add(this.label8);
            this.grbDados.Controls.Add(this.lstExemplares);
            this.grbDados.Controls.Add(this.imgCapa);
            this.grbDados.Controls.Add(this.label7);
            this.grbDados.Controls.Add(this.txtSinopse);
            this.grbDados.Controls.Add(this.label6);
            this.grbDados.Controls.Add(this.txtCategoria);
            this.grbDados.Controls.Add(this.txtAutor);
            this.grbDados.Controls.Add(this.txtISBN);
            this.grbDados.Controls.Add(this.txtEditora);
            this.grbDados.Controls.Add(this.label5);
            this.grbDados.Controls.Add(this.txtEdicao);
            this.grbDados.Controls.Add(this.label4);
            this.grbDados.Controls.Add(this.label3);
            this.grbDados.Controls.Add(this.label2);
            this.grbDados.Controls.Add(this.label1);
            this.grbDados.Controls.Add(this.txtTitulo);
            this.grbDados.Location = new System.Drawing.Point(16, 254);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(943, 361);
            this.grbDados.TabIndex = 8;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "dados";
            // 
            // rdbTipoEmprestimo
            // 
            this.rdbTipoEmprestimo.AutoSize = true;
            this.rdbTipoEmprestimo.Location = new System.Drawing.Point(302, 324);
            this.rdbTipoEmprestimo.Name = "rdbTipoEmprestimo";
            this.rdbTipoEmprestimo.Size = new System.Drawing.Size(67, 17);
            this.rdbTipoEmprestimo.TabIndex = 26;
            this.rdbTipoEmprestimo.Text = "Consulta";
            this.rdbTipoEmprestimo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sinopse:";
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(302, 194);
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.ReadOnly = true;
            this.txtSinopse.Size = new System.Drawing.Size(473, 118);
            this.txtSinopse.TabIndex = 15;
            this.txtSinopse.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(636, 135);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(139, 20);
            this.txtCategoria.TabIndex = 13;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(466, 135);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(139, 20);
            this.txtAutor.TabIndex = 12;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(302, 84);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(139, 20);
            this.txtISBN.TabIndex = 11;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(466, 84);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.ReadOnly = true;
            this.txtEditora.Size = new System.Drawing.Size(139, 20);
            this.txtEditora.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Autor:";
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(636, 84);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.ReadOnly = true;
            this.txtEdicao.Size = new System.Drawing.Size(139, 20);
            this.txtEdicao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano da Edição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Editora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(303, 32);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(302, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // tblLivros
            // 
            this.tblLivros.AllowUserToAddRows = false;
            this.tblLivros.AllowUserToDeleteRows = false;
            this.tblLivros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.tblLivros.Location = new System.Drawing.Point(12, 83);
            this.tblLivros.MultiSelect = false;
            this.tblLivros.Name = "tblLivros";
            this.tblLivros.ReadOnly = true;
            this.tblLivros.RowHeadersVisible = false;
            this.tblLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblLivros.Size = new System.Drawing.Size(947, 150);
            this.tblLivros.TabIndex = 7;
            this.tblLivros.SelectionChanged += new System.EventHandler(this.tblLivros_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "ISBN";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 57;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Titulo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Editora";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 65;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Autor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 57;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Categoria";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 77;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Disponibilidade";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 103;
            // 
            // txtBuscarLivro
            // 
            this.txtBuscarLivro.Location = new System.Drawing.Point(10, 37);
            this.txtBuscarLivro.Name = "txtBuscarLivro";
            this.txtBuscarLivro.Size = new System.Drawing.Size(477, 20);
            this.txtBuscarLivro.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(662, 29);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(177, 34);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Código / ISBN / Nome:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(938, 41);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(21, 13);
            this.lblContador.TabIndex = 14;
            this.lblContador.Text = "x 0";
            // 
            // btnMochila
            // 
            this.btnMochila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMochila.BackgroundImage")));
            this.btnMochila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMochila.Location = new System.Drawing.Point(896, 29);
            this.btnMochila.Name = "btnMochila";
            this.btnMochila.Size = new System.Drawing.Size(36, 34);
            this.btnMochila.TabIndex = 11;
            this.btnMochila.UseVisualStyleBackColor = true;
            this.btnMochila.Click += new System.EventHandler(this.btnMochila_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.Location = new System.Drawing.Point(854, 29);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(36, 34);
            this.btnCliente.TabIndex = 10;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // imgCapa
            // 
            this.imgCapa.Location = new System.Drawing.Point(22, 32);
            this.imgCapa.Name = "imgCapa";
            this.imgCapa.Size = new System.Drawing.Size(248, 309);
            this.imgCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapa.TabIndex = 17;
            this.imgCapa.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Bibliotec.Properties.Resources.lupa;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(493, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 628);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnMochila);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.tblLivros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.frmLivros_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.TextBox txtDisponibilidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstExemplares;
        private System.Windows.Forms.PictureBox imgCapa;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtSinopse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DataGridView tblLivros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarLivro;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnMochila;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.CheckBox rdbTipoEmprestimo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblContador;
    }
}

