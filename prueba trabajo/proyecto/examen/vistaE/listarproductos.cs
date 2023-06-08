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
    public partial class listarproductos : Form
    {
        public listarproductos()
        {
            InitializeComponent();
        }

        private void listarproductos_Load(object sender, EventArgs e)
        {
            Producto x = new Producto();
            NegocioProducto negocio = new NegocioProducto();

            dgvlistarproductos.DataSource = negocio.ListarProductos();



        }

        private void dgvlistarproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
