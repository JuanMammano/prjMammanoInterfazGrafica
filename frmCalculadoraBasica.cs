using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjMammanoInterfazGrafica
{
    public partial class frmIG_Caso2 : Form
    {
        public frmIG_Caso2()
        {
            InitializeComponent();
        }

        private void btnBoca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BOQUITA CAMPEON THE BIGGEST");
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            btnSumar.Enabled = true;
            btnRestar.Enabled = true;
            btnMultiplicar.Enabled = true;
            btnDividir.Enabled = true;
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            txtNumero2.Enabled = true;
            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double resultado;

            resultado = numero1 + numero2;
            txtResultado.Text = resultado.ToString();


            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero2.Enabled = false;
            txtNumero1.Focus();

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double resultado;

            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString();


            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero2.Enabled = false;
            txtNumero1.Focus();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double resultado;

            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString();


            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero2.Enabled = false;
            txtNumero1.Focus();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double resultado;

            resultado = numero1 / numero2;
            txtResultado.Text = resultado.ToString();


            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero2.Enabled = false;
            txtNumero1.Focus();
        }
    }
}
