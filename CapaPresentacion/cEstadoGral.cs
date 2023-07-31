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
    public partial class ConsultaEstadoGral : Form
    {
        public ConsultaEstadoGral()
        {
            InitializeComponent();
        }

        private void ConsultaEstadoGral_Load(object sender, EventArgs e)
        {

        }

        private void pbPreviousAll_Click(object sender, EventArgs e)
        {
            button2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }
    }
}
