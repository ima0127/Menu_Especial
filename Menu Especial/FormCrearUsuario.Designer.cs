namespace Menu_Especial
{
    partial class FormCrearUsuario
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            txtPassword2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(598, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click; // corregido
            // 
            // button2
            // 
            button2.Location = new Point(70, 358);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click; // corregido
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 26);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 2;
            label1.Text = "Gestor de Usuario de Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 74);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 135);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 201);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 5;
            label4.Text = "Repetir Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(230, 71);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(285, 27);
            txtUsuario.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(285, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(230, 201);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.Size = new Size(285, 27);
            txtPassword2.TabIndex = 8;
            // 
            // FormCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormCrearUsuario";
            Text = "FormCrearUsuario";
            Load += FormCrearUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private TextBox txtPassword2;
    }
}
