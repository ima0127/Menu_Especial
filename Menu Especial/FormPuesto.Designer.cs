namespace Menu_Especial
{
    partial class FormPuesto
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
            btnCancelar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            button1 = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(193, 361);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(47, 361);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 128);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre del puesto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(204, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 35);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 4;
            label2.Text = "Agregar Puestos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(735, 48);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 22;
            label3.Text = "Buscar Puesto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(538, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(443, 242);
            dataGridView1.TabIndex = 21;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(532, 83);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Doctor";
            txtBuscar.Size = new Size(275, 27);
            txtBuscar.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(913, 81);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(813, 81);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(323, 361);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // FormPuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 450);
            Controls.Add(btnModificar);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(button1);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "FormPuesto";
            Text = "FormPuesto";
            Load += FormPuesto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button button1;
        private Button btnBuscar;
        private Button btnModificar;
    }
}