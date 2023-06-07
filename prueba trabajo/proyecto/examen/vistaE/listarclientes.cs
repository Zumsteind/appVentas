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
        public listarclientes()
        {
            InitializeComponent();
        }

        private void listarclientes_Load(object sender, EventArgs e)
        {
            dgvlistarcliente.AutoGenerateColumns = false;

            // Agrega las columnas necesarias al DataGridView
            dgvlistarcliente.Columns.Add("ID", "ID");
            dgvlistarcliente.Columns.Add("Cliente", "Cliente");
            dgvlistarcliente.Columns.Add("Telefono", "Teléfono");
            dgvlistarcliente.Columns.Add("Correo", "Correo");

            // Configura las propiedades DataPropertyName de cada columna
            dgvlistarcliente.Columns["ID"].DataPropertyName = "id";
            dgvlistarcliente.Columns["Cliente"].DataPropertyName = "cliente";
            dgvlistarcliente.Columns["Telefono"].DataPropertyName = "telefono";
            dgvlistarcliente.Columns["Correo"].DataPropertyName = "correo";

            // Establece el DataSource después de configurar las columnas




            NegocioCliente negocio = new NegocioCliente();
          

            List<Clientes> clientes = negocio.listarclientes();

            if (clientes.Count > 0)
            {
                dgvlistarcliente.DataSource = clientes;
            }
            else
            {
                MessageBox.Show("No se encontraron clientes.");
            }

            dgvlistarcliente.DataSource = clientes;



        }

    }
    }


