namespace Menu_Especial
{
    partial class FormConsulta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            btnGuardar = new Button();
            comboPaciente = new ComboBox();
            comboPersonal = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            label4 = new Label();
            txtProcedimiento = new TextBox();
            label5 = new Label();
            txtDiagnostico = new TextBox();
            label6 = new Label();
            dateFechaConsulta = new DateTimePicker();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            button1 = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            comboExportar = new ComboBox();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 68);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 20;
            label1.Text = "Nombre Paciente";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(182, 500);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // comboPaciente
            // 
            comboPaciente.FormattingEnabled = true;
            comboPaciente.Location = new Point(181, 65);
            comboPaciente.Name = "comboPaciente";
            comboPaciente.Size = new Size(264, 28);
            comboPaciente.TabIndex = 18;
            // 
            // comboPersonal
            // 
            comboPersonal.FormattingEnabled = true;
            comboPersonal.Location = new Point(181, 126);
            comboPersonal.Name = "comboPersonal";
            comboPersonal.Size = new Size(264, 28);
            comboPersonal.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 129);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 17;
            label2.Text = "Nombre Personal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 188);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 15;
            label3.Text = "Fecha Consulta";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(54, 500);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 378);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 12;
            label4.Text = "Procedimiento";
            // 
            // txtProcedimiento
            // 
            txtProcedimiento.Location = new Point(181, 375);
            txtProcedimiento.Name = "txtProcedimiento";
            txtProcedimiento.Size = new Size(264, 27);
            txtProcedimiento.TabIndex = 13;
            txtProcedimiento.TextChanged += txtProcedimiento_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 271);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 11;
            label5.Text = "Diagnóstico";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(182, 221);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(264, 131);
            txtDiagnostico.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(313, 21);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 9;
            label6.Text = "Consulta Médica";
            // 
            // dateFechaConsulta
            // 
            dateFechaConsulta.Location = new Point(182, 183);
            dateFechaConsulta.Name = "dateFechaConsulta";
            dateFechaConsulta.Size = new Size(263, 27);
            dateFechaConsulta.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(691, 30);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 3;
            label7.Text = "Buscar Consulta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(488, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(709, 355);
            dataGridView1.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(488, 65);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(275, 27);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(869, 63);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Cancelar";
            button1.Click += btnCancelarBusqueda_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(769, 63);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(313, 500);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            // 
            // comboExportar
            // 
            comboExportar.Location = new Point(494, 500);
            comboExportar.Name = "comboExportar";
            comboExportar.Size = new Size(200, 28);
            comboExportar.TabIndex = 1;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(700, 497);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(120, 32);
            btnExportar.TabIndex = 0;
            btnExportar.Text = "Exportar";
            btnExportar.Click += btnExportar_Click;
            // 
            // FormConsulta
            // 
            ClientSize = new Size(1260, 602);
            Controls.Add(btnExportar);
            Controls.Add(comboExportar);
            Controls.Add(btnModificar);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(button1);
            Controls.Add(btnBuscar);
            Controls.Add(dateFechaConsulta);
            Controls.Add(label6);
            Controls.Add(txtDiagnostico);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtProcedimiento);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(comboPersonal);
            Controls.Add(label2);
            Controls.Add(comboPaciente);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Name = "FormConsulta";
            Text = "FormConsulta";
            Load += FormConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private ComboBox comboPaciente;
        private ComboBox comboPersonal;
        private Label label2;
        private Label label3;
        private Button btnCancelar;
        private Label label4;
        private TextBox txtProcedimiento;
        private Label label5;
        private TextBox txtDiagnostico;
        private Label label6;
        private DateTimePicker dateFechaConsulta;
        private Label label7;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button button1;
        private Button btnBuscar;
        private Button btnModificar;
        private ComboBox comboExportar;
        private Button btnExportar;
    }
}
