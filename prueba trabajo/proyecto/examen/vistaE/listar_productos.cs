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
    public partial class listar_productos : Form
    {
        public listar_productos()
        {
            InitializeComponent();
        }

        private void listar_productos_Load(object sender, EventArgs e)
        {
            NegocioProducto negocio = new NegocioProducto();

            dgvproductos.DataSource = negocio.ListarProductos();


        }

        private void txtbuscarproducto_TextChanged(object sender, EventArgs e)
        {
            NegocioProducto negocio = new NegocioProducto();
            dgvproductos.DataSource = negocio.buscarProductos(txtbuscarproducto.Text);
        }
    }
}
