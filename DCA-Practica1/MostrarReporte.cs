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
        long idActual= 0;
        public MostrarReporte(long id)
        {
            InitializeComponent();
            idActual = id;
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
            Comentar comentar = new Comentar(idActual);
            comentar.Refrescar += Frescura;
            comentar.ShowDialog();
        }

        public void Frescura()
        {
            this.MostrarReporte_Load(null, null);
        }

        private void MostrarReporte_Load(object sender, EventArgs e)
        {
            panelComentarios.Controls.Clear(); // Eliminamos los antiguos comentarios
            foreach (Reporte reporte in Program.reportesRegistrados)
            {
                if (reporte.id == idActual)
                {
                    foreach(Comentario comentario in reporte.comentarios)
                    {
                        Label msg = new Label
                        {
                            Text = comentario.ToString(),
                            Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
                            AutoSize = true,
                            Location = new Point(10, 75 * panelComentarios.Controls.Count)
                        };
                        panelComentarios.Controls.Add(msg);
                    }
                    break;
                }
            }
            //Comentario comment = new Comentario(Program.usuarioActual, reporte, "Hola, buenos días");
            //Label comentario = new Label
            //{
            //    Text = comment.ToString(),
            //    Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
            //    AutoSize = true,
            //    Location = new Point(10, 25 * panelComentarios.Controls.Count)
            //};
            //panelComentarios.Controls.Add(comentario);
            //Label aux2 = new Label
            //{
            //    Text = "Mundo: hola",
            //    Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
            //    AutoSize = true,
            //    Location = new Point(10, 25 * panelComentarios.Controls.Count)
            //};
            //panelComentarios.Controls.Add(aux2);
        }
    }
}
