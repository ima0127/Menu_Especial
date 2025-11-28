using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Especial
{
    public partial class Menu : Form
    {
        private string usuarioActual; // <-- Variable para guardar el usuario

        // Nuevo constructor que recibe el usuario
        public Menu(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Bloquear la opción "Usuario" si no es admin
            if (usuarioActual.ToLower() != "admin")
            {
                usuarioToolStripMenuItem.Enabled = false;  // Solo deshabilita
                // Si quieres ocultarlo completamente:
                // usuarioToolStripMenuItem.Visible = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoReal.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            dateFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }
        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form acerca = new acerca();
            acerca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private bool isPlaying = false;

        private void inputReproducir_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Ismael\source\repos\Menu Especial\MarshmelloAlone.mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                isPlaying = true;
                inputReproducir.Text = "Detener";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                isPlaying = false;
                inputReproducir.Text = "Reproducir";
            }
        }

        private void tiempoReal_Click(object sender, EventArgs e)
        {

        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormPersonal = new FormPersonal();
            FormPersonal.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormPaciente = new FormPaciente();
            FormPaciente.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormConsulta = new FormConsulta();
            FormConsulta.Show();
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormPuesto = new FormPuesto();
            FormPuesto.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enfermedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormEnfermedades = new FormEnfermedades();
            FormEnfermedades.Show();
        }

        private void listaPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormListaPersonal = new FormListaPersonal();
            FormListaPersonal.Show();
        }

        private void listaPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormListaPaciente = new FormListaPaciente();
            FormListaPaciente.Show();
        }

        private void lisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormListaPuesto = new FormListaPuesto();
            FormListaPuesto.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormCrearUsuario = new FormCrearUsuario();
            FormCrearUsuario.Show();
        }

        private void dateFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
