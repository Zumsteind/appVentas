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
    public partial class modificar_eleminar_cliente : Form
    {
        private List<Clientes> listacliente;
        public int id { get; set; }

        public modificar_eleminar_cliente()
        {
            InitializeComponent();
        }

        private void modificar_eleminar_cliente_Load(object sender, EventArgs e)
        {

            NegocioCliente negocio = new NegocioCliente();
            listacliente = negocio.listarclientes();

            if (listacliente.Count > 0)
            {
                dgvlistaclientes.DataSource = listacliente;
            }
            else
            {
                MessageBox.Show("No se encontraron clientes.");
            }


        }

        private void dgvlistaclientes_SelectionChanged(object sender, EventArgs e)
        {
            Clientes clienteseleccionado = (Clientes)dgvlistaclientes.CurrentRow.DataBoundItem;
            id = (int)clienteseleccionado.Id;
            txtnombre.Text = clienteseleccionado.Cliente;
            txtcorreo.Text = clienteseleccionado.Correo;
            txttelefono.Text = clienteseleccionado.Telefono;

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtcorreo.ForeColor != Color.Red)
            {

                NegocioCliente negocio = new NegocioCliente();
                Clientes x = new Clientes();

                //cargamos en un objeto cliente los txt que obtenemos al seleccionar un fila de la tabla. 
                x.Id = id;
                x.Cliente = txtnombre.Text;
                x.Correo = txtcorreo.Text;
                x.Telefono = txttelefono.Text;
                //ese objeto cliente se lo enviamos al metodo modificarcliente del negociocliente.
                if (negocio.modificarCliente(x)) { MessageBox.Show("Cliente Id:" + x.Id + " Fue modificado"); };


                listacliente = negocio.listarclientes();
                dgvlistaclientes.DataSource = listacliente;
            }
            else
            {
                MessageBox.Show("Por favor, verifique el correo electrónico");
            }

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            // Valida que se ingrese un correo electrónico válido
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Regex regex = new Regex(emailPattern);

            if (!regex.IsMatch(txtcorreo.Text))
            {
                txtcorreo.ForeColor = Color.Red; // Cambia el color del texto si no es un correo electrónico válido
            }
            else
            {
                txtcorreo.ForeColor = SystemColors.WindowText; // Restaura el color del texto predeterminado
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite ingresar solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            NegocioCliente negocio = new NegocioCliente();
            Clientes x = new Clientes();

            //cargamos en un objeto cliente los txt que obtenemos al seleccionar un fila de la tabla. 
            x.Id = id;
            x.Cliente = txtnombre.Text;
            x.Correo = txtcorreo.Text;
            x.Telefono = txttelefono.Text;

            // Mostrar el cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el cliente ID: " + x.Id + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // El usuario ha confirmado la eliminación del cliente
                if (negocio.eliminarCliente(x.Id))
                {
                    MessageBox.Show("Cliente eliminado con exito");


                    listacliente = negocio.listarclientes();
                    dgvlistaclientes.DataSource = listacliente;
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente");
                }
            }
            

        }
    }
}
