namespace Menu_Especial
{
    partial class FormPersonal
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
            btnGuardar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            txtCedula = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboPuesto = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            btnCancelarBusqueda = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(155, 353);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 98);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "José Batista";
            txtNombre.Size = new Size(227, 27);
            txtNombre.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(29, 353);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(115, 144);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "0000000000";
            txtCedula.Size = new Size(227, 27);
            txtCedula.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 144);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "Cedula";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(115, 193);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Santiago, La barranquita, calle ...";
            txtDireccion.Size = new Size(227, 27);
            txtDireccion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 193);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 238);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 8;
            label4.Text = "Puesto";
            // 
            // comboPuesto
            // 
            comboPuesto.FormattingEnabled = true;
            comboPuesto.Location = new Point(112, 238);
            comboPuesto.Name = "comboPuesto";
            comboPuesto.Size = new Size(230, 28);
            comboPuesto.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 40);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 10;
            label5.Text = "Información de Personal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(632, 40);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 15;
            label6.Text = "Buscar Personal";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(413, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 242);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(411, 90);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "José Pimentel";
            txtBuscar.Size = new Size(275, 27);
            txtBuscar.TabIndex = 13;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnCancelarBusqueda
            // 
            btnCancelarBusqueda.Location = new Point(839, 89);
            btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            btnCancelarBusqueda.Size = new Size(94, 29);
            btnCancelarBusqueda.TabIndex = 12;
            btnCancelarBusqueda.Text = "Cancelar";
            btnCancelarBusqueda.UseVisualStyleBackColor = true;
            btnCancelarBusqueda.Click += btnCancelarBusqueda_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(724, 89);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(273, 355);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FormPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 450);
            Controls.Add(btnModificar);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(btnCancelarBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(label5);
            Controls.Add(comboPuesto);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtCedula);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Name = "FormPersonal";
            Text = "FormPersonal";
            Load += FormPersonal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label1;
        private TextBox txtNombre;
        private Button btnCancelar;
        private TextBox txtCedula;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private Label label4;
        private ComboBox comboPuesto;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button btnCancelarBusqueda;
        private Button btnBuscar;
        private Button btnModificar;
    }
}