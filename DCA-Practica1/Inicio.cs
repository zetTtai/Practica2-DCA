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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool checkEmail()
        {
            if (textEmail.Text != "")
            {
                foreach(Usuario usuario in Program.usuariosRegistrados)
                {
                    if(usuario.email == textEmail.Text)
                    {
                        labelEmail.Text = " ";
                        return true;
                    }
                }
                labelEmail.Text = "No existe ningún usuario con email: " + textEmail.Text;
            }
            else
                labelEmail.Text = "Este campo no puede estar vacío";
            return false;
        }
        private bool checkPassword()
        {
            if (textPassword.Text != "")
            {
                foreach (Usuario usuario in Program.usuariosRegistrados)
                {
                    if (usuario.email == textEmail.Text && usuario.password == textPassword.Text)
                    {
                        labelPassword.Text = " ";
                        Program.usuarioActual = usuario;
                        return true;
                    }
                }
                labelPassword.Text = "Contraseña incorrecta";
            }
            else
                labelPassword.Text = "Este campo no puede estar vacío";
            return false;
        }
        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            bool emailOK = checkEmail();
            bool passwordOK = false;
            if (emailOK) // Una vez el email es correcto
                passwordOK = checkPassword();
            if (emailOK && passwordOK)
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
        }

        private void registro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
                textPassword.UseSystemPasswordChar = false;
            else
                textPassword.UseSystemPasswordChar = true;
        }
    }
}
