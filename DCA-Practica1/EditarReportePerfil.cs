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
    public partial class EditarReportePerfil : Form
    {
        public event Action Refrescar;

        long idActual = 0;
        public EditarReportePerfil(long id)
        {
            InitializeComponent();
            idActual = id;
            Reporte reporte = null;
            foreach (Reporte report in Program.usuarioActual.reportes)
            {
                if (report.id == id)
                {
                    reporte = report;
                    break;
                }
            }
            textNombre.Text = reporte.nombre;
            richTextDesc.Text = reporte.desc;
            textBoxEstado.Text = reporte.estado.ToString();

            switch(reporte.error)
            {
                case Error.Critico:
                    radioButtonCritico.Select();
                    break;
                case Error.Grave:
                    radioButtonGrave.Select();
                    break;
                case Error.Serio:
                    radioButtonSerio.Select();
                    break;
                default:
                    break;
            }
            switch(reporte.tipo)
            {
                case Tipo.Importante:
                    radioButtonImportante.Select();
                    break;
                case Tipo.Menor:
                    radioButtonMenor.Select();
                    break;
                case Tipo.Normal:
                    radioButtonNormal.Select();
                    break;
                case Tipo.Sugerencia:
                    radioButtonSugerencia.Select();
                    break;
            }
        }
        private bool checkNombre()
        {
            // Comprobamos que 'Nombre' NO está vacío.
            if (textNombre.Text != "")
            {
                if (textNombre.Text.Length >= 2 && textNombre.Text.Length <= 15)
                {
                    labelNombre.Text = " ";
                    return true;
                }
                else
                    labelNombre.Text = "Debe tener entre 2 y 15 caracteres";
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
                if (richTextDesc.Text.Length <= 255)
                {
                    labelDesc.Text = " ";
                    return true;
                }
                else
                    labelDesc.Text = "Debe ser menor a 255 caracteres.";
            }
            else
                labelDesc.Text = "Este campo no puede estar vacío";
            return false;
        }

        public bool checkTipo()
        {
            for (int i = 0; i < TipoError.Controls.Count; i++)
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
            if (radioButtonImportante.Checked)
                return Tipo.Importante;
            if (radioButtonNormal.Checked)
                return Tipo.Normal;
            if (radioButtonMenor.Checked)
                return Tipo.Menor;
            if (radioButtonSugerencia.Checked)
                return Tipo.Sugerencia;
            // Imposible
            return Tipo.Importante;
        }

        private Error getGravedadError()
        {
            if (radioButtonCritico.Checked)
                return Error.Critico;
            if (radioButtonGrave.Checked)
                return Error.Grave;
            if (radioButtonSerio.Checked)
                return Error.Serio;
            //Imposible
            return Error.Serio;
        }
        private void updateList(List<Reporte> reportes)
        {
            foreach(Reporte reporte in reportes)
            {
                if(reporte.id == idActual)
                {
                    reporte.nombre = textNombre.Text;
                    reporte.desc = richTextDesc.Text;
                    reporte.tipo = getTipoError();
                    reporte.error = getGravedadError();
                }
            }
        }
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            bool nombreOK = checkNombre();
            bool descOK = checkDesc();
            bool tipoOK = checkTipo();
            bool gravedadOK = checkGravedad();

            if (nombreOK && descOK && tipoOK && gravedadOK)
            {
                // Reporte reporte = new Reporte(textNombre.Text, richTextDesc.Text, getTipoError(), getGravedadError(), Program.usuarioActual);
                // Program.reportesRegistrados.Add(reporte);
                foreach (Usuario usuario in Program.usuariosRegistrados)
                {
                    if (usuario.id == Program.usuarioActual.id)
                    {
                        updateList(usuario.reportes);
                        updateList(Program.reportesRegistrados);
                        break;
                    }
                }
                this.Hide();
                Refrescar();
            }
        }
    }
}
