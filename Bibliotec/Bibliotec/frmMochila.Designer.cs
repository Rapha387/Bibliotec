namespace Bibliotec
{
    partial class frmMochila
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
            this.tblMochila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnFinalizarEmprestimo = new System.Windows.Forms.Button();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarEmprestimo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblMochila)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMochila
            // 
            this.tblMochila.AllowUserToAddRows = false;
            this.tblMochila.AllowUserToDeleteRows = false;
            this.tblMochila.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblMochila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMochila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.tblMochila.Location = new System.Drawing.Point(12, 77);
            this.tblMochila.MultiSelect = false;
            this.tblMochila.Name = "tblMochila";
            this.tblMochila.ReadOnly = true;
            this.tblMochila.RowHeadersVisible = false;
            this.tblMochila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblMochila.Size = new System.Drawing.Size(506, 119);
            this.tblMochila.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Livro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Título";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Exemplar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Consulta";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnFinalizarEmprestimo
            // 
            this.btnFinalizarEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarEmprestimo.Location = new System.Drawing.Point(416, 202);
            this.btnFinalizarEmprestimo.Name = "btnFinalizarEmprestimo";
            this.btnFinalizarEmprestimo.Size = new System.Drawing.Size(102, 23);
            this.btnFinalizarEmprestimo.TabIndex = 1;
            this.btnFinalizarEmprestimo.Text = "Finalizar";
            this.btnFinalizarEmprestimo.UseVisualStyleBackColor = true;
            this.btnFinalizarEmprestimo.Click += new System.EventHandler(this.btnFinalizarEmprestimo_Click);
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(12, 42);
            this.txtRM.Name = "txtRM";
            this.txtRM.ReadOnly = true;
            this.txtRM.Size = new System.Drawing.Size(89, 20);
            this.txtRM.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(107, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(411, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // btnCancelarEmprestimo
            // 
            this.btnCancelarEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEmprestimo.Location = new System.Drawing.Point(12, 202);
            this.btnCancelarEmprestimo.Name = "btnCancelarEmprestimo";
            this.btnCancelarEmprestimo.Size = new System.Drawing.Size(141, 23);
            this.btnCancelarEmprestimo.TabIndex = 6;
            this.btnCancelarEmprestimo.Text = "Cancelar Emprestimo";
            this.btnCancelarEmprestimo.UseVisualStyleBackColor = true;
            this.btnCancelarEmprestimo.Click += new System.EventHandler(this.btnCancelarEmprestimo_Click);
            // 
            // frmMochila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 240);
            this.Controls.Add(this.btnCancelarEmprestimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.btnFinalizarEmprestimo);
            this.Controls.Add(this.tblMochila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMochila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mochila";
            this.Load += new System.EventHandler(this.frmMochila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMochila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblMochila;
        private System.Windows.Forms.Button btnFinalizarEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarEmprestimo;
    }
}