namespace prjMammanoInterfazGrafica
{
    partial class frmIG_Caso7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIG_Caso7));
            lblSisDVen = new Label();
            lblProducto = new Label();
            lblPrecio = new Label();
            lblCant = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            txtCant = new TextBox();
            btnAgregar = new Button();
            lstProductos = new ListBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // lblSisDVen
            // 
            lblSisDVen.AutoSize = true;
            lblSisDVen.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblSisDVen.ForeColor = Color.Red;
            lblSisDVen.Location = new Point(179, 25);
            lblSisDVen.Name = "lblSisDVen";
            lblSisDVen.Size = new Size(192, 25);
            lblSisDVen.TabIndex = 0;
            lblSisDVen.Text = "SISTEMA DE VENTAS";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblProducto.ForeColor = Color.Red;
            lblProducto.Location = new Point(64, 58);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(90, 25);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.Red;
            lblPrecio.Location = new Point(65, 92);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(65, 25);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblCant.ForeColor = Color.Red;
            lblCant.Location = new Point(65, 125);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(89, 25);
            lblCant.TabIndex = 5;
            lblCant.Text = "Cantidad";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(179, 58);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(185, 23);
            txtProducto.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(179, 94);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 4;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(179, 127);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(54, 23);
            txtCant.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(179, 171);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 40);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.Location = new Point(65, 253);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(359, 94);
            lstProductos.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(245, 372);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(48, 17);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(306, 369);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 10;
            // 
            // frmIG_Caso7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(504, 404);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(lstProductos);
            Controls.Add(btnAgregar);
            Controls.Add(txtCant);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(lblCant);
            Controls.Add(lblPrecio);
            Controls.Add(lblProducto);
            Controls.Add(lblSisDVen);
            Name = "frmIG_Caso7";
            Text = "Sistema de Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSisDVen;
        private Label lblProducto;
        private Label lblPrecio;
        private Label lblCant;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private TextBox txtCant;
        private Button btnAgregar;
        private ListBox lstProductos;
        private Label lblTotal;
        private TextBox txtTotal;
    }
}