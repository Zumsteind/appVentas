using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using entidades;
using negocio;

namespace vistas
{
    public partial class agregarproductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {

            Producto x = new Producto();
            NegocioProducto negocio = new NegocioProducto();

            x.setnombre(txtnombre.Text);
            x.setprecio( float.Parse( txtprecio.Text));
            x.setcategoria(txtcategoria.Text);

            if (negocio.agregarProducto(x))
            {

                string script = "alert('Producto agregado correctamente.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);

                txtnombre.Text = string.Empty;
                txtprecio.Text = string.Empty;
                txtcategoria.Text = string.Empty;


            }
            else {

                string script = "alert('Error al agregar el Producto.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);

            }

        }
    }
}