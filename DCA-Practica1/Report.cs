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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
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

        private bool checkNombre()
        {
            // Comprobamos que 'Nombre' NO está vacío.
            if (textNombre.Text != "")
            {
                if (textNombre.Text.Length >= 2 && textNombre.Text.Length <= 20)
                {
                    labelNombre.Text = " ";
                    return true;
                }
                else
                    labelNombre.Text = "Debe tener entre 2 y 20 caracteres";
            }
            else
                labelNombre.Text = "Este campo no puede estar vacío";
            return false;
        }

        private bool checkDesc()
        {
            // Comprobamos que 'Nombre' NO está vacío.
            if (richTextDesc.Text != "")
            {
                if (richTextDesc.Text.Length <= 20)
                {
                    labelDesc.Text = " ";
                    return true;
                }
                else
                    labelDesc.Text = "Debe tener entre 2 y 20 caracteres";
            }
            else
                labelDesc.Text = "Este campo no puede estar vacío";
            return false;
        }

        public bool checkTipo()
        {
            for(int i=0; i < TipoError.Controls.Count; i++)
            {
                if (((RadioButton)TipoError.Controls[i]).Checked)
                {
                    labelTipo.Text = " ";
                    return true;
                }
            }
            labelTipo.Text = "Seleccione una de\nlas opciones.";
            return false;
        }

        public bool checkGravedad()
        {
            for (int i = 0; i < GravedadError.Controls.Count; i++)
            {
                if (((RadioButton)GravedadError.Controls[i]).Checked)
                {
                    labelGravedad.Text = " ";
                    return true;
                }
            }
            labelGravedad.Text = "Seleccione una de\nlas opciones.";
            return false;
        }

        private Tipo getTipoError()
        {
            if(radioButtonImportante.Checked)
                return Tipo.Important;
            if (radioButtonNormal.Checked)
                return Tipo.Normal;
            if (radioButtonMenor.Checked)
                return Tipo.Minor;
            if (radioButtonSugerencia.Checked)
                return Tipo.Wishlist;
            // Imposible
            return Tipo.Important;
        }

        private Error getGravedadError()
        {
            if (radioButtonCritico.Checked)
                return Error.critical;
            if (radioButtonGrave.Checked)
                return Error.grave;
            if (radioButtonSerio.Checked)
                return Error.serious;
            //Imposible
            return Error.critical;
        }

        private void LetsHunt_Click(object sender, EventArgs e)
        {
            bool nombreOK = checkNombre();
            bool descOK = checkDesc();
            bool tipoOK = checkTipo();
            bool gravedadOK = checkGravedad();

            if(nombreOK && descOK && tipoOK && gravedadOK)
            {
                Reporte reporte = new Reporte(textNombre.Text, richTextDesc.Text, getTipoError(), getGravedadError(), Program.usuarioActual);
                Program.reportesRegistrados.Add(reporte);
                foreach (Usuario usuario in Program.usuariosRegistrados)
                {
                    if (usuario.id == Program.usuarioActual.id)
                    {
                        usuario.storageReport(reporte);
                        // Hace falta?
                        Program.usuarioActual = usuario; // Actualizamos el usuario actual con la nueva información
                        break;
                    }
                }
                Program.darGracias = true;
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }
    }
}
