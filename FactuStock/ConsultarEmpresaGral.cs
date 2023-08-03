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
    public partial class ConsultarEmpresaGral : Form
    {
        public int vidempresa = 0, vtieneparametro = 0, indice = 0;
        public string valorparametro = "", mensaje = "";
        CNEmpresa objEmpresa = new CNEmpresa();

        public ConsultarEmpresaGral()
        {
            InitializeComponent();
        }

        private void BConsultar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {
                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else //si el textbox está vacío 
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
            }

            MostrarDatos(); //Se llama al método MostrarDatos
            tbBuscar.Focus(); //Se le pasa el cursos al textbox
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarEmpresaGral_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos(); //Método que llena el DataGrid
            tbBuscar.Focus(); //El TextBox Buscar recibe el cursor
        }

        private void ConsultarEmpresaGral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
                 "Mensaje de FactuStock",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void MostrarDatos()
        {
            // Se toma el texto que se haya introducido en el textbox para usarlo como parámetro
            string valorparametro = tbBuscar.Text.Trim();
            //Si el procedimiento almacenado devuelve algún valor se ajusta el ancho de las columnas del DataGridView
            if (objEmpresa.ObtenerEmpresa(valorparametro) != null)
            {
                DGVDatos.DataSource = objEmpresa.ObtenerEmpresa(valorparametro);
                DGVDatos.Columns[0].Width = 80;
                DGVDatos.Columns[1].Width = 200;
                DGVDatos.Columns[2].Width = 225;
                DGVDatos.Columns[3].Width = 100;
                DGVDatos.Columns[4].Width = 125;
                DGVDatos.Columns[5].Width = 125;
                DGVDatos.Columns[6].Width = 150;
                DGVDatos.Columns[7].Width = 100;
                DGVDatos.Columns[8].Width = 150;
            }
            else //Si el valor de vtieneparametro es 1 se ejecuta el método que filtra datos según el parámetro
            {
                MessageBox.Show("No se retornó ningún valor!");
            }
            DGVDatos.Refresh(); //Se refresca el DataGridView
            //LCantClientes.Text = Convert.ToString(DGVDatos.RowCount); //Se muestra la cantidad de datos
            if (DGVDatos.RowCount <= 0) //Si no se obtienen datos de retorno
            {
                MessageBox.Show("Ningún dato que mostrar!"); //Se muestra un mensaje de error
            }

        } //Fin del método mostra

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío
                indice = DGVDatos.CurrentRow.Index; //El valor de índice será la fila actua
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
