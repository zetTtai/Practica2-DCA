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
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("ID",typeof(long));
            DataColumn dc2 = new DataColumn("Título", typeof(string));
            DataColumn dc3 = new DataColumn("Tipo", typeof(Tipo));
            DataColumn dc4 = new DataColumn("Gravedad", typeof(Error));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            //dt.Rows.Add(txt_personalNo.Text, txt_name.Text, txt_date.Text, Convert.ToInt32(txt_quantity.Text), cmb_type.SelectedItem.ToString());
            
            foreach(Reporte reporte in Program.reportesRegistrados)
            {
                dt.Rows.Add(reporte.id, reporte.nombre, reporte.tipo, reporte.error);
            }

            dataGridViewReportes.DataSource = dt;

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
