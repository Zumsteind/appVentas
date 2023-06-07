using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using datos;




namespace negocio
{
    public class NegocioCliente
    {

       
            private accesoDato datos = new accesoDato();

            public List<Clientes> listarclientes()
            {
                List<Clientes> lista = new List<Clientes>();

                try
                {
                    datos.setearConsulta("select ID, Cliente, Telefono, Correo from clientes");

                    datos.lecturaDatos();

                    while (datos.Lector.Read())
                    {
                        Clientes aux = new Clientes();
                        aux.Id = (int)datos.Lector["ID"];
                        aux.Cliente = (string)datos.Lector["Cliente"];
                        aux.Telefono = (string)datos.Lector["Telefono"];
                        aux.Correo = (string)datos.Lector["Correo"];

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

            public bool agregarcliente(Clientes cliente)
            {
                try
                {
                    datos.setearConsulta("Insert into clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)");
                    datos.SetearParametro("@Cliente", cliente.Cliente);
                    datos.SetearParametro("@Telefono", cliente.Telefono);
                    datos.SetearParametro("@Correo", cliente.Correo);

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

            public void modificarCliente(Clientes cliente)
            {
                try
                {
                    datos.setearConsulta("UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID");
                    datos.SetearParametro("@Cliente", cliente.Cliente);
                    datos.SetearParametro("@Telefono", cliente.Telefono);
                    datos.SetearParametro("@Correo", cliente.Correo);
                    datos.SetearParametro("@ID", cliente.Id);

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

            public void eliminarCliente(int idCliente)
            {
                try
                {
                    datos.setearConsulta("DELETE FROM clientes WHERE ID = @ID");
                    datos.SetearParametro("@ID", idCliente);

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

