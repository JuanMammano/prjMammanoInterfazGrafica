namespace prjMammanoInterfazGrafica
{
    partial class frmIG_Caso6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIG_Caso6));
            lblAgenda = new Label();
            lblNombre = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            lstAgenda = new ListBox();
            SuspendLayout();
            // 
            // lblAgenda
            // 
            lblAgenda.AutoSize = true;
            lblAgenda.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgenda.Location = new Point(169, 8);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(78, 21);
            lblAgenda.TabIndex = 0;
            lblAgenda.Text = "AGENDA";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe Print", 9.75F);
            lblNombre.Location = new Point(97, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(63, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe Print", 9.75F);
            lblTelefono.Location = new Point(123, 103);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(34, 23);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Tel:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(169, 103);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9F);
            btnAgregar.Location = new Point(70, 150);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 31);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9F);
            btnEliminar.Location = new Point(219, 150);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 31);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lstAgenda
            // 
            lstAgenda.BackColor = SystemColors.MenuHighlight;
            lstAgenda.Font = new Font("MS PGothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstAgenda.FormattingEnabled = true;
            lstAgenda.Location = new Point(51, 199);
            lstAgenda.Name = "lstAgenda";
            lstAgenda.Size = new Size(311, 95);
            lstAgenda.TabIndex = 7;
            // 
            // frmIG_Caso6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(415, 350);
            Controls.Add(lstAgenda);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(lblAgenda);
            Name = "frmIG_Caso6";
            Text = "Agenda de Contactos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgenda;
        private Label lblNombre;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnEliminar;
        private ListBox lstAgenda;
    }
}