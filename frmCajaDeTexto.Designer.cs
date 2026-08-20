namespace prjMammanoInterfazGrafica
{
    partial class frmCajaDeTexto
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
            lblCarrera = new Label();
            lblEdad = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtCarrera = new TextBox();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(34, 177);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 7;
            lblCarrera.Text = "Carrera";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(34, 130);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(34, 83);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(105, 125);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(52, 23);
            txtEdad.TabIndex = 9;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(105, 170);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(145, 23);
            txtCarrera.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(105, 80);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(145, 23);
            txtApellido.TabIndex = 11;
            // 
            // frmCajaDeTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 264);
            Controls.Add(txtApellido);
            Controls.Add(txtCarrera);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmCajaDeTexto";
            Text = "frmCajaDeTexto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarrera;
        private Label lblEdad;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtCarrera;
        private TextBox txtApellido;
    }
}