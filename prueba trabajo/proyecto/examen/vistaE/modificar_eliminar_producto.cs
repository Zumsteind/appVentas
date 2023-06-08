using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using entidades;
using negocio;

namespace vistaE
{
    public partial class modificar_eliminar_producto : Form

    {
        private   List<Producto> listaproducto;
        public int id { get; set; }
        public modificar_eliminar_producto()
        {
            InitializeComponent();
        }

        private void modificar_eliminar_producto_Load(object sender, EventArgs e)
        {

            NegocioProducto negocio = new NegocioProducto();
            
            listaproducto = negocio.ListarProductos();

            if (listaproducto.Count > 0)
            {
                dgvlistaproductos.DataSource = listaproducto;
            }
            else
            {
                MessageBox.Show("No se encontraron Productos.");
            }
        }

        private void dgvlistaproductos_SelectionChanged(object sender, EventArgs e)
        {
            

           Producto productoseleccionado=(Producto)dgvlistaproductos.CurrentRow.DataBoundItem;

            id = (int)productoseleccionado.Id;
            txtnombre.Text = productoseleccionado.Nombre;
            txtprecio.Text = productoseleccionado.Precio.ToString();
            txtcategoria.Text = productoseleccionado.Categoria;
           
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            NegocioProducto negocio = new NegocioProducto();
            Producto x = new Producto();
            x.Id = id;
            x.Nombre = txtnombre.Text;
            x.Precio = float.Parse( txtprecio.Text);
            x.Categoria = txtcategoria.Text;

            if (negocio.ModificarProducto(x)) { MessageBox.Show("Se modifico con exido producto ID:" + x.Id); }
            else { MessageBox.Show("No se pudo modificar producto ID:" + x.Id); }

            listaproducto = negocio.ListarProductos();
            dgvlistaproductos.DataSource = listaproducto;

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            NegocioProducto negocio = new NegocioProducto();
            Producto x = new Producto();
            x.Id = id;


            //cargamos en un objeto cliente los txt que obtenemos al seleccionar un fila de la tabla. 
            x.Id = id;
            

            // Mostrar el cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el Producto ID: " + x.Id + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // El usuario ha confirmado la eliminación del cliente
                if (negocio.EliminarProducto(x.Id))
                {
                    MessageBox.Show("Producto eliminado con exito");


                    listaproducto = negocio.ListarProductos();
                   dgvlistaproductos.DataSource = listaproducto;
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Producto");
                }
            }


        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            NegocioProducto negocio = new NegocioProducto();
            dgvlistaproductos.DataSource = negocio.buscarProductos(txtbuscar.Text);
        }
    }
}
