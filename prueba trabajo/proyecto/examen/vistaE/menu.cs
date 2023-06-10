using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
using negocio;

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

        private void btnagregarcliente_Click(object sender, EventArgs e)
        {
            agregarcliente ventana = new agregarcliente();
            ventana.ShowDialog();
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            agregarproducto ventana = new agregarproducto();
            ventana.ShowDialog();
        }

        private void btnlistarcliente_Click(object sender, EventArgs e)
        {
            listarclientes ventana = new listarclientes();
            ventana.ShowDialog();
        }

        private void btnlistarproductos_Click(object sender, EventArgs e)
        {
            listar_productos ventana = new listar_productos();
            ventana.ShowDialog();
        }

        private void btnmecliente_Click(object sender, EventArgs e)
        {
            modificar_eleminar_cliente ventana = new modificar_eleminar_cliente();
            ventana.ShowDialog();
        }

        private void btnmeproducto_Click(object sender, EventArgs e)
        {
            modificar_eliminar_producto ventana = new modificar_eliminar_producto();
            ventana.ShowDialog();
        }
    }
}
