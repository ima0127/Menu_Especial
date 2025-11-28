namespace Menu_Especial
{
    partial class FormListaPersonal
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
            btnBuscar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            label2 = new Label();
            cmbExportar = new ComboBox();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 20);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar Personal";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(43, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 250);
            dataGridView1.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(68, 58);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 27);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(350, 58);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(460, 58);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 27);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(100, 380);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 27);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.Location = new Point(605, 90);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 6;
            label2.Text = "Exportar";
            // 
            // cmbExportar
            // 
            cmbExportar.Location = new Point(585, 116);
            cmbExportar.Name = "cmbExportar";
            cmbExportar.Size = new Size(150, 28);
            cmbExportar.TabIndex = 7;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(615, 160);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 32);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar";
            btnExportar.Click += btnExportar_Click;
            // 
            // FormListaPersonal
            // 
            ClientSize = new Size(759, 450);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(cmbExportar);
            Controls.Add(btnExportar);
            Name = "FormListaPersonal";
            Load += FormListaPersonal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnSalir;
        private Label label2;
        private ComboBox cmbExportar;
        private Button btnExportar;
    }
}
