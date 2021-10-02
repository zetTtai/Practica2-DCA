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
    public partial class MostrarReporte : Form
    {
        public MostrarReporte(long id)
        {
            InitializeComponent();
            Reporte reporte = null;
            foreach(Reporte report in Program.reportesRegistrados)
            {
                if (report.id == id)
                {
                    reporte = report;
                    break;
                }
            }
            labelTitulo.Text = reporte.nombre;
            labelDesc.Text = reporte.desc;
            labelTipo.Text = "Tipo de error: " + reporte.tipo.ToString();
            labelGravedad.Text = "Gravedad del error: " + reporte.error.ToString();
            labelEstado.Text = "ESTADO: " + reporte.estado.ToString();
            labelAutor.Text = reporte.reportador.nombre;
        }

        private void buttonComentar_Click(object sender, EventArgs e)
        {

        }

        private void MostrarReporte_Load(object sender, EventArgs e)
        {
            Label aux = new Label
            {
                Text = "Hola mundo",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(10, 25 * panelComentarios.Controls.Count)
            };
            panelComentarios.Controls.Add(aux);
            Label aux2 = new Label
            {
                Text = "Mundo: hola",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(10, 25 * panelComentarios.Controls.Count)
            };
            panelComentarios.Controls.Add(aux2);
        }
    }
}
