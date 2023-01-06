namespace Bibliotec
{
    partial class frmCliente
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tblCliente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtDataBloqueio = new System.Windows.Forms.TextBox();
            this.txtDesbloqueio = new System.Windows.Forms.TextBox();
            this.txtTipoCliente = new System.Windows.Forms.TextBox();
            this.txtOcorrencias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tblEmprestimos = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSituacao = new System.Windows.Forms.CheckBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnOcorrencias = new System.Windows.Forms.Button();
            this.btnIdentificarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(13, 31);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(395, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(497, 29);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(65, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tblCliente
            // 
            this.tblCliente.AllowUserToAddRows = false;
            this.tblCliente.AllowUserToDeleteRows = false;
            this.tblCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.tblCliente.Location = new System.Drawing.Point(11, 75);
            this.tblCliente.MultiSelect = false;
            this.tblCliente.Name = "tblCliente";
            this.tblCliente.ReadOnly = true;
            this.tblCliente.RowHeadersVisible = false;
            this.tblCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.tblCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCliente.Size = new System.Drawing.Size(551, 150);
            this.tblCliente.TabIndex = 3;
            this.tblCliente.SelectionChanged += new System.EventHandler(this.tblCliente_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "RM";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 49;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 53;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Bloqueado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RM/Nome:";
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(17, 256);
            this.txtRM.Name = "txtRM";
            this.txtRM.ReadOnly = true;
            this.txtRM.Size = new System.Drawing.Size(90, 20);
            this.txtRM.TabIndex = 7;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(113, 256);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(449, 20);
            this.txtNomeCliente.TabIndex = 8;
            // 
            // txtDataBloqueio
            // 
            this.txtDataBloqueio.Location = new System.Drawing.Point(113, 310);
            this.txtDataBloqueio.Name = "txtDataBloqueio";
            this.txtDataBloqueio.ReadOnly = true;
            this.txtDataBloqueio.Size = new System.Drawing.Size(90, 20);
            this.txtDataBloqueio.TabIndex = 10;
            // 
            // txtDesbloqueio
            // 
            this.txtDesbloqueio.Location = new System.Drawing.Point(208, 310);
            this.txtDesbloqueio.Name = "txtDesbloqueio";
            this.txtDesbloqueio.ReadOnly = true;
            this.txtDesbloqueio.Size = new System.Drawing.Size(90, 20);
            this.txtDesbloqueio.TabIndex = 11;
            // 
            // txtTipoCliente
            // 
            this.txtTipoCliente.Location = new System.Drawing.Point(304, 310);
            this.txtTipoCliente.Name = "txtTipoCliente";
            this.txtTipoCliente.ReadOnly = true;
            this.txtTipoCliente.Size = new System.Drawing.Size(90, 20);
            this.txtTipoCliente.TabIndex = 12;
            // 
            // txtOcorrencias
            // 
            this.txtOcorrencias.Location = new System.Drawing.Point(400, 310);
            this.txtOcorrencias.Name = "txtOcorrencias";
            this.txtOcorrencias.ReadOnly = true;
            this.txtOcorrencias.Size = new System.Drawing.Size(64, 20);
            this.txtOcorrencias.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Empréstimos Atuais:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "RM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Situação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Data de Bloqueio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Desbloqueio em:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ocorrências:";
            // 
            // tblEmprestimos
            // 
            this.tblEmprestimos.AllowUserToAddRows = false;
            this.tblEmprestimos.AllowUserToDeleteRows = false;
            this.tblEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column7});
            this.tblEmprestimos.Location = new System.Drawing.Point(11, 374);
            this.tblEmprestimos.Name = "tblEmprestimos";
            this.tblEmprestimos.ReadOnly = true;
            this.tblEmprestimos.RowHeadersVisible = false;
            this.tblEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblEmprestimos.Size = new System.Drawing.Size(551, 102);
            this.tblEmprestimos.TabIndex = 23;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Livro";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 55;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Exemplar";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 75;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Título";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Empréstimo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 86;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Previsão";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 73;
            // 
            // chkSituacao
            // 
            this.chkSituacao.AutoSize = true;
            this.chkSituacao.Enabled = false;
            this.chkSituacao.Location = new System.Drawing.Point(17, 312);
            this.chkSituacao.Name = "chkSituacao";
            this.chkSituacao.Size = new System.Drawing.Size(77, 17);
            this.chkSituacao.TabIndex = 24;
            this.chkSituacao.Text = "Bloqueado";
            this.chkSituacao.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(11, 491);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 25;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnOcorrencias
            // 
            this.btnOcorrencias.Location = new System.Drawing.Point(473, 308);
            this.btnOcorrencias.Name = "btnOcorrencias";
            this.btnOcorrencias.Size = new System.Drawing.Size(91, 23);
            this.btnOcorrencias.TabIndex = 26;
            this.btnOcorrencias.Text = "Ver ocorrências";
            this.btnOcorrencias.UseVisualStyleBackColor = true;
            this.btnOcorrencias.Click += new System.EventHandler(this.btnOcorrencias_Click);
            // 
            // btnIdentificarCliente
            // 
            this.btnIdentificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentificarCliente.Image = global::Bibliotec.Properties.Resources.verifica1;
            this.btnIdentificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdentificarCliente.Location = new System.Drawing.Point(477, 491);
            this.btnIdentificarCliente.Name = "btnIdentificarCliente";
            this.btnIdentificarCliente.Size = new System.Drawing.Size(85, 23);
            this.btnIdentificarCliente.TabIndex = 4;
            this.btnIdentificarCliente.Text = "Identificar";
            this.btnIdentificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIdentificarCliente.UseVisualStyleBackColor = true;
            this.btnIdentificarCliente.Click += new System.EventHandler(this.btnIdentificarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Image = global::Bibliotec.Properties.Resources.lupa;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(419, 29);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(72, 23);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 530);
            this.Controls.Add(this.btnOcorrencias);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.chkSituacao);
            this.Controls.Add(this.tblEmprestimos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOcorrencias);
            this.Controls.Add(this.txtTipoCliente);
            this.Controls.Add(this.txtDesbloqueio);
            this.Controls.Add(this.txtDataBloqueio);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIdentificarCliente);
            this.Controls.Add(this.tblCliente);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCliente_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tblCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView tblCliente;
        private System.Windows.Forms.Button btnIdentificarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtDataBloqueio;
        private System.Windows.Forms.TextBox txtDesbloqueio;
        private System.Windows.Forms.TextBox txtTipoCliente;
        private System.Windows.Forms.TextBox txtOcorrencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView tblEmprestimos;
        private System.Windows.Forms.CheckBox chkSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnOcorrencias;
    }
}