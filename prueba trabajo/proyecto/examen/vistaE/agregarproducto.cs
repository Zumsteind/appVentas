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
    public partial class agregarproducto : Form
    {
        public agregarproducto()
        {
            InitializeComponent();
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
        }

        private void btbagregar_Click(object sender, EventArgs e)
        {
            // Verificar si cada TextBox contiene algo
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
                return; // No se realiza la acción de agregar
            }

            if (string.IsNullOrWhiteSpace(txtprecio.Text))
            {
                MessageBox.Show("Por favor, ingrese un precio.");
                return; // No se realiza la acción de agregar
            }

            if (string.IsNullOrWhiteSpace(txtcategoria.Text))
            {
                MessageBox.Show("Por favor, ingrese una categoría.");
                return; // No se realiza la acción de agregar
            }

            Producto x = new Producto();
            NegocioProducto negocio = new NegocioProducto();

            x.Nombre = txtnombre.Text;
            x.Precio = float.Parse(txtprecio.Text);
            x.Categoria = txtcategoria.Text;

            if (negocio.AgregarProducto(x))
            {
                MessageBox.Show("Producto agregado con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el producto");
            }
        }

        private void agregarproducto_Load(object sender, EventArgs e)
        {

        }
    }
}