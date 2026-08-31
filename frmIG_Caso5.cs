using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjMammanoInterfazGrafica
{
    public partial class frmIG_Caso5 : Form
    {
        public frmIG_Caso5()
        {
            InitializeComponent();
        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {
            txtCla.Enabled = true;
        }

        private void txtCla_TextChanged(object sender, EventArgs e)
        {
            btnIng.Enabled = true;
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            lblInc.Visible = true;
        }
    }
}
