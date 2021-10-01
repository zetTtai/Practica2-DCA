using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCA_Practica1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Saludo.Text = "¡Te doy la bienvenida, " + Program.usuarioActual.nombre + "!";
            if (Program.darGracias)
            {
                Agradecimiento.Text = "¡Gracias por notificar el bug!";
                Program.darGracias = false;
            }
            else
                Agradecimiento.Text = "";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureNotificar_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        private void pictureBuscar_Click(object sender, EventArgs e)
        {
            showAll showall = new showAll();
            showall.Show();
            this.Hide();
        }

        private void pictureCuenta_Click(object sender, EventArgs e)
        {

        }
    }
}
