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
                catch (Exception )
                {
                throw ;
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

            public Boolean modificarCliente(Clientes cliente)
            {
                try
                {
                    datos.setearConsulta("UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID");
                    datos.SetearParametro("@Cliente", cliente.Cliente);
                    datos.SetearParametro("@Telefono", cliente.Telefono);
                    datos.SetearParametro("@Correo", cliente.Correo);
                    datos.SetearParametro("@ID", cliente.Id);

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

            public Boolean eliminarCliente(int idCliente)
            {
                try
                {
                    datos.setearConsulta("DELETE FROM clientes WHERE ID = @ID");
                    datos.SetearParametro("@ID", idCliente);

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


        public List<Clientes> buscarClientes(string filtroCliente)
        {
            List<Clientes> lista = new List<Clientes>();

            try
            {
                string consulta = "SELECT ID, Cliente, Telefono, Correo FROM clientes WHERE Cliente LIKE '%' + @FiltroCliente + '%' OR Correo LIKE '%' + @FiltroCliente + '%'";
                datos.setearConsulta(consulta);
                datos.SetearParametro("@FiltroCliente", filtroCliente);

                datos.lecturaDatos();

                while (datos.Lector.Read())
                {
                    Clientes cliente = new Clientes();
                    cliente.Id = Convert.ToInt32(datos.Lector["ID"]);
                    cliente.Cliente = datos.Lector["Cliente"].ToString();
                    cliente.Telefono = datos.Lector["Telefono"].ToString();
                    cliente.Correo = datos.Lector["Correo"].ToString();

                    lista.Add(cliente);
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

    }


}

