using Herencia.Gestion_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia.Formularios
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            GestionUsuario bdUsuario = new GestionUsuario();
            bdUsuario.AbrirConexion(bdUsuario.EstableceConexion());

            if (string.IsNullOrEmpty(UsuarioLogin.Text) || string.IsNullOrEmpty(ContrasenniaLogin.Text))
            {
                UsuarioLogin.Text = "";
                ContrasenniaLogin.Text = "";

                MessageBox.Show("Usuario y/o contraseña tienen campos vacios",
                "Error de acceso",

                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                
            }
            else
            {
                if (bdUsuario.Verificar_Usuario_Contra(Convert.ToInt32(UsuarioLogin.Text), ContrasenniaLogin.Text) == true)
                {

                    Form1 Abrir = new Form1();
                    Abrir.Show();

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña no existen, intenta de nuevo");
                }

            }

        }

        private void UsuarioLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
