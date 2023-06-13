using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using entidades;

namespace vistaE
{
    public partial class ListadeProductosvendidos : Form
    {
        public ListadeProductosvendidos()
        {
            InitializeComponent();
        }

        private void ListadeProductosvendidos_Load(object sender, EventArgs e)
        {

            int idVentaGenerada = listar_ventas.IdVenta;
            lblid.Text = idVentaGenerada.ToString();
            negocioventasitems negocio = new negocioventasitems();

            NegocioProducto negocioproducto = new NegocioProducto();
            ;
            dgvproductosvendidos.DataSource = negocioproducto.ListarProductosdelaventa(idVentaGenerada);

        }

        private void dgvproductosvendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
