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
            textNombre.Text = Program.usuarioActual.nombre;
            textEmail.Text = Program.usuarioActual.email;
            textPassword.Text = Program.usuarioActual.password;
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
        private bool checkEmail()
        {
            // Comprobamos que 'Email' NO está vacío.
            if (textEmail.Text != "")
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(textEmail.Text);
                    if (addr.Address == textEmail.Text)
                    {
                        labelEmail.Text = " ";
                        return true;
                    }
                }
                catch
                {
                    labelEmail.Text = "No es un correo electrónico válido\n(nombre@gmail.com)";
                }
            }
            else
                labelEmail.Text = "Este campo no puede estar vacío";
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
            bool emailOK = checkEmail();
            bool passwordOK = checkPassword();

            if (nombreOK && emailOK && passwordOK)
            {
                // Actualizamos al usuario a nuestra lista de usuarios registrados
                // Usuario usuario = new Usuario(textNombre.Text, textEmail.Text, textPassword.Text);
                // Program.usuariosRegistrados.Add(usuario);
                foreach (Usuario usuario in Program.usuariosRegistrados)
                {
                    if(usuario.id == Program.usuarioActual.id)
                    {
                        usuario.nombre = textNombre.Text;
                        usuario.email = textEmail.Text;
                        usuario.password = textPassword.Text;
                        Program.usuarioActual = usuario;
                        break;
                    }
                }
                Perfil home = new Perfil();
                this.Hide();
                home.Show();
            }
        }
    }
}
