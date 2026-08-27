namespace prjMammanoInterfazGrafica
{
    partial class frmIG_Caso3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIG_Caso3));
            lblValor = new Label();
            txtValor = new TextBox();
            lblConversor = new Label();
            lblDesde = new Label();
            lblHasta = new Label();
            cmoDesde = new ComboBox();
            cmoHasta = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            lblResultado1 = new Label();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(35, 52);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(108, 44);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(121, 23);
            txtValor.TabIndex = 1;
            // 
            // lblConversor
            // 
            lblConversor.AutoSize = true;
            lblConversor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConversor.Location = new Point(108, 9);
            lblConversor.Name = "lblConversor";
            lblConversor.Size = new Size(106, 21);
            lblConversor.TabIndex = 2;
            lblConversor.Text = "CONVERSOR";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(35, 145);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 3;
            lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(35, 178);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 4;
            lblHasta.Text = "Hasta:";
            // 
            // cmoDesde
            // 
            cmoDesde.FormattingEnabled = true;
            cmoDesde.Items.AddRange(new object[] { "Metros", "Centrimetros" });
            cmoDesde.Location = new Point(108, 142);
            cmoDesde.Name = "cmoDesde";
            cmoDesde.Size = new Size(121, 23);
            cmoDesde.TabIndex = 5;
            // 
            // cmoHasta
            // 
            cmoHasta.FormattingEnabled = true;
            cmoHasta.Items.AddRange(new object[] { "Metros", "Centrimetros" });
            cmoHasta.Location = new Point(108, 171);
            cmoHasta.Name = "cmoHasta";
            cmoHasta.Size = new Size(121, 23);
            cmoHasta.TabIndex = 5;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(108, 215);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(77, 46);
            btnConvertir.TabIndex = 6;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(35, 272);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.Location = new Point(108, 272);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(0, 15);
            lblResultado1.TabIndex = 8;
            // 
            // frmIG_Caso3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(322, 306);
            Controls.Add(lblResultado1);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmoHasta);
            Controls.Add(cmoDesde);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(lblConversor);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Name = "frmIG_Caso3";
            Text = "Conversor de Unidades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private TextBox txtValor;
        private Label lblConversor;
        private Label lblDesde;
        private Label lblHasta;
        private ComboBox cmoDesde;
        private ComboBox cmoHasta;
        private Button btnConvertir;
        private Label lblResultado;
        private Label lblResultado1;
    }
}