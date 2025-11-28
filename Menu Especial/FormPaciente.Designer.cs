namespace Menu_Especial
{
    partial class FormPaciente
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
            label1 = new Label();
            btnGuardar = new Button();
            txtCedula = new TextBox();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtMatricula = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dateFechaNacimiento = new DateTimePicker();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            btnCancelarBusqueda = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 65);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cedula";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(181, 328);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(168, 62);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "0000000000";
            txtCedula.Size = new Size(249, 27);
            txtCedula.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(49, 328);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(168, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "José Batista";
            txtNombre.Size = new Size(249, 27);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(168, 150);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Santiago, La barranquita calle...";
            txtDireccion.Size = new Size(249, 27);
            txtDireccion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 151);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 201);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 8;
            label4.Text = "Fecha de nacimiento";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(168, 239);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "100859858";
            txtMatricula.Size = new Size(249, 27);
            txtMatricula.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 240);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 10;
            label5.Text = "Matricula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 22);
            label6.Name = "label6";
            label6.Size = new Size(175, 20);
            label6.TabIndex = 12;
            label6.Text = "Información del paciente";
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Location = new Point(166, 196);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(250, 27);
            dateFechaNacimiento.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(660, 22);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 18;
            label7.Text = "Buscar Paciente";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(464, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(502, 224);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(464, 65);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "George Ramos";
            txtBuscar.Size = new Size(290, 27);
            txtBuscar.TabIndex = 16;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnCancelarBusqueda
            // 
            btnCancelarBusqueda.Location = new Point(872, 61);
            btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            btnCancelarBusqueda.Size = new Size(94, 29);
            btnCancelarBusqueda.TabIndex = 15;
            btnCancelarBusqueda.Text = "Cancelar";
            btnCancelarBusqueda.UseVisualStyleBackColor = true;
            btnCancelarBusqueda.Click += button1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(772, 62);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(323, 328);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(btnModificar);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(btnCancelarBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(dateFechaNacimiento);
            Controls.Add(label6);
            Controls.Add(txtMatricula);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(txtCedula);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Name = "FormPaciente";
            Text = "FormPaciente";
            Load += FormPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private TextBox txtCedula;
        private Button btnCancelar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private Label label4;
        private TextBox txtMatricula;
        private Label label5;
        private Label label6;
        private DateTimePicker dateFechaNacimiento;
        private Label label7;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button btnCancelarBusqueda;
        private Button btnBuscar;
        private Button btnModificar;
    }
}