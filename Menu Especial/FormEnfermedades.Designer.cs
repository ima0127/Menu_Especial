namespace Menu_Especial
{
    partial class FormEnfermedades
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
            label2 = new Label();
            label3 = new Label();
            txtEnfermedad = new TextBox();
            btnModificar = new Button();
            dataGridEnfermedades = new DataGridView();
            label4 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            labelID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridEnfermedades).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(600, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(69, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 24);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 2;
            label1.Text = "Registro de Enfermedades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 92);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 3;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 147);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre de enfermedad";
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.Location = new Point(211, 144);
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new Size(235, 27);
            txtEnfermedad.TabIndex = 5;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(455, 360);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // dataGridEnfermedades
            // 
            dataGridEnfermedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEnfermedades.Location = new Point(478, 92);
            dataGridEnfermedades.Name = "dataGridEnfermedades";
            dataGridEnfermedades.RowHeadersWidth = 51;
            dataGridEnfermedades.Size = new Size(300, 188);
            dataGridEnfermedades.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 24);
            label4.Name = "label4";
            label4.Size = new Size(252, 20);
            label4.TabIndex = 8;
            label4.Text = "Consultar(hacer click para modificar)";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(507, 59);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(235, 27);
            txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(573, 286);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(211, 92);
            labelID.Name = "labelID";
            labelID.Size = new Size(34, 20);
            labelID.TabIndex = 11;
            labelID.Text = "(ID)";
            // 
            // FormEnfermedades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelID);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(dataGridEnfermedades);
            Controls.Add(btnModificar);
            Controls.Add(txtEnfermedad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "FormEnfermedades";
            Text = "FormEnfermedades";
            Load += FormEnfermedades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEnfermedades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEnfermedad;
        private Button btnModificar;
        private DataGridView dataGridEnfermedades;
        private Label label4;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label labelID;
    }
}