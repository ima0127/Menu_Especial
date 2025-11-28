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

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(52, 68);
            label1.Text = "Nombre Paciente";

            // btnGuardar
            btnGuardar.Location = new Point(182, 500);
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;

            // comboPaciente
            comboPaciente.FormattingEnabled = true;
            comboPaciente.Location = new Point(181, 65);
            comboPaciente.Size = new Size(264, 28);

            // comboPersonal
            comboPersonal.FormattingEnabled = true;
            comboPersonal.Location = new Point(181, 126);
            comboPersonal.Size = new Size(264, 28);

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(52, 129);
            label2.Text = "Nombre Personal";

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(52, 188);
            label3.Text = "Fecha Consulta";

            // btnCancelar
            btnCancelar.Location = new Point(54, 500);
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;

            // label4
            label4.AutoSize = true;
            label4.Location = new Point(54, 378);
            label4.Text = "Procedimiento";

            // txtProcedimiento
            txtProcedimiento.Location = new Point(181, 375);
            txtProcedimiento.Size = new Size(264, 27);
            txtProcedimiento.TextChanged += txtProcedimiento_TextChanged;

            // label5
            label5.AutoSize = true;
            label5.Location = new Point(59, 271);
            label5.Text = "Diagnóstico";

            // txtDiagnostico
            txtDiagnostico.Location = new Point(182, 221);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Size = new Size(264, 131);

            // label6
            label6.AutoSize = true;
            label6.Location = new Point(313, 21);
            label6.Text = "Consulta Médica";

            // dateFechaConsulta
            dateFechaConsulta.Location = new Point(182, 183);
            dateFechaConsulta.Size = new Size(263, 27);

            // label7
            label7.AutoSize = true;
            label7.Location = new Point(691, 30);
            label7.Text = "Buscar Consulta";

            // dataGridView1
            dataGridView1.Location = new Point(494, 110);
            dataGridView1.Size = new Size(443, 242);

            // txtBuscar
            txtBuscar.Location = new Point(488, 65);
            txtBuscar.Size = new Size(275, 27);
            txtBuscar.TextChanged += txtBuscar_TextChanged;

            // Cancelar buscar
            button1.Location = new Point(869, 63);
            button1.Size = new Size(94, 29);
            button1.Text = "Cancelar";
            button1.Click += btnCancelarBusqueda_Click;

            // btnBuscar
            btnBuscar.Location = new Point(769, 63);
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;

            // btnModificar
            btnModificar.Location = new Point(313, 500);
            btnModificar.Size = new Size(94, 29);
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;

            // comboExportar
            comboExportar.Location = new Point(488, 380);
            comboExportar.Size = new Size(200, 28);

            // btnExportar
            btnExportar.Location = new Point(700, 377);
            btnExportar.Size = new Size(120, 32);
            btnExportar.Text = "Exportar";
            btnExportar.Click += btnExportar_Click;

            // FormConsulta
            ClientSize = new Size(1036, 602);
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
