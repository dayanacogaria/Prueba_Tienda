using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace notas.Conexion
{
    public class ConexionDB
    {

        private SqlConnection con;
        public static ConexionDB cnn;

        public ConexionDB()
        {
            
            String cadenaConexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(cadenaConexion);
        }

        public SqlConnection getConexion()
        {
            return con;
        }

        public void cerrarConexion()
        {
            con.Close();
            cnn = null;
        }

        public void abrirConexion()
        {
            con.Open();
        }


    }
}