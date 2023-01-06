namespace Bibliotec
{
    partial class frmRelatarOcorrencia
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
            this.txtOcorrencia = new System.Windows.Forms.RichTextBox();
            this.btnRelatarOcorrencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDanoGrave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtOcorrencia
            // 
            this.txtOcorrencia.Location = new System.Drawing.Point(12, 35);
            this.txtOcorrencia.Name = "txtOcorrencia";
            this.txtOcorrencia.Size = new System.Drawing.Size(344, 110);
            this.txtOcorrencia.TabIndex = 0;
            this.txtOcorrencia.Text = "";
            // 
            // btnRelatarOcorrencia
            // 
            this.btnRelatarOcorrencia.Location = new System.Drawing.Point(243, 151);
            this.btnRelatarOcorrencia.Name = "btnRelatarOcorrencia";
            this.btnRelatarOcorrencia.Size = new System.Drawing.Size(113, 21);
            this.btnRelatarOcorrencia.TabIndex = 1;
            this.btnRelatarOcorrencia.Text = "Relatar Ocorrência";
            this.btnRelatarOcorrencia.UseVisualStyleBackColor = true;
            this.btnRelatarOcorrencia.Click += new System.EventHandler(this.btnRelatarOcorrencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ocorrência:";
            // 
            // chkDanoGrave
            // 
            this.chkDanoGrave.AutoSize = true;
            this.chkDanoGrave.Location = new System.Drawing.Point(12, 154);
            this.chkDanoGrave.Name = "chkDanoGrave";
            this.chkDanoGrave.Size = new System.Drawing.Size(82, 17);
            this.chkDanoGrave.TabIndex = 3;
            this.chkDanoGrave.Text = "Dano grave";
            this.chkDanoGrave.UseVisualStyleBackColor = true;
            // 
            // frmRelatarOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 185);
            this.Controls.Add(this.chkDanoGrave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelatarOcorrencia);
            this.Controls.Add(this.txtOcorrencia);
            this.Name = "frmRelatarOcorrencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocorrênica";
            this.Load += new System.EventHandler(this.frmOcorrencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOcorrencia;
        private System.Windows.Forms.Button btnRelatarOcorrencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDanoGrave;
    }
}