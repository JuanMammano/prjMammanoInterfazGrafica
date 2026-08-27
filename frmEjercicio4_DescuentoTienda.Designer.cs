namespace prjMammanoInterfazGrafica
{
    partial class frmEjercicio4_DescuentoTienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjercicio4_DescuentoTienda));
            lblProducto = new Label();
            txtProducto = new TextBox();
            lblMonto = new Label();
            txtMonto = new TextBox();
            lblSubtotal = new Label();
            txtSubtotal = new TextBox();
            btnRegistrar = new Button();
            lblDescuento = new Label();
            btnDescuento = new Button();
            txtDescuento = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblProducto.Location = new Point(40, 47);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(81, 26);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            lblProducto.Click += label1_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(135, 49);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(153, 23);
            txtProducto.TabIndex = 1;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblMonto.Location = new Point(40, 79);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(59, 26);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Enabled = false;
            txtMonto.Location = new Point(135, 81);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(153, 23);
            txtMonto.TabIndex = 3;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblSubtotal.Location = new Point(31, 169);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(98, 26);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "SUBTOTAL";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(135, 169);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(153, 23);
            txtSubtotal.TabIndex = 5;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Lucida Calligraphy", 9F);
            btnRegistrar.Location = new Point(151, 124);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(113, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblDescuento.Location = new Point(33, 237);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(88, 26);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "Descuento";
            // 
            // btnDescuento
            // 
            btnDescuento.Enabled = false;
            btnDescuento.Font = new Font("Lucida Calligraphy", 9F);
            btnDescuento.Location = new Point(135, 211);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(198, 23);
            btnDescuento.TabIndex = 8;
            btnDescuento.Text = "CALCULAR DESCUENTO";
            btnDescuento.UseVisualStyleBackColor = true;
            btnDescuento.Click += btnDescuento_Click;
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(135, 240);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(45, 23);
            txtDescuento.TabIndex = 9;
            txtDescuento.Text = "15";
            txtDescuento.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblTotal.Location = new Point(40, 274);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 26);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(135, 278);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(153, 23);
            txtTotal.TabIndex = 11;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Lucida Calligraphy", 9F);
            btnSalir.Location = new Point(386, 293);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 51);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Lucida Calligraphy", 9F);
            btnLimpiar.Location = new Point(323, 112);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 47);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmEjercicio4_DescuentoTienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(461, 343);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtDescuento);
            Controls.Add(btnDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(btnRegistrar);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Name = "frmEjercicio4_DescuentoTienda";
            Text = "Calculadora de descuento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private TextBox txtProducto;
        private Label lblMonto;
        private TextBox txtMonto;
        private Label lblSubtotal;
        private TextBox txtSubtotal;
        private Button btnRegistrar;
        private Label lblDescuento;
        private Button btnDescuento;
        private TextBox txtDescuento;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}