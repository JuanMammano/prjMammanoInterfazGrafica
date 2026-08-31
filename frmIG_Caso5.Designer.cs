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
            lblIniSes.Font = new Font("Poor Richard", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIniSes.Location = new Point(61, 18);
            lblIniSes.Name = "lblIniSes";
            lblIniSes.Size = new Size(154, 22);
            lblIniSes.TabIndex = 0;
            lblIniSes.Text = "INICIO DE SESION";
            // 
            // lblUsu
            // 
            lblUsu.AutoSize = true;
            lblUsu.Font = new Font("Palatino Linotype", 9F);
            lblUsu.Location = new Point(23, 55);
            lblUsu.Name = "lblUsu";
            lblUsu.Size = new Size(52, 17);
            lblUsu.TabIndex = 1;
            lblUsu.Text = "Usuario";
            // 
            // lblCla
            // 
            lblCla.AutoSize = true;
            lblCla.Font = new Font("Palatino Linotype", 9F);
            lblCla.Location = new Point(23, 98);
            lblCla.Name = "lblCla";
            lblCla.Size = new Size(41, 17);
            lblCla.TabIndex = 3;
            lblCla.Text = "Clave";
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(92, 52);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(123, 23);
            txtUsu.TabIndex = 2;
            txtUsu.TextChanged += txtUsu_TextChanged;
            // 
            // txtCla
            // 
            txtCla.Enabled = false;
            txtCla.Location = new Point(92, 95);
            txtCla.Name = "txtCla";
            txtCla.Size = new Size(123, 23);
            txtCla.TabIndex = 4;
            txtCla.TextChanged += txtCla_TextChanged;
            // 
            // btnIng
            // 
            btnIng.Enabled = false;
            btnIng.Location = new Point(92, 144);
            btnIng.Name = "btnIng";
            btnIng.Size = new Size(75, 23);
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
            lblInc.Location = new Point(39, 186);
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
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(279, 239);
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