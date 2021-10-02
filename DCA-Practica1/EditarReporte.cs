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
    public partial class EditarReporte : Form
    {
        long idReporte = 0;
        public EditarReporte(long id)
        {
            InitializeComponent();
            idReporte = id;
            Reporte reporteActual = null;
            foreach (Reporte report in Program.reportesRegistrados)
            {
                if (report.id == id)
                {
                    reporteActual = report;
                    break;
                }
            }
            labelTitulo.Text = "Editando: " + reporteActual.nombre;
            labelDesc.Text = reporteActual.desc;
            labelAutor.Text = reporteActual.reportador.nombre;
            // Estado
            comboBoxEstado.Items.Add("Pendiente");
            comboBoxEstado.Items.Add("Visto");
            comboBoxEstado.Items.Add("Arreglando");
            comboBoxEstado.Items.Add("Solucionado");
            comboBoxEstado.Items.Add("WONTFIX");
            comboBoxEstado.SelectedItem = reporteActual.estado.ToString();
            labelTipo.Text = "Tipo de error:\n" + reporteActual.tipo.ToString();
            labelGravedad.Text = "Gravedad del error:\n" + reporteActual.error.ToString();
        }

        private void EditarReporte_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmo cambio a " + comboBoxEstado.SelectedItem.ToString());
            foreach (Reporte reporte in Program.reportesRegistrados)
            {
                if (reporte.id == idReporte)
                {
                    int index = comboBoxEstado.SelectedIndex;
                    switch(index)
                    {
                        case 0:
                            reporte.estado = Estado.Pendiente;
                            break;
                        case 1:
                            reporte.estado = Estado.Visto;
                            break;
                        case 2:
                            reporte.estado = Estado.Arreglando;
                            break;
                        case 3:
                            reporte.estado = Estado.Solucionado;
                            break;
                        case 4:
                            reporte.estado = Estado.WONTFIX;
                            break;
                        default:
                            break;
                    }
                }
            }
            this.Hide();
        }
    }
}
