namespace prjMammanoInterfazGrafica
{
    partial class frmIG_Caso9
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
            lblGesFarmacia = new Label();
            lblMedicamento = new Label();
            lblLaboratorio = new Label();
            lblCodigo = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            txtMedicamento = new TextBox();
            txtLaboratorio = new TextBox();
            txtCodigo = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            lblTipo = new Label();
            cbTipo = new ComboBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            lstMedicamentos = new ListBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // lblGesFarmacia
            // 
            lblGesFarmacia.AutoSize = true;
            lblGesFarmacia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGesFarmacia.Location = new Point(132, 9);
            lblGesFarmacia.Name = "lblGesFarmacia";
            lblGesFarmacia.Size = new Size(183, 21);
            lblGesFarmacia.TabIndex = 0;
            lblGesFarmacia.Text = "GESTION DE FARMACIA";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMedicamento.Location = new Point(27, 52);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(84, 15);
            lblMedicamento.TabIndex = 1;
            lblMedicamento.Text = "Medicamento:";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLaboratorio.Location = new Point(27, 81);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(71, 15);
            lblLaboratorio.TabIndex = 3;
            lblLaboratorio.Text = "Laboratorio:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCodigo.Location = new Point(27, 110);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(48, 15);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "Codigo:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(27, 139);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStock.Location = new Point(27, 168);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(40, 15);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock:";
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(118, 44);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(192, 23);
            txtMedicamento.TabIndex = 2;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(118, 73);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(167, 23);
            txtLaboratorio.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(118, 102);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(167, 23);
            txtCodigo.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(118, 131);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(133, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(118, 160);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(133, 23);
            txtStock.TabIndex = 10;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTipo.Location = new Point(27, 192);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 11;
            lblTipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Venta Libre", "Bajo Receta", "Obra social" });
            cbTipo.Location = new Point(118, 189);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 12;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(50, 244);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 38);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(160, 244);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(85, 38);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(273, 244);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 38);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lstMedicamentos
            // 
            lstMedicamentos.FormattingEnabled = true;
            lstMedicamentos.Location = new Point(27, 302);
            lstMedicamentos.Name = "lstMedicamentos";
            lstMedicamentos.Size = new Size(359, 109);
            lstMedicamentos.TabIndex = 16;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(132, 426);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(130, 41);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "BUSCAR MEDICAMENTO";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmIG_Caso9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(438, 479);
            Controls.Add(btnBuscar);
            Controls.Add(lstMedicamentos);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(cbTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtCodigo);
            Controls.Add(txtLaboratorio);
            Controls.Add(txtMedicamento);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblCodigo);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblMedicamento);
            Controls.Add(lblGesFarmacia);
            Name = "frmIG_Caso9";
            Text = "Farmacia y Medicamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGesFarmacia;
        private Label lblMedicamento;
        private Label lblLaboratorio;
        private Label lblCodigo;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtMedicamento;
        private TextBox txtLaboratorio;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label lblTipo;
        private ComboBox cbTipo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private ListBox lstMedicamentos;
        private Button btnBuscar;
    }
}