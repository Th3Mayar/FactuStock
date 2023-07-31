using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace FactuStock
{
    public partial class Login : Form
    {
        public string user = "", pass = "";
        CNUsuario objUsuario = new CNUsuario();

        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            mensajeCredenciales.Visible = false;
            mensaje.Visible = false;
            mensajeVacio.Visible = false;

            string nombreUsuario = txtUsuario.Text;
            string contrasena = txtPass.Text;
            objUsuario.ValidateUsuario(nombreUsuario, contrasena);

            string esUsuarioValido = "Jose";
            string esPasswordValida = "54321";

            if (nombreUsuario == esUsuarioValido && contrasena == esPasswordValida)
            {
                mensajeCredenciales.Visible = true;
                FMenu formulario = new FMenu();
                formulario.Show();
                login.Close();
            }
            else if (nombreUsuario == "" || contrasena == "")
            {
                mensajeVacio.Visible = true;
            }
            else
            {
                mensaje.Visible = true;
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
