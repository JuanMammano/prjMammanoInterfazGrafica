namespace prjMammanoInterfazGrafica
{
    partial class frmIG_Caso4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIG_Caso4));
            lblRegAlum = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            rbMasc = new RadioButton();
            rbFem = new RadioButton();
            lblSexo = new Label();
            lblTurno = new Label();
            chkMañana = new CheckBox();
            chkTarde = new CheckBox();
            chkNoche = new CheckBox();
            lblCarrera = new Label();
            lsbCarrera = new ComboBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblRegAlum
            // 
            lblRegAlum.AutoSize = true;
            lblRegAlum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegAlum.Location = new Point(101, 18);
            lblRegAlum.Name = "lblRegAlum";
            lblRegAlum.Size = new Size(185, 21);
            lblRegAlum.TabIndex = 0;
            lblRegAlum.Text = "REGISTRO DE ALUMNO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.Red;
            lblNombre.Location = new Point(61, 111);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 13);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblApellido.ForeColor = Color.Red;
            lblApellido.Location = new Point(61, 143);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 13);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblDni.ForeColor = Color.Red;
            lblDni.Location = new Point(61, 175);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(29, 13);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(139, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(147, 141);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(139, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(147, 173);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(139, 23);
            txtDni.TabIndex = 6;
            // 
            // rbMasc
            // 
            rbMasc.AutoSize = true;
            rbMasc.Location = new Point(147, 223);
            rbMasc.Name = "rbMasc";
            rbMasc.Size = new Size(80, 19);
            rbMasc.TabIndex = 7;
            rbMasc.TabStop = true;
            rbMasc.Text = "Masculino";
            rbMasc.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            rbFem.AutoSize = true;
            rbFem.Location = new Point(250, 223);
            rbFem.Name = "rbFem";
            rbFem.Size = new Size(78, 19);
            rbFem.TabIndex = 8;
            rbFem.TabStop = true;
            rbFem.Text = "Femenino";
            rbFem.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.Transparent;
            lblSexo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblSexo.ForeColor = Color.Red;
            lblSexo.Location = new Point(61, 225);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 13);
            lblSexo.TabIndex = 9;
            lblSexo.Text = "Sexo";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.BackColor = Color.Transparent;
            lblTurno.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblTurno.ForeColor = Color.Red;
            lblTurno.Location = new Point(61, 271);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(40, 13);
            lblTurno.TabIndex = 10;
            lblTurno.Text = "Turno";
            // 
            // chkMañana
            // 
            chkMañana.AutoSize = true;
            chkMañana.Location = new Point(129, 271);
            chkMañana.Name = "chkMañana";
            chkMañana.Size = new Size(69, 19);
            chkMañana.TabIndex = 11;
            chkMañana.Text = "Mañana";
            chkMañana.UseVisualStyleBackColor = true;
            // 
            // chkTarde
            // 
            chkTarde.AutoSize = true;
            chkTarde.Location = new Point(231, 271);
            chkTarde.Name = "chkTarde";
            chkTarde.Size = new Size(55, 19);
            chkTarde.TabIndex = 12;
            chkTarde.Text = "Tarde";
            chkTarde.UseVisualStyleBackColor = true;
            // 
            // chkNoche
            // 
            chkNoche.AutoSize = true;
            chkNoche.Location = new Point(313, 271);
            chkNoche.Name = "chkNoche";
            chkNoche.Size = new Size(61, 19);
            chkNoche.TabIndex = 13;
            chkNoche.Text = "Noche";
            chkNoche.UseVisualStyleBackColor = true;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.Transparent;
            lblCarrera.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblCarrera.ForeColor = Color.Red;
            lblCarrera.Location = new Point(61, 315);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(52, 13);
            lblCarrera.TabIndex = 14;
            lblCarrera.Text = "Carerra:";
            // 
            // lsbCarrera
            // 
            lsbCarrera.FormattingEnabled = true;
            lsbCarrera.Items.AddRange(new object[] { "Programacion", "Matematicas", "Maistro Jardinero", "Filosofo" });
            lsbCarrera.Location = new Point(129, 312);
            lsbCarrera.Name = "lsbCarrera";
            lsbCarrera.Size = new Size(157, 23);
            lsbCarrera.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(165, 353);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(104, 35);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // frmIG_Caso4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(431, 403);
            Controls.Add(btnRegistrar);
            Controls.Add(lsbCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(chkNoche);
            Controls.Add(chkTarde);
            Controls.Add(chkMañana);
            Controls.Add(lblTurno);
            Controls.Add(lblSexo);
            Controls.Add(rbFem);
            Controls.Add(rbMasc);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblRegAlum);
            Name = "frmIG_Caso4";
            Text = "Registro de Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegAlum;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private RadioButton rbMasc;
        private RadioButton rbFem;
        private Label lblSexo;
        private Label lblTurno;
        private CheckBox chkMañana;
        private CheckBox chkTarde;
        private CheckBox chkNoche;
        private Label lblCarrera;
        private ComboBox lsbCarrera;
        private Button btnRegistrar;
    }
}