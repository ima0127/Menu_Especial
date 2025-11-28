namespace Menu_Especial
{
    partial class FormListaPaciente
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
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            btnCancelar = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            label2 = new Label();
            cmbExportar = new ComboBox();
            btnExportar = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // Título
            label1.AutoSize = true;
            label1.Location = new Point(344, 21);
            label1.Text = "Buscar Paciente";

            // DataGridView
            dataGridView1.Location = new Point(124, 100);
            dataGridView1.Size = new Size(520, 242);

            // TextBox Buscar
            txtBuscar.Location = new Point(124, 56);
            txtBuscar.PlaceholderText = "George Ramos";
            txtBuscar.Size = new Size(275, 27);

            // Botón Cancelar
            btnCancelar.Location = new Point(537, 54);
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;

            // Botón Buscar
            btnBuscar.Location = new Point(422, 54);
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;

            // Botón Salir
            btnSalir.Location = new Point(72, 403);
            btnSalir.Size = new Size(94, 29);
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;

            // Label Exportar
            label2.AutoSize = true;
            label2.Location = new Point(680, 78);
            label2.Text = "Exportar";

            // ComboBox Exportar
            cmbExportar.Location = new Point(650, 110);
            cmbExportar.Size = new Size(140, 28);
            cmbExportar.DropDownStyle = ComboBoxStyle.DropDownList;

            // Botón Exportar
            btnExportar.Location = new Point(650, 150);
            btnExportar.Size = new Size(140, 30);
            btnExportar.Text = "Exportar";
            btnExportar.Click += btnExportar_Click;

            // FormListaPaciente
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(cmbExportar);
            Controls.Add(btnExportar);
            Text = "FormListaPaciente";

            Load += FormListaPaciente_Load;

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button btnCancelar;
        private Button btnBuscar;
        private Button btnSalir;
        private Label label2;
        private ComboBox cmbExportar;
        private Button btnExportar;
    }
}
