using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using datos;

namespace negocio
{
    public  class negocioventasitems
    {
        private accesoDato datos = new accesoDato();

        public List<Ventasitems> listarVentasitems()
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
                    aux.idproducto = new Producto();
                    aux.idproducto.Id=((int)datos.Lector["IDProducto"]);
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

        public bool agregarVentaitem(Ventasitems ventaitem)
        {
            try
            {
                datos.setearConsulta("INSERT INTO Ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad,PrecioTotal) VALUES (@IDVentas, @IDProducto, @PrecioUnitario, @Cantidad,@preciototal)");
                datos.SetearParametro("@IDVentas", ventaitem.idventas.id);
                datos.SetearParametro("@IDProducto", ventaitem.idproducto.Id);
                datos.SetearParametro("@PrecioUnitario", ventaitem.preciounitario);
                datos.SetearParametro("@Cantidad", ventaitem.cantidad);
                datos.SetearParametro("@preciototal", ventaitem.cantidad*ventaitem.preciounitario);

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

        public void modificarVentaitem(Ventasitems ventaitem)
        {
            try
            {
                datos.setearConsulta("UPDATE Ventasitems SET IDVentas = @IDVentas, IDProducto = @IDProducto, PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad WHERE ID = @ID");
                datos.SetearParametro("@IDVentas", ventaitem.idventas.id);
                datos.SetearParametro("@IDProducto", ventaitem.idproducto.Id);
                datos.SetearParametro("@PrecioUnitario", ventaitem.preciounitario);
                datos.SetearParametro("@Cantidad", ventaitem.cantidad);
                datos.SetearParametro("@ID", ventaitem.id);

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

        public void eliminarVentaitem(int idVentaitem)
        {
            try
            {
                datos.setearConsulta("DELETE FROM Ventasitems WHERE ID = @ID");
                datos.SetearParametro("@ID", idVentaitem);

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
