namespace prjMammanoInterfazGrafica
{
    partial class frmIG_Caso8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIG_Caso8));
            lblGesTareas = new Label();
            lblTarea = new Label();
            txtTarea = new TextBox();
            lblPrioridad = new Label();
            cbPrioridad = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnAgregar = new Button();
            lstTareas = new ListBox();
            btnEliminar = new Button();
            btnCompletar = new Button();
            SuspendLayout();
            // 
            // lblGesTareas
            // 
            lblGesTareas.AutoSize = true;
            lblGesTareas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGesTareas.Location = new Point(148, 19);
            lblGesTareas.Name = "lblGesTareas";
            lblGesTareas.Size = new Size(101, 21);
            lblGesTareas.TabIndex = 0;
            lblGesTareas.Text = "MIS TAREAS";
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTarea.Location = new Point(44, 73);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(43, 17);
            lblTarea.TabIndex = 1;
            lblTarea.Text = "Tarea:";
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(106, 72);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(205, 23);
            txtTarea.TabIndex = 2;
            txtTarea.TextChanged += txtTarea_TextChanged;
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPrioridad.Location = new Point(21, 114);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(66, 17);
            lblPrioridad.TabIndex = 3;
            lblPrioridad.Text = "Prioridad:";
            // 
            // cbPrioridad
            // 
            cbPrioridad.Enabled = false;
            cbPrioridad.FormattingEnabled = true;
            cbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cbPrioridad.Location = new Point(106, 108);
            cbPrioridad.Name = "cbPrioridad";
            cbPrioridad.Size = new Size(121, 23);
            cbPrioridad.TabIndex = 4;
            cbPrioridad.SelectedIndexChanged += cbPrioridad_SelectedIndexChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblFecha.Location = new Point(41, 151);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(46, 17);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(106, 145);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(162, 23);
            dtpFecha.TabIndex = 6;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Enabled = false;
            btnAgregar.Location = new Point(130, 174);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 37);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.Location = new Point(41, 230);
            lstTareas.MultiColumn = true;
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(301, 94);
            lstTareas.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(57, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCompletar
            // 
            btnCompletar.Location = new Point(220, 330);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(94, 34);
            btnCompletar.TabIndex = 10;
            btnCompletar.Text = "COMPLETAR";
            btnCompletar.UseVisualStyleBackColor = true;
            // 
            // frmIG_Caso8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Pink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(475, 397);
            Controls.Add(btnCompletar);
            Controls.Add(btnEliminar);
            Controls.Add(lstTareas);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(cbPrioridad);
            Controls.Add(lblPrioridad);
            Controls.Add(txtTarea);
            Controls.Add(lblTarea);
            Controls.Add(lblGesTareas);
            Name = "frmIG_Caso8";
            Text = "Gestor de Tareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGesTareas;
        private Label lblTarea;
        private TextBox txtTarea;
        private Label lblPrioridad;
        private ComboBox cbPrioridad;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Button btnAgregar;
        private ListBox lstTareas;
        private Button btnEliminar;
        private Button btnCompletar;
    }
}