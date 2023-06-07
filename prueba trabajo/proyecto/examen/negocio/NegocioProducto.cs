using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using datos;

namespace negocio
{
    public class NegocioProducto
    {
        private accesoDato datos = new accesoDato();

        public List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                datos.setearConsulta("SELECT ID, ISNULL(Nombre, '') as Nombre, ISNULL(Precio, 0.0) as Precio, ISNULL(Categoria, '') as Categoria FROM productos");
                datos.lecturaDatos();

                while (datos.Lector.Read())
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(datos.Lector["ID"]);
                    producto.Nombre = datos.Lector["Nombre"].ToString();
                    producto.Precio = Convert.ToSingle(datos.Lector["Precio"]);
                    producto.Categoria = datos.Lector["Categoria"].ToString();

                    lista.Add(producto);
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

        public bool AgregarProducto(Producto producto)
        {
            try
            {
                datos.setearConsulta("INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)");
                datos.SetearParametro("@Nombre", producto.Nombre);
                datos.SetearParametro("@Precio", producto.Precio);
                datos.SetearParametro("@Categoria", producto.Categoria);

                datos.ejecutarAccion(); ;
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

        public void ModificarProducto(Producto producto)
        {
            try
            {
                datos.setearConsulta("UPDATE productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID");
                datos.SetearParametro("@Nombre", producto.Nombre);
                datos.SetearParametro("@Precio", producto.Precio);
                datos.SetearParametro("@Categoria", producto.Categoria);
                datos.SetearParametro("@ID", producto.Id);

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

        public void EliminarProducto(int idProducto)
        {
            try
            {
                datos.setearConsulta("DELETE FROM productos WHERE ID = @ID");
                datos.SetearParametro("@ID", idProducto);

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