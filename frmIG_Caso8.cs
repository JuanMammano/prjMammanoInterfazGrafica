using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjMammanoInterfazGrafica
{
    public partial class frmIG_Caso8 : Form
    {
        public frmIG_Caso8()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tarea = "Tarea: " + txtTarea.Text;
            string prioridad = "Prioridad: " + cbPrioridad.Text;
            string fecha = "Fecha: " + dtpFecha.Text;
            string espacio = " ";


            lstTareas.Items.Add(tarea.Trim());
            lstTareas.Items.Add(prioridad.Trim());
            lstTareas.Items.Add(fecha.Trim());
            lstTareas.Items.Add(espacio.Trim());

            txtTarea.Clear();
            txtTarea.Focus();


        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {
            cbPrioridad.Enabled = true;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }

        private void cbPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpFecha.Enabled = true;
        }
    }
}
