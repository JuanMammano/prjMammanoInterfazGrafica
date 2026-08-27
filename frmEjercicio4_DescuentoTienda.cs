using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjMammanoInterfazGrafica
{
    public partial class frmEjercicio4_DescuentoTienda : Form
    {
        public frmEjercicio4_DescuentoTienda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            txtMonto.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            decimal subtotalActual = string.IsNullOrEmpty(txtSubtotal.Text) ? 0 : Convert.ToDecimal(txtSubtotal.Text);
            decimal monto = string.IsNullOrEmpty(txtMonto.Text) ? 0 : Convert.ToDecimal(txtMonto.Text);

            decimal subtotal = subtotalActual + monto;
            lsvListado.Items.Add(txtProducto.Text + txtMonto.Text);

            txtSubtotal.Text = subtotal.ToString();
            txtProducto.Clear();
            txtMonto.Clear();
            txtProducto.Focus();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            decimal totalActual = string.IsNullOrEmpty(txtTotal.Text) ? 0 : Convert.ToDecimal(txtSubtotal.Text);
            decimal subtotal = string.IsNullOrEmpty(txtSubtotal.Text) ? 0 : Convert.ToDecimal(txtSubtotal.Text);
            decimal descuento = string.IsNullOrEmpty(txtDescuento.Text) ? 0 : Convert.ToDecimal(txtDescuento.Text);

            decimal total = subtotal - (descuento * subtotal) / 100;
            txtTotal.Text = total.ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Text = "";
            txtProducto.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
            txtProducto.Focus();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = true;
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            btnDescuento.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            lsvListado.Visible = true;
        }
    }
}
