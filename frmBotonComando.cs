using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjMammanoInterfazGrafica
{
    public partial class frmPrimerProyecto : Form
    {
        public frmPrimerProyecto()
        {
            InitializeComponent();
        }

        private void btnPresentar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Mi mama me dice " + txtNombre.Text + " " + txtApellido.Text + " , tengo " + txtEdad.Text + " años y estudio " + txtCarrera.Text;
            txtNombre.Focus();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCarrera.Text = "";
            txtEdad.Text = "";
            txtApellido.Enabled = false;
            txtCarrera.Enabled = false;
            txtEdad.Enabled = false;
            btnPresentar.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtApellido.Enabled = true;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtEdad.Enabled = true;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            txtCarrera.Enabled = true;
        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {
            btnPresentar.Enabled = true;
        }
    }
}
