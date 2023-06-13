using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace datos
{
    public class accesoDato
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector { get { return lector; } }


        public accesoDato()
        {

            
            //de esta forma le ponemos el string de la base de datos para que haga la instancia desde app.config 
            string connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            conexion = new SqlConnection(connectionString);

            comando = new SqlCommand();

        }

        public void setearConsulta(String consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void setearSP(string sp)
        {

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;
        }

        public void lecturaDatos()
        {
            comando.Connection = conexion;
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open) conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

        public void SetearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }

}

