using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistaE
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            Venta_alta ventana = new Venta_alta();
            ventana.ShowDialog();
        }
    }
}
