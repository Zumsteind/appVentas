﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using datos;

namespace negocio
{
    public class NegocioVentas
    {
        private accesoDato datos = new accesoDato();


        public List<Ventas> ListarVentas()
        {
            List<Ventas> lista = new List<Ventas>();

            try
            {
                datos.setearConsulta("SELECT id, idcliente, fecha, total FROM ventas");
                datos.lecturaDatos();

                while (datos.Lector.Read())
                {
                    Ventas venta = new Ventas();
                    venta.id = Convert.ToInt32(datos.Lector["id"]);
                    venta.idcliente = new Clientes() { Id = Convert.ToInt32(datos.Lector["idcliente"]) };
                    venta.fecha = Convert.ToDateTime(datos.Lector["fecha"]);
                    venta.total = Convert.ToSingle(datos.Lector["total"]);

                    lista.Add(venta);
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

        public bool AgregarVenta(Ventas venta)
        {
            try
            {
                datos.setearConsulta("INSERT INTO ventas (idcliente, fecha, total) VALUES (@idcliente, @fecha, @total)");
                datos.SetearParametro("@idcliente", venta.idcliente.Id);
                datos.SetearParametro("@fecha", venta.fecha);
                datos.SetearParametro("@total", venta.total);

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

        public bool ModificarVenta(Ventas venta)
        {
            try
            {
                datos.setearConsulta("UPDATE ventas SET idcliente = @idcliente, fecha = @fecha, total = @total WHERE id = @id");
                datos.SetearParametro("@idcliente", venta.idcliente.Id);
                datos.SetearParametro("@fecha", venta.fecha);
                datos.SetearParametro("@total", venta.total);
                datos.SetearParametro("@id", venta.id);

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

        public bool EliminarVenta(int idVenta)
        {
            try
            {
                datos.setearConsulta("DELETE FROM ventas WHERE id = @id");
                datos.SetearParametro("@id", idVenta);

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

        public int ObtenerUltimoIDGenerado()
        {
            int ultimoID = 0;
            try
            {
                datos.setearConsulta("SELECT MAX(id) FROM ventas");
                datos.lecturaDatos();

                if (datos.Lector.Read() && !datos.Lector.IsDBNull(0))
                {
                    ultimoID = Convert.ToInt32(datos.Lector[0]);
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                datos.cerrarConexion();
            }
            return ultimoID;
        }

        public List<Ventas> ListarVentasconnombre()
        {
            List<Ventas> lista = new List<Ventas>();

            try
            {
                datos.setearConsulta("SELECT v.ID, c.Cliente as cliente, fecha, total FROM ventas as v inner join clientes c on v.IDCliente=c.ID");
                datos.lecturaDatos();

                while (datos.Lector.Read())
                {
                    Ventas venta = new Ventas();
                    Clientes cliente = new Clientes();
                    venta.id = Convert.ToInt32(datos.Lector["id"]);
                    cliente.Cliente = datos.Lector["cliente"].ToString();
                    venta.idcliente = cliente; // Asignar la instancia de Clientes a la propiedad idcliente
                    venta.fecha = Convert.ToDateTime(datos.Lector["fecha"]);
                    venta.total = Convert.ToSingle(datos.Lector["total"]);

                    lista.Add(venta);
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
