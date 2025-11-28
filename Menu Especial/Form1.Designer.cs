namespace Menu_Especial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            inputUser = new TextBox();
            inputPassword = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(363, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(344, 185);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // inputUser
            // 
            inputUser.Location = new Point(271, 133);
            inputUser.Margin = new Padding(4, 5, 4, 5);
            inputUser.Name = "inputUser";
            inputUser.Size = new Size(269, 34);
            inputUser.TabIndex = 2;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(271, 240);
            inputPassword.Margin = new Padding(4, 5, 4, 5);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '*';
            inputPassword.Size = new Size(269, 34);
            inputPassword.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(304, 336);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(204, 42);
            button1.TabIndex = 4;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(220, 38);
            label3.Name = "label3";
            label3.Size = new Size(380, 37);
            label3.TabIndex = 5;
            label3.Text = "Sistema de consultas medicas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gabriola", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(668, 419);
            label4.Name = "label4";
            label4.Size = new Size(92, 37);
            label4.TabIndex = 6;
            label4.Text = "SaludWare";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(802, 466);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(inputPassword);
            Controls.Add(inputUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inputUser;
        private TextBox inputPassword;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}
