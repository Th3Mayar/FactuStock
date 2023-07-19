using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;

            if(usuario == "Roselyn" && pass == "1234")
            {
                MessageBox.Show("Bienvenid@ al system");
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseñas incorrect.");
            }
        }
    }
}
