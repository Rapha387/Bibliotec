namespace Bibliotec
{
    partial class frmOcorrenciasCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblOcorrencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDsOcorrencia = new System.Windows.Forms.RichTextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDtEmprestimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExemplar = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoLivro = new System.Windows.Forms.TextBox();
            this.txtDtDevolucao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkTipoOcorrencia = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblOcorrencias)).BeginInit();
            this.SuspendLayout();
            // 
            // tblOcorrencias
            // 
            this.tblOcorrencias.AllowUserToAddRows = false;
            this.tblOcorrencias.AllowUserToDeleteRows = false;
            this.tblOcorrencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOcorrencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.tblOcorrencias.Location = new System.Drawing.Point(16, 88);
            this.tblOcorrencias.MultiSelect = false;
            this.tblOcorrencias.Name = "tblOcorrencias";
            this.tblOcorrencias.ReadOnly = true;
            this.tblOcorrencias.RowHeadersVisible = false;
            this.tblOcorrencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblOcorrencias.Size = new System.Drawing.Size(352, 74);
            this.tblOcorrencias.TabIndex = 0;
            this.tblOcorrencias.SelectionChanged += new System.EventHandler(this.tblOcorrencias_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ocorrências";
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(16, 38);
            this.txtRM.Name = "txtRM";
            this.txtRM.ReadOnly = true;
            this.txtRM.Size = new System.Drawing.Size(74, 20);
            this.txtRM.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // txtDsOcorrencia
            // 
            this.txtDsOcorrencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDsOcorrencia.Location = new System.Drawing.Point(16, 298);
            this.txtDsOcorrencia.Name = "txtDsOcorrencia";
            this.txtDsOcorrencia.ReadOnly = true;
            this.txtDsOcorrencia.Size = new System.Drawing.Size(352, 85);
            this.txtDsOcorrencia.TabIndex = 6;
            this.txtDsOcorrencia.Text = "";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(293, 389);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Livro:";
            // 
            // txtDtEmprestimo
            // 
            this.txtDtEmprestimo.Location = new System.Drawing.Point(80, 244);
            this.txtDtEmprestimo.Name = "txtDtEmprestimo";
            this.txtDtEmprestimo.ReadOnly = true;
            this.txtDtEmprestimo.Size = new System.Drawing.Size(96, 20);
            this.txtDtEmprestimo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Título:";
            // 
            // txtExemplar
            // 
            this.txtExemplar.Location = new System.Drawing.Point(16, 244);
            this.txtExemplar.Name = "txtExemplar";
            this.txtExemplar.ReadOnly = true;
            this.txtExemplar.Size = new System.Drawing.Size(58, 20);
            this.txtExemplar.TabIndex = 11;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(80, 193);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(288, 20);
            this.txtTitulo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Exemplar:";
            // 
            // txtCodigoLivro
            // 
            this.txtCodigoLivro.Location = new System.Drawing.Point(16, 193);
            this.txtCodigoLivro.Name = "txtCodigoLivro";
            this.txtCodigoLivro.ReadOnly = true;
            this.txtCodigoLivro.Size = new System.Drawing.Size(58, 20);
            this.txtCodigoLivro.TabIndex = 15;
            // 
            // txtDtDevolucao
            // 
            this.txtDtDevolucao.Location = new System.Drawing.Point(182, 244);
            this.txtDtDevolucao.Name = "txtDtDevolucao";
            this.txtDtDevolucao.ReadOnly = true;
            this.txtDtDevolucao.Size = new System.Drawing.Size(96, 20);
            this.txtDtDevolucao.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Empréstimo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Devolução:";
            // 
            // chkTipoOcorrencia
            // 
            this.chkTipoOcorrencia.AutoSize = true;
            this.chkTipoOcorrencia.Enabled = false;
            this.chkTipoOcorrencia.Location = new System.Drawing.Point(284, 246);
            this.chkTipoOcorrencia.Name = "chkTipoOcorrencia";
            this.chkTipoOcorrencia.Size = new System.Drawing.Size(84, 17);
            this.chkTipoOcorrencia.TabIndex = 19;
            this.chkTipoOcorrencia.Text = "Dano Grave";
            this.chkTipoOcorrencia.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tipo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Descrição da ocorrência:";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Livro";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 55;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Título";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Exemplar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Empréstimo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 86;
            // 
            // frmOcorrenciasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 424);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkTipoOcorrencia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDtDevolucao);
            this.Controls.Add(this.txtCodigoLivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtExemplar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDtEmprestimo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtDsOcorrencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblOcorrencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOcorrenciasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocorrências Cliente";
            this.Load += new System.EventHandler(this.frmOcorrenciasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblOcorrencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblOcorrencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDsOcorrencia;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDtEmprestimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExemplar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoLivro;
        private System.Windows.Forms.TextBox txtDtDevolucao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkTipoOcorrencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}