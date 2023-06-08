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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void menuagregarcliente_Click(object sender, EventArgs e)
        {
            agregarcliente ventana = new agregarcliente();
            ventana.ShowDialog();
        }

        private void menuagregarproducto_Click(object sender, EventArgs e)
        {
            agregarproducto ventana = new agregarproducto();
            ventana.ShowDialog();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarclientes ventana = new listarclientes();

            ventana.ShowDialog();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarproductos ventana = new listarproductos();
            ventana.ShowDialog();
        }

        private void eliminarOModificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificar_eleminar_cliente ventana = new modificar_eleminar_cliente();
            ventana.ShowDialog();

        }
    }
}
