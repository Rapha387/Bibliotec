using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotec
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void acervoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bibliotec.frmLivros form1;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(Bibliotec.frmLivros))
                {
                    filho.Focus();
                    return;
                }
            }

            form1 = new Bibliotec.frmLivros();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
