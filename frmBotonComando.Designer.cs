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
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(102, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(145, 23);
            txtApellido.TabIndex = 19;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(102, 165);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(145, 23);
            txtCarrera.TabIndex = 18;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(102, 120);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(52, 23);
            txtEdad.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 23);
            txtNombre.TabIndex = 16;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCarrera.Location = new Point(31, 172);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(48, 15);
            lblCarrera.TabIndex = 15;
            lblCarrera.Text = "Carrera";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEdad.Location = new Point(31, 125);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 14;
            lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.Location = new Point(31, 78);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 13;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(31, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // btnPresentar
            // 
            btnPresentar.BackColor = SystemColors.ActiveCaption;
            btnPresentar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPresentar.ForeColor = SystemColors.ControlText;
            btnPresentar.Location = new Point(102, 211);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(116, 34);
            btnPresentar.TabIndex = 20;
            btnPresentar.Text = "PRESENTAR";
            btnPresentar.UseVisualStyleBackColor = false;
            // 
            // frmPrimerProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(318, 273);
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
            Name = "frmPrimerProyecto";
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
    }
}