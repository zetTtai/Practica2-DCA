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
    public partial class Comentar : Form
    {
        public event Action Refrescar;
        long idReporte= 0;
        public Comentar(long id)
        {
            InitializeComponent();
            idReporte = id;
            foreach(Reporte reporte in Program.reportesRegistrados)
            {
                if (reporte.id == id)
                {
                    labelTitulo.Text = "Comentando sobre:\n" + reporte.nombre;
                    break;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool checkMsg()
        {
            if (richTextBoxMsg.Text != "")
            {
                if (richTextBoxMsg.Text.Length <= 255)
                {
                    labelMensaje.Text = " ";
                    return true;
                }
                else
                    labelMensaje.Text = "Un comentario no puede tener más de 255 caracteres";
            }
            else
                labelMensaje.Text = "Este campo no puede estar vacío";
            return false;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            bool msgOK = checkMsg();

            if(msgOK)
            {
                foreach (Reporte reporte in Program.reportesRegistrados)
                {
                    if (reporte.id == idReporte)
                    {
                        // Comentario comentario = new Comentario(Program.usuarioActual, null, richTextBoxMsg.Text);
                        reporte.comentarios.Add(new Comentario(Program.usuarioActual, reporte, richTextBoxMsg.Text));
                        this.Hide();
                        Refrescar();
                        break;
                    }
                }
            }
        }
    }
}
