using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjMammanoInterfazGrafica
{
    public partial class frmIG_Caso7 : Form
    {
        public frmIG_Caso7()
        {
            InitializeComponent();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.Enabled = true;
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtCant.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        
    }
}
