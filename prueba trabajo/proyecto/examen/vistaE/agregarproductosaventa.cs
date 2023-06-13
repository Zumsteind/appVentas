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
    public partial class agregarproductosaventa : Form
    {

        public Producto nuevoproducto { get; set; }
        public  float totalventaproductos { get; set; } = 0;
        public int iditem { get; set; }
        private bool cerrarVentana = false;


        public agregarproductosaventa()
        {
            InitializeComponent();
        }

        private void agregarproductosaventa_Load(object sender, EventArgs e)
        {
            NegocioProducto negocio = new NegocioProducto();
            

            try
            {
                dgvproductos.DataSource = negocio.ListarProductos();
                
            }
            catch (Exception)
            {

                throw;
            }

            
            
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            int idVentaGenerada = Venta_alta.IdVentaGenerada;
            

            Ventas venta = new Ventas();
            Producto producto = new Producto();
            venta.id = idVentaGenerada;
            producto.Id = int.Parse(lblidproducto.Text);
            Ventasitems x = new Ventasitems();
            x.idventas = venta;
            x.idproducto = producto;
            x.cantidad = float.Parse(txtcantidad.Text);
            x.preciounitario = float.Parse(lblprecio.Text);
            negocioventasitems negocio = new negocioventasitems();
            txtcantidad.Text = "1";
           

            try
            {
                // Agregar el producto a la venta
                bool exitoAgregar = negocio.agregarVentaitem(x);

                if (exitoAgregar)
                {
                    
                        MessageBox.Show("Se agregó el producto a la venta");
                    totalventaproductos += x.cantidad * x.preciounitario;
                    lbltotaldeventa.Text = totalventaproductos.ToString()+" $";


                    //agregamos los productos que se van agregando al dgv
                    NegocioProducto negocioproductos = new NegocioProducto();
                    dgvproductosconfirmados.DataSource= negocioproductos.ListarProductosdelaventa(idVentaGenerada);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el producto a la venta.");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            

        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproductos_SelectionChanged(object sender, EventArgs e)
        {
            
            nuevoproducto = (Producto)dgvproductos.CurrentRow.DataBoundItem;

            lblidproducto.Text = nuevoproducto.Id.ToString();
            lblprecio.Text = nuevoproducto.Precio.ToString();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void agregarproductosaventa_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }

        private void btnfinalizarventa_Click(object sender, EventArgs e)
        {
            int idVentaGenerada = Venta_alta.IdVentaGenerada;
            negocioventasitems negocio = new negocioventasitems();

            if (lbltotaldeventa.Text != "0 $")
            {
                if (negocio.actualizartotalventa(idVentaGenerada, totalventaproductos))
                {
                    MessageBox.Show("se actualizo el total de la venta");
                }
                else { MessageBox.Show("no se pudo actualizar el total de la venta"); }

                cerrarVentana = true;
                this.Close();

            }
            else { MessageBox.Show("No agrego productos a la venta"); }
           

           

           

        }

        private void btncancelarventa_Click(object sender, EventArgs e)
        {
            int idVentaGenerada = Venta_alta.IdVentaGenerada;

            NegocioVentas negocioventas = new NegocioVentas();
            negocioventasitems negocioitem = new negocioventasitems();

            negocioitem.eliminarVentaitem(idVentaGenerada);
            negocioventas.EliminarVenta(idVentaGenerada);

            cerrarVentana = true;
            this.Close();

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            NegocioProducto negocioproducto = new NegocioProducto();
            
            dgvproductos.DataSource= negocioproducto.buscarProductos(txtbuscar.Text);
        }

        private void agregarproductosaventa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrarVentana && e.CloseReason == CloseReason.UserClosing)
            {
                // Cancelar el cierre de la ventana
                e.Cancel = true;
            }
        }
    }
}
