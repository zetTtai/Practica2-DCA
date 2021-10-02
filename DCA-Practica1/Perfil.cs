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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Password
            if (showPassword.Checked)
                textPassword.UseSystemPasswordChar = false;
            else
                textPassword.UseSystemPasswordChar = true;
        }

        private void showConfirm_CheckedChanged(object sender, EventArgs e)
        {
            // Confirm Password
            if (showConfirm.Checked)
                textPasswordConfirm.UseSystemPasswordChar = false;
            else
                textPasswordConfirm.UseSystemPasswordChar = true;
        }

        private bool checkNombre()
        {
            // Comprobamos que 'Nombre' NO está vacío.
            if (textNombre.Text != "")
            {
                if (textNombre.Text.Length >= 2 && textNombre.Text.Length <= 10)
                {
                    labelNombre.Text = " ";
                    return true;
                }
                else
                    labelNombre.Text = "Debe tener entre 2 y 10 caracteres";
            }
            else
                labelNombre.Text = "Este campo no puede estar vacío";
            return false;
        }
        private bool checkPassword()
        {
            // Comprobamos que 'contraseña' NO está vacío.
            if (textPassword.Text != "")
                if (textPassword.Text.Length >= 2 && textPassword.Text.Length <= 20)
                {
                    labelPassword.Text = " ";
                }
                else
                    labelPassword.Text = "Debe tener entre 2 y 20 caracteres";
            else
                labelPassword.Text = "Este campo no puede estar vacío";
            // Comprobamos que 'Confirmar contraseña' NO está vacío.
            if (textPasswordConfirm.Text != "")
            {
                if (textPasswordConfirm.Text.Length >= 2 && textPasswordConfirm.Text.Length <= 20)
                {
                    if (textPassword.Text == textPasswordConfirm.Text)
                    {
                        labelConfirm.Text = " ";
                        return true;
                    }
                    else
                        labelConfirm.Text = "Las contraseñas no coinciden";
                }
                else
                    labelConfirm.Text = "Debe tener entre 2 y 20 caracteres";
            }
            else
                labelConfirm.Text = "Este campo no puede estar vacío";
            return false;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            bool nombreOK = checkNombre();
            bool passwordOK = checkPassword();

            if (nombreOK && passwordOK)
            {
                foreach (Usuario usuario in Program.usuariosRegistrados)
                {
                    if(usuario.id == Program.usuarioActual.id)
                    {
                        usuario.nombre = textNombre.Text;
                        usuario.password = textPassword.Text;
                        Program.usuarioActual = usuario;
                        break;
                    }
                }
                MessageBox.Show("Cambios realizados correctamente");
                this.Perfil_Load(null, null);
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        public void Frescura()
        {
            this.Perfil_Load(null, null);
        }

        private void dataGridViewReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                // MessageBox.Show("Mostrar");
                DataGridViewRow row = dataGridViewReportes.Rows[e.RowIndex];
                MostrarReporte mostrarReporte = new MostrarReporte(Convert.ToInt64(row.Cells[0].Value));
                mostrarReporte.ShowDialog();
            }
            else if (e.ColumnIndex == 6)
            {
                // MessageBox.Show("Editar");
                DataGridViewRow row = dataGridViewReportes.Rows[e.RowIndex];
                EditarReportePerfil editarReporte = new EditarReportePerfil(Convert.ToInt64(row.Cells[0].Value));
                editarReporte.Refrescar += Frescura;
                editarReporte.ShowDialog();
            }
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            textNombre.Text = Program.usuarioActual.nombre;
            textEmail.Text = Program.usuarioActual.email;
            textPassword.Text = Program.usuarioActual.password;
            textPasswordConfirm.Text = "";

            dataGridViewReportes.Rows.Clear();

            dataGridViewReportes.ColumnCount = 5;
            dataGridViewReportes.Columns[0].Name = "ID";
            dataGridViewReportes.Columns[1].Name = "Título";
            dataGridViewReportes.Columns[2].Name = "Estado";
            dataGridViewReportes.Columns[3].Name = "Tipo";
            dataGridViewReportes.Columns[4].Name = "Gravedad";

            foreach (Reporte reporte in Program.usuarioActual.reportes)
            {
                string[] row = new string[] { reporte.id.ToString(), reporte.nombre, reporte.estado.ToString(), reporte.tipo.ToString(), reporte.error.ToString() };
                dataGridViewReportes.Rows.Add(row);
            }
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Mostrar";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewReportes.Columns.Add(btn);
            DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
            editar.HeaderText = "";
            editar.Text = "Editar";
            editar.UseColumnTextForButtonValue = true;
            dataGridViewReportes.Columns.Add(editar);
        }
    }
}
