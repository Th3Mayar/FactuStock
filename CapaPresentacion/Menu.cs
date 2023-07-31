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
    public partial class FMenu : Form
    {

        Panel p = new Panel();
        private int clickCount = 0;

        public FMenu()
        {
            InitializeComponent();
        }

        private void ocultarOpcion(){
            pProcesos.Visible = false;
            pMantenimientos.Visible = false;
            pConsultasReportes.Visible = false;
            pSubCategoria.Visible = false;
            pSubClientes.Visible = false;
            pSubEmpleados.Visible = false;
        }

        private void ocultarSubOpcion()
        {
            pSubCategoria.Visible = false;
            pSubClientes.Visible = false;
            pSubEmpleados.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                
            }
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(200,179,0);
            p.Size = new Size(140, 5);
            p.Location = new 
                Point(btn.Location.X, btn.Location.Y + 40);
            
            if (btn.Width > 140)
            {
                p.Width = btn.Width;
            }
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            ocultarOpcion();
            clickCount++;

            pMantenimientos.Visible = !pMantenimientos.Visible;

            if (clickCount > 1)
            {
                ocultarOpcion();
                clickCount = 0;
            }
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            ocultarOpcion();
            clickCount++;

            pProcesos.Visible = !pProcesos.Visible;

            if (clickCount > 1)
            {
                ocultarOpcion();
                clickCount = 0;
            }
        }

        private void btnConsultasReportes_Click(object sender, EventArgs e)
        {
            ocultarOpcion();
            clickCount++;

            pConsultasReportes.Visible = !pConsultasReportes.Visible;

            if (clickCount > 1)
            {
                ocultarOpcion();
                clickCount = 0;
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            clickCount++;

            pSubCategoria.Visible = !pSubCategoria.Visible;
            pSubCategoria.BackColor = Color.FromArgb(167, 169, 0);
            pSubCategoria.ForeColor = Color.White;
            if (clickCount > 1)
            {
                ocultarSubOpcion();
                clickCount = 0;
            }
        }

        private void btnCondicion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            clickCount++;

            pSubClientes.Visible = !pSubClientes.Visible;
            pSubClientes.BackColor = Color.FromArgb(167, 169, 0);
            pSubClientes.ForeColor = Color.White;

            if (clickCount > 1)
            {
                ocultarSubOpcion();
                clickCount = 0;
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            clickCount++;

            pSubEmpleados.Visible = !pSubEmpleados.Visible;
            pSubEmpleados.BackColor = Color.FromArgb(167, 169, 0);
            pSubEmpleados.ForeColor = Color.White;

            if (clickCount > 1)
            {
                ocultarSubOpcion();
                clickCount = 0;
            }
        }

        private void btnCategoriaProducto_Click(object sender, EventArgs e)
        {
            ConsultaEstadoGral estadoConsulta = new ConsultaEstadoGral();
            estadoConsulta.Show();
        }
    }
}
