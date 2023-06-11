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
    public partial class listar_ventas : Form
    {
        public static int IdVenta { get; set; } = -1;

        public listar_ventas()
        {
            InitializeComponent();
           
           
        }

        private void listar_ventas_Load(object sender, EventArgs e)
        {
            NegocioVentas negocio = new NegocioVentas();
            List<Ventas> listaVentas = negocio.ListarVentasconnombre();

           
            // Configurar las columnas manualmente
            dgvventas.Columns.Add("id", "ID");
            dgvventas.Columns.Add("cliente", "Cliente");
            dgvventas.Columns.Add("fecha", "Fecha");
            dgvventas.Columns.Add("total", "Total");

            // Asignar los datos a la grilla
            foreach (Ventas venta in listaVentas)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvventas);

                // Asignar los valores a las celdas
                fila.Cells[0].Value = venta.id;
                fila.Cells[1].Value = venta.idcliente.Cliente;
                fila.Cells[2].Value = venta.fecha;
                fila.Cells[3].Value = venta.total;

                // Agregar la fila a la grilla
                dgvventas.Rows.Add(fila);
            }
            


        }

        private void dtpfechaventa_ValueChanged(object sender, EventArgs e)
        {
            FiltrarVentasPorFecha(dtpfechaventa.Value);
        }

        private void FiltrarVentasPorFecha(DateTime fecha)
        {
            NegocioVentas negocio = new NegocioVentas();
            List<Ventas> listaVentas = negocio.ListarVentasconnombre().Where(v => v.fecha.Date == fecha.Date).ToList();

            dgvventas.Rows.Clear(); // Limpia los datos existentes en la grilla

            // Agregar las filas filtradas a la grilla
            foreach (Ventas venta in listaVentas)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvventas);

                fila.Cells[0].Value = venta.id;
                fila.Cells[1].Value = venta.idcliente.Cliente;
                fila.Cells[2].Value = venta.fecha;
                fila.Cells[3].Value = venta.total;

                dgvventas.Rows.Add(fila);
            }
        }

        private void btvverproductosdeventa_Click(object sender, EventArgs e)
        {
            ListadeProductosvendidos ventana = new ListadeProductosvendidos();
            ventana.ShowDialog();
        }

        private void dgvventas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvventas.CurrentRow != null)
            {
                // Obtenemos el valor de la primera columna de la fila seleccionada
                int idVentaSeleccionada = (int)dgvventas.CurrentRow.Cells[0].Value;

                // Asignar el valor a la propiedad estática IdVenta
                IdVenta = idVentaSeleccionada;

                // Mostrar el valor en el control Label
                lblidventa.Text = idVentaSeleccionada.ToString();
            }
        }
    }
}
