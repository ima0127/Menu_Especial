namespace Menu_Especial
{
    partial class FormListaPuesto
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
            comboExportar = new ComboBox();
            btnExportar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar Puesto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(443, 242);
            dataGridView1.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(27, 47);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(275, 27);
            txtBuscar.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(439, 47);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(339, 47);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(58, 373);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            // 
            // comboExportar
            // 
            comboExportar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboExportar.Location = new Point(508, 141);
            comboExportar.Name = "comboExportar";
            comboExportar.Size = new Size(130, 28);
            comboExportar.TabIndex = 6;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(508, 192);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(130, 30);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "Exportar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(533, 105);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 8;
            label2.Text = "Formato";
            // 
            // FormListaPuesto
            // 
            ClientSize = new Size(690, 423);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalir);
            Controls.Add(comboExportar);
            Controls.Add(btnExportar);
            Controls.Add(label2);
            Name = "FormListaPuesto";
            Text = "Lista de Puestos";
            Load += FormListaPuesto_Load_1;
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

        private ComboBox comboExportar;
        private Button btnExportar;

        private Label label2;
    }
}
