namespace prjMammanoInterfazGrafica
{
    partial class frmIG_Caso1
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
            lblPresentacion = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            lblCarrera = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtCarrera = new TextBox();
            btnPresentar = new Button();
            SuspendLayout();
            // 
            // lblPresentacion
            // 
            lblPresentacion.AutoSize = true;
            lblPresentacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPresentacion.Location = new Point(87, 18);
            lblPresentacion.Name = "lblPresentacion";
            lblPresentacion.Size = new Size(153, 21);
            lblPresentacion.TabIndex = 0;
            lblPresentacion.Text = "MI PRESENTACION";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(42, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.Location = new Point(42, 94);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEdad.Location = new Point(42, 125);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCarrera.Location = new Point(42, 156);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(48, 15);
            lblCarrera.TabIndex = 4;
            lblCarrera.Text = "Carrera";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(121, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(121, 123);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 7;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(121, 155);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(100, 23);
            txtCarrera.TabIndex = 8;
            // 
            // btnPresentar
            // 
            btnPresentar.Location = new Point(98, 202);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(97, 39);
            btnPresentar.TabIndex = 9;
            btnPresentar.Text = "PRESENTAR";
            btnPresentar.UseVisualStyleBackColor = true;
            // 
            // frmIG_Caso1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(303, 269);
            Controls.Add(btnPresentar);
            Controls.Add(txtCarrera);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblPresentacion);
            Name = "frmIG_Caso1";
            Text = "Presentacion Personal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPresentacion;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblCarrera;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtCarrera;
        private Button btnPresentar;
    }
}