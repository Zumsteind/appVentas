using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;
using entidades;
using negocio;



namespace vistas
{
    public partial class agregarcliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            Clientes x = new Clientes();
            NegocioCliente negocio = new NegocioCliente();


            x.setcliente(txtcliente.Text);
            x.settelefono(txttelefono.Text);
            x.setcorreo(txtcorreo.Text);

            if (negocio.agregarcliente(x))
            {
                string script = "alert('Cliente agregado correctamente.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);

                //limpia los txt
                txtcliente.Text = string.Empty;
                txttelefono.Text = string.Empty;
                txtcorreo.Text = string.Empty;


            }
            else
            {
                string script = "alert('Error al agregar el cliente.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
            

        }
    }
}