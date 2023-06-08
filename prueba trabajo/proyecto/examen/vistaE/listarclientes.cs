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
    public partial class listarclientes : Form
    {
        private List<Clientes> clientes;

        public listarclientes()
        {
            InitializeComponent();
        }

        private void listarclientes_Load(object sender, EventArgs e)
        {
           


            NegocioCliente negocio = new NegocioCliente();
          

             clientes = negocio.listarclientes();

            //verifica si las filas de la lista es mayor a 0, queire decir que tiene elementos. y asocia a lista al dgvlistar
            if (clientes.Count > 0)
            {
                dgvlistarcliente.DataSource = clientes;
            }
            else
            {
                MessageBox.Show("No se encontraron clientes.");
            }

           



        }

        private void dgvlistarcliente_SelectionChanged(object sender, EventArgs e)
        {
            //capturamos en un obj cliente, el elemento seleccionado de la grilla, tabla, que lo casteamos a un cliente, ya que sabemos q se esta devolviendo un obj cliente
          Clientes clienteselecionado= (Clientes)dgvlistarcliente.CurrentRow.DataBoundItem;
        }

        private void txtbuscarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {
            NegocioCliente negocio = new NegocioCliente();
            

            dgvlistarcliente.DataSource= negocio.buscarClientes(txtbuscarcliente.Text);

        }
    }
    }


