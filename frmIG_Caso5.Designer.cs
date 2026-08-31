namespace prjMammanoInterfazGrafica
{
    partial class frmIG_Caso5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIG_Caso5));
            lblIniSes = new Label();
            lblUsu = new Label();
            lblCla = new Label();
            txtUsu = new TextBox();
            txtCla = new TextBox();
            btnIng = new Button();
            lblInc = new Label();
            SuspendLayout();
            // 
            // lblIniSes
            // 
            lblIniSes.AutoSize = true;
            lblIniSes.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIniSes.Location = new Point(89, 23);
            lblIniSes.Name = "lblIniSes";
            lblIniSes.Size = new Size(170, 24);
            lblIniSes.TabIndex = 0;
            lblIniSes.Text = "INICIO DE SESION";
            // 
            // lblUsu
            // 
            lblUsu.AutoSize = true;
            lblUsu.Font = new Font("Palatino Linotype", 9F);
            lblUsu.Location = new Point(58, 92);
            lblUsu.Name = "lblUsu";
            lblUsu.Size = new Size(52, 17);
            lblUsu.TabIndex = 1;
            lblUsu.Text = "Usuario";
            // 
            // lblCla
            // 
            lblCla.AutoSize = true;
            lblCla.Font = new Font("Palatino Linotype", 9F);
            lblCla.Location = new Point(58, 135);
            lblCla.Name = "lblCla";
            lblCla.Size = new Size(41, 17);
            lblCla.TabIndex = 3;
            lblCla.Text = "Clave";
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(127, 89);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(123, 23);
            txtUsu.TabIndex = 2;
            txtUsu.TextChanged += txtUsu_TextChanged;
            // 
            // txtCla
            // 
            txtCla.Enabled = false;
            txtCla.Location = new Point(127, 132);
            txtCla.Name = "txtCla";
            txtCla.Size = new Size(123, 23);
            txtCla.TabIndex = 4;
            txtCla.TextChanged += txtCla_TextChanged;
            // 
            // btnIng
            // 
            btnIng.Enabled = false;
            btnIng.Location = new Point(127, 175);
            btnIng.Name = "btnIng";
            btnIng.Size = new Size(90, 39);
            btnIng.TabIndex = 5;
            btnIng.Text = "INGRESAR";
            btnIng.UseVisualStyleBackColor = true;
            btnIng.Click += btnIng_Click;
            // 
            // lblInc
            // 
            lblInc.AutoSize = true;
            lblInc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInc.ForeColor = Color.Red;
            lblInc.Location = new Point(72, 256);
            lblInc.Name = "lblInc";
            lblInc.Size = new Size(210, 17);
            lblInc.TabIndex = 6;
            lblInc.Text = "Usuario o Contraseña incorrectos";
            lblInc.Visible = false;
            // 
            // frmIG_Caso5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(375, 355);
            Controls.Add(lblInc);
            Controls.Add(btnIng);
            Controls.Add(txtCla);
            Controls.Add(txtUsu);
            Controls.Add(lblCla);
            Controls.Add(lblUsu);
            Controls.Add(lblIniSes);
            DoubleBuffered = true;
            Name = "frmIG_Caso5";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIniSes;
        private Label lblUsu;
        private Label lblCla;
        private TextBox txtUsu;
        private TextBox txtCla;
        private Button btnIng;
        private Label lblInc;
    }
}