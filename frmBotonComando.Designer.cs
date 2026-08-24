namespace prjMammanoInterfazGrafica
{
    partial class frmPrimerProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimerProyecto));
            txtApellido = new TextBox();
            txtCarrera = new TextBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblCarrera = new Label();
            lblEdad = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnPresentar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(102, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(145, 23);
            txtApellido.TabIndex = 3;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtCarrera
            // 
            txtCarrera.Enabled = false;
            txtCarrera.Location = new Point(102, 171);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(145, 23);
            txtCarrera.TabIndex = 7;
            txtCarrera.TextChanged += txtCarrera_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(102, 124);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(52, 23);
            txtEdad.TabIndex = 5;
            txtEdad.TextChanged += txtEdad_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.Transparent;
            lblCarrera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblCarrera.ForeColor = Color.Red;
            lblCarrera.Location = new Point(31, 172);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(52, 17);
            lblCarrera.TabIndex = 6;
            lblCarrera.Text = "Carrera";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.Transparent;
            lblEdad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblEdad.ForeColor = Color.Red;
            lblEdad.Location = new Point(31, 125);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(38, 17);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblApellido.ForeColor = Color.Red;
            lblApellido.Location = new Point(31, 78);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNombre.ForeColor = Color.Red;
            lblNombre.Location = new Point(31, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnPresentar
            // 
            btnPresentar.BackColor = SystemColors.ActiveCaption;
            btnPresentar.Enabled = false;
            btnPresentar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPresentar.ForeColor = SystemColors.ControlText;
            btnPresentar.Location = new Point(102, 211);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(116, 34);
            btnPresentar.TabIndex = 8;
            btnPresentar.Text = "PRESENTAR";
            btnPresentar.UseVisualStyleBackColor = false;
            btnPresentar.Click += btnPresentar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(0, 249);
            lblMensaje.MaximumSize = new Size(312, 100);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 21);
            lblMensaje.TabIndex = 9;
            // 
            // frmPrimerProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(329, 307);
            Controls.Add(lblMensaje);
            Controls.Add(btnPresentar);
            Controls.Add(txtApellido);
            Controls.Add(txtCarrera);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrimerProyecto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primer Proyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellido;
        private TextBox txtCarrera;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblCarrera;
        private Label lblEdad;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnPresentar;
        private Label lblMensaje;
    }
}