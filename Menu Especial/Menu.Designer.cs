namespace Menu_Especial
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            enfermedadToolStripMenuItem = new ToolStripMenuItem();
            personalToolStripMenuItem = new ToolStripMenuItem();
            puestoToolStripMenuItem = new ToolStripMenuItem();
            transaccionesToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            listaPacientesToolStripMenuItem = new ToolStripMenuItem();
            listaPersonalToolStripMenuItem = new ToolStripMenuItem();
            lisToolStripMenuItem = new ToolStripMenuItem();
            utilitariosToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            acercaToolStripMenuItem = new ToolStripMenuItem();
            tiempoReal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            inputReproducir = new Button();
            dateFecha = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, transaccionesToolStripMenuItem, reportesToolStripMenuItem, utilitariosToolStripMenuItem, acercaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem, enfermedadToolStripMenuItem, personalToolStripMenuItem, puestoToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(124, 24);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            mantenimientoToolStripMenuItem.Click += mantenimientoToolStripMenuItem_Click;
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(173, 26);
            pacientesToolStripMenuItem.Text = "Pacientes";
            pacientesToolStripMenuItem.Click += pacientesToolStripMenuItem_Click;
            // 
            // enfermedadToolStripMenuItem
            // 
            enfermedadToolStripMenuItem.Name = "enfermedadToolStripMenuItem";
            enfermedadToolStripMenuItem.Size = new Size(173, 26);
            enfermedadToolStripMenuItem.Text = "Enfermedad";
            enfermedadToolStripMenuItem.Click += enfermedadToolStripMenuItem_Click;
            // 
            // personalToolStripMenuItem
            // 
            personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            personalToolStripMenuItem.Size = new Size(173, 26);
            personalToolStripMenuItem.Text = "Personal";
            personalToolStripMenuItem.Click += personalToolStripMenuItem_Click;
            // 
            // puestoToolStripMenuItem
            // 
            puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            puestoToolStripMenuItem.Size = new Size(173, 26);
            puestoToolStripMenuItem.Text = "Puesto";
            puestoToolStripMenuItem.Click += puestoToolStripMenuItem_Click;
            // 
            // transaccionesToolStripMenuItem
            // 
            transaccionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaToolStripMenuItem });
            transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            transaccionesToolStripMenuItem.Size = new Size(114, 24);
            transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(149, 26);
            consultaToolStripMenuItem.Text = "Consulta";
            consultaToolStripMenuItem.Click += consultaToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaPacientesToolStripMenuItem, listaPersonalToolStripMenuItem, lisToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listaPacientesToolStripMenuItem
            // 
            listaPacientesToolStripMenuItem.Name = "listaPacientesToolStripMenuItem";
            listaPacientesToolStripMenuItem.Size = new Size(187, 26);
            listaPacientesToolStripMenuItem.Text = "Lista Pacientes";
            listaPacientesToolStripMenuItem.Click += listaPacientesToolStripMenuItem_Click;
            // 
            // listaPersonalToolStripMenuItem
            // 
            listaPersonalToolStripMenuItem.Name = "listaPersonalToolStripMenuItem";
            listaPersonalToolStripMenuItem.Size = new Size(187, 26);
            listaPersonalToolStripMenuItem.Text = "Lista Personal";
            listaPersonalToolStripMenuItem.Click += listaPersonalToolStripMenuItem_Click;
            // 
            // lisToolStripMenuItem
            // 
            lisToolStripMenuItem.Name = "lisToolStripMenuItem";
            lisToolStripMenuItem.Size = new Size(187, 26);
            lisToolStripMenuItem.Text = "Lista Puestos";
            lisToolStripMenuItem.Click += lisToolStripMenuItem_Click;
            // 
            // utilitariosToolStripMenuItem
            // 
            utilitariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem });
            utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            utilitariosToolStripMenuItem.Size = new Size(87, 24);
            utilitariosToolStripMenuItem.Text = "Utilitarios";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(142, 26);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // acercaToolStripMenuItem
            // 
            acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            acercaToolStripMenuItem.Size = new Size(68, 24);
            acercaToolStripMenuItem.Text = "Acerca";
            acercaToolStripMenuItem.Click += acercaToolStripMenuItem_Click;
            // 
            // tiempoReal
            // 
            tiempoReal.AutoSize = true;
            tiempoReal.BackColor = Color.Transparent;
            tiempoReal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tiempoReal.ForeColor = SystemColors.ButtonFace;
            tiempoReal.Location = new Point(665, 53);
            tiempoReal.Name = "tiempoReal";
            tiempoReal.Size = new Size(70, 28);
            tiempoReal.TabIndex = 3;
            tiempoReal.Text = "label1";
            tiempoReal.Click += tiempoReal_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(624, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(256, 318);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(246, 45);
            axWindowsMediaPlayer1.TabIndex = 5;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // inputReproducir
            // 
            inputReproducir.Location = new Point(31, 366);
            inputReproducir.Name = "inputReproducir";
            inputReproducir.Size = new Size(94, 29);
            inputReproducir.TabIndex = 6;
            inputReproducir.Text = "Reproducir";
            inputReproducir.UseVisualStyleBackColor = true;
            inputReproducir.Click += inputReproducir_Click;
            // 
            // dateFecha
            // 
            dateFecha.AutoSize = true;
            dateFecha.BackColor = Color.Transparent;
            dateFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateFecha.ForeColor = SystemColors.ButtonFace;
            dateFecha.Location = new Point(665, 19);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(80, 28);
            dateFecha.TabIndex = 7;
            dateFecha.Text = "Label 2";
            dateFecha.Click += dateFecha_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(265, 50);
            label1.Name = "label1";
            label1.Size = new Size(237, 31);
            label1.TabIndex = 8;
            label1.Text = "Sistema de consultas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gabriola", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(696, 404);
            label4.Name = "label4";
            label4.Size = new Size(92, 37);
            label4.TabIndex = 9;
            label4.Text = "SaludWare";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dateFecha);
            Controls.Add(inputReproducir);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(button1);
            Controls.Add(tiempoReal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem transaccionesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem utilitariosToolStripMenuItem;
        private ToolStripMenuItem acercaToolStripMenuItem;
        private Label tiempoReal;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button inputReproducir;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem enfermedadToolStripMenuItem;
        private ToolStripMenuItem personalToolStripMenuItem;
        private ToolStripMenuItem puestoToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem listaPacientesToolStripMenuItem;
        private ToolStripMenuItem listaPersonalToolStripMenuItem;
        private ToolStripMenuItem lisToolStripMenuItem;
        private Label dateFecha;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private Label label4;
    }
}