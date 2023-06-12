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
           
           
            

           

            List<string> listaProductos = negocio.listarproductos(idVentaGenerada);

            dgvproductosvendidos.AutoGenerateColumns = false;

            // Configuramos las columnas manualmente
            dgvproductosvendidos.Columns.Add("id_item", "ID Item");
            dgvproductosvendidos.Columns.Add("nombre_producto", "  Nombre Producto ");
            dgvproductosvendidos.Columns.Add("cantidad", "Cantidad");
            dgvproductosvendidos.Columns.Add("precio_unitario", "Precio Unitario");
            dgvproductosvendidos.Columns.Add("total", "Total");

            // Asignar los datos a la grilla
            foreach (string producto in listaProductos)
            {
                string[] valores = producto.Split(',');

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvproductosvendidos);

                fila.Cells[0].Value = valores[0].Trim().Substring(9);  // Obtener el valor de id_item
                fila.Cells[1].Value = valores[1].Trim().Substring(17); // Obtener el valor de nombre_producto
                fila.Cells[2].Value = valores[2].Trim().Substring(10); // Obtener el valor de cantidad
                fila.Cells[3].Value = valores[3].Trim().Substring(17); // Obtener el valor de precio_unitario
                fila.Cells[4].Value = valores[4].Trim().Substring(7);  // Obtener el valor de total

                dgvproductosvendidos.Rows.Add(fila);
            }

            foreach (DataGridViewColumn columna in dgvproductosvendidos.Columns)
            {
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            
        }

        private void dgvproductosvendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
