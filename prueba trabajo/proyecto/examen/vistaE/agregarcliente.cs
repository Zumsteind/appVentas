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
    public partial class agregarcliente : Form
    {

        public agregarcliente()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            // Verificamos que los TextBox contengan algo
            if (string.IsNullOrWhiteSpace(txtcliente.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de cliente.");
                return; // No se realiza la acción de agregar
            }

            if (string.IsNullOrWhiteSpace(txttelefono.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono.");
                return; // No se realiza la acción de agregar
            }

            if (string.IsNullOrWhiteSpace(txtcorreo.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico.");
                return; // No se realiza la acción de agregar
            }

            Clientes cliente = new Clientes();
            NegocioCliente negocio = new NegocioCliente();

            cliente.Cliente = txtcliente.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Correo = txtcorreo.Text;

            if (txtcorreo.ForeColor != Color.Red)
            {
                if (negocio.agregarcliente(cliente))
                {
                    MessageBox.Show("Cliente agregado con éxito");
                    txtcliente.Text = string.Empty;
                    txttelefono.Text = string.Empty;
                    txtcorreo.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("No se pudo agregar cliente");
                }
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

        private void agregarcliente_Load(object sender, EventArgs e)
        {

        }

    }
}
