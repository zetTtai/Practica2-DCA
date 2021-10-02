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
    public partial class showAll : Form
    {
        public showAll()
        {
            InitializeComponent();

            dataGridViewReportes.ColumnCount = 5;
            dataGridViewReportes.Columns[0].Name = "ID";
            dataGridViewReportes.Columns[1].Name = "Título";
            dataGridViewReportes.Columns[2].Name = "Estado";
            dataGridViewReportes.Columns[3].Name = "Tipo";
            dataGridViewReportes.Columns[4].Name = "Gravedad";

            foreach (Reporte reporte in Program.reportesRegistrados)
            {
                string[] row = new string[] { reporte.id.ToString(), reporte.nombre, reporte.estado.ToString(), reporte.tipo.ToString(), reporte.error.ToString()};
                dataGridViewReportes.Rows.Add(row);
            }
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Mostrar";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewReportes.Columns.Add(btn);
            if(Program.usuarioActual.admin)
            {
                DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
                editar.HeaderText = "";
                editar.Text = "Editar";
                editar.UseColumnTextForButtonValue = true;
                dataGridViewReportes.Columns.Add(editar);

                DataGridViewButtonColumn borrar = new DataGridViewButtonColumn();
                borrar.HeaderText = "";
                borrar.Text = "Borrar";
                borrar.UseColumnTextForButtonValue = true;
                dataGridViewReportes.Columns.Add(borrar);
            }

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                // MessageBox.Show("Mostrar");
                DataGridViewRow row = dataGridViewReportes.Rows[e.RowIndex];
                MostrarReporte mostrarReporte = new MostrarReporte(Convert.ToInt64(row.Cells[0].Value));
                mostrarReporte.ShowDialog();
            }
            else if(e.ColumnIndex == 6)
            {
                // MessageBox.Show("Editar");
                DataGridViewRow row = dataGridViewReportes.Rows[e.RowIndex];
                EditarReporte editarReporte  = new EditarReporte(Convert.ToInt64(row.Cells[0].Value));
                editarReporte.ShowDialog();
            }
            else if(e.ColumnIndex == 7)
            {
                DataGridViewRow row = dataGridViewReportes.Rows[e.RowIndex];
                foreach (Reporte reporte in Program.reportesRegistrados)
                {
                    if (reporte.id == Convert.ToInt64(row.Cells[0].Value))
                    {
                        Program.reportesRegistrados.Remove(reporte);
                        dataGridViewReportes.Rows.RemoveAt(e.RowIndex);
                        break;
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            showAll show = new showAll();
            show.Show();
            this.Hide();
        }
    }
}
