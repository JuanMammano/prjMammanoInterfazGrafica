namespace prjMammanoInterfazGrafica
{
    partial class frmCalculadoraBasica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraBasica));
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            lblResultado = new Label();
            txtResultado = new TextBox();
            btnBoca = new Button();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(142, 75);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(70, 17);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Numero 1:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum2.Location = new Point(142, 123);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(72, 17);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Numero 2:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(223, 72);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(223, 120);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 3;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSumar.Location = new Point(55, 164);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 4;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRestar.Location = new Point(142, 164);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(75, 23);
            btnRestar.TabIndex = 5;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnMultiplicar.Location = new Point(229, 164);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDividir.Location = new Point(316, 164);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(108, 213);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(104, 21);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "RESULTADO:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(223, 211);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 9;
            // 
            // btnBoca
            // 
            btnBoca.BackgroundImage = (Image)resources.GetObject("btnBoca.BackgroundImage");
            btnBoca.BackgroundImageLayout = ImageLayout.Stretch;
            btnBoca.Location = new Point(406, 225);
            btnBoca.Name = "btnBoca";
            btnBoca.Size = new Size(48, 41);
            btnBoca.TabIndex = 10;
            btnBoca.UseVisualStyleBackColor = true;
            // 
            // frmCalculadoraBasica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(483, 287);
            Controls.Add(btnBoca);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "frmCalculadoraBasica";
            Text = "Calculadora Basica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Label lblResultado;
        private TextBox txtResultado;
        private Button btnBoca;
    }
}