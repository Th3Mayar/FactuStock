using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactuStock
{
    public partial class FMenu : Form
    {
        Panel p = new Panel();
        private int clickCount = 0;

        public FMenu()
        {
            InitializeComponent();
        }

        private void ocultarOpcion()
        {
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

        private void btnCerrarMenu_Click(object sender, EventArgs e)
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
            p.BackColor = Color.FromArgb(200, 179, 0);
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

        private void btnMantenimientosMenu_Click(object sender, EventArgs e)
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

        private void btnConsultasReportesMenu_Click(object sender, EventArgs e)
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

            ConsultarClientesGral consultarClientes = new ConsultarClientesGral();
            consultarClientes.Show();
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

            ConsultarEmpleadosGral consultarEmpleados = new ConsultarEmpleadosGral();
            consultarEmpleados.Show();
        }

        private void btnVentaCabeceraConsultar_Click(object sender, EventArgs e)
        {
            ConsultarVentaGral consultarVenta = new ConsultarVentaGral();
            consultarVenta.Show();
        }

        private void btnVentaDetalleConsultar_Click(object sender, EventArgs e)
        {
            ConsultarVentaDetalleGral consultarVentaDetalle = new ConsultarVentaDetalleGral();
            consultarVentaDetalle.Show();
        }

        private void btnCategoriaConsultar_MouseHover(object sender, EventArgs e)
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

        private void btnCategoriaConsultar_Click(object sender, EventArgs e)
        {
            ConsultarCategoriaGral consultarCategoria = new ConsultarCategoriaGral();
            consultarCategoria.Show();
        }

        private void btnCondicionConsultar_Click(object sender, EventArgs e)
        {
            ConsultarCondicionesGral consultarCondiciones = new ConsultarCondicionesGral();
            consultarCondiciones.Show();
        }

        private void btnEstadoConsultar_Click(object sender, EventArgs e)
        {
            ConsultaEstadoGral consultarEstados = new ConsultaEstadoGral();
            consultarEstados.Show();
        }

        private void btnRolesConsultar_Click(object sender, EventArgs e)
        {
            ConsultarRolGral consultarRoles = new ConsultarRolGral();
            consultarRoles.Show();
        }

        private void btnProductosConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProductosGral consultarProductos = new ConsultarProductosGral();
            consultarProductos.Show();
        }

        private void btnProveedoresConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProveedorGral consultarProveedor = new ConsultarProveedorGral();
            consultarProveedor.Show();
        }

        private void btnEmpresaConsultar_Click(object sender, EventArgs e)
        {
            ConsultarEmpresaGral consultarEmpresa = new ConsultarEmpresaGral();
            consultarEmpresa.Show();
        }

        private void btnInventarioConsultar_Click(object sender, EventArgs e)
        {
            ConsultarEntradaInventarioGral consultarEntrada = new ConsultarEntradaInventarioGral();
            consultarEntrada.Show();
        }

        private void btnSalidaInventarioConsultar_Click(object sender, EventArgs e)
        {
            ConsultarSalidaInventarioGral consultarSalida = new ConsultarSalidaInventarioGral();
            consultarSalida.Show();
        }

        private void btnSuministroConsultar_Click(object sender, EventArgs e)
        {
            ConsultarSuministroGral consultarSuministro = new ConsultarSuministroGral();
            consultarSuministro.Show();
        }
    }
}
