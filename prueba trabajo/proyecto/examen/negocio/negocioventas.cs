using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using datos;

namespace negocio
{
    public class NegocioVentasItems
    {
        private accesoDato datos = new accesoDato();

        public List<Ventasitems> ListarVentasItems()
        {
            List<Ventasitems> lista = new List<Ventasitems>();

            try
            {
                datos.setearConsulta("SELECT ID, IDVentas, IDProducto, PrecioUnitario, Cantidad FROM Ventasitems");
                datos.lecturaDatos();

                while (datos.Lector.Read())
                {
                    Ventasitems aux = new Ventasitems();
                    aux.id = (int)datos.Lector["ID"];
                    aux.idventas = new Ventas() { id = (int)datos.Lector["IDVentas"] };

                    // Crear objeto Producto y establecer su propiedad Id utilizando el método SetId()
                    Producto producto = new Producto();
                    producto.Id=((int)datos.Lector["IDProducto"]);
                    aux.idproducto = producto;

                    aux.preciounitario = (float)datos.Lector["PrecioUnitario"];
                    aux.cantidad = (float)datos.Lector["Cantidad"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool AgregarVentaItem(Ventasitems ventaItem)
        {
            try
            {
                datos.setearConsulta("INSERT INTO Ventasitems (IDVentas, IDProducto, PrecioUnitario, Cantidad) VALUES (@IDVentas, @IDProducto, @PrecioUnitario, @Cantidad)");
                datos.SetearParametro("@IDVentas", ventaItem.idventas.id);
                datos.SetearParametro("@IDProducto", ventaItem.idproducto.Id);
                datos.SetearParametro("@PrecioUnitario", ventaItem.preciounitario);
                datos.SetearParametro("@Cantidad", ventaItem.cantidad);

                datos.ejecutarAccion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarVentaItem(Ventasitems ventaItem)
        {
            try
            {
                datos.setearConsulta("UPDATE Ventasitems SET IDVentas = @IDVentas, IDProducto = @IDProducto, PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad WHERE ID = @ID");
                datos.SetearParametro("@IDVentas", ventaItem.idventas.id);
                datos.SetearParametro("@IDProducto", ventaItem.idproducto.Id);
                datos.SetearParametro("@PrecioUnitario", ventaItem.preciounitario);
                datos.SetearParametro("@Cantidad", ventaItem.cantidad);
                datos.SetearParametro("@ID", ventaItem.id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
