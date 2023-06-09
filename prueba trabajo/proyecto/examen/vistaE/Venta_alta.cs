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
    public partial class Venta_alta : Form
    {

        public int id{ get; set; }
        public static int IdVentaGenerada { get; private set; }

        public Venta_alta()
        {
            InitializeComponent();
            
        }

        private void Venta_alta_Load(object sender, EventArgs e)
        {
            NegocioCliente negocio = new NegocioCliente();

            dgvcliente.DataSource = negocio.listarclientes();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            NegocioCliente negocio = new NegocioCliente();
            dgvcliente.DataSource = negocio.buscarClientes(txtbuscar.Text);
        }

       

        private void dgvcliente_SelectionChanged(object sender, EventArgs e)
        {
            Clientes clienteseleccionado = (Clientes)dgvcliente.CurrentRow.DataBoundItem;
            id = clienteseleccionado.Id;

            txtidcliente.Text = clienteseleccionado.Id.ToString();
            
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            NegocioVentas negocio = new NegocioVentas();
            Ventas x = new Ventas();
            Clientes cliente = new Clientes();
            cliente.Id = int.Parse(txtidcliente.Text);

            x.idcliente = cliente;
               
            x.fecha = dtpfecha.Value;
            x.total = 0;

            if (negocio.AgregarVenta(x))
            {
                 IdVentaGenerada= negocio.ObtenerUltimoIDGenerado();
                MessageBox.Show("Ahora agregamos producto a la venta");
                agregarproductosaventa ventana = new agregarproductosaventa();
               
                ventana.ShowDialog();

            }
            else { MessageBox.Show("Ocurrio un error en generar venta"); }


            
        }
    }
}
