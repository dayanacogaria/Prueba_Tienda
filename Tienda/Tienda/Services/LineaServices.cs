using notas.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tienda.Models;

namespace Tienda.Services
{
    public class LineaServices
    {
        ConexionDB con = new ConexionDB();
        //listar lineas tipi 4
        public List<LineaModels> listmaterias()
        {
            try
            {
                List<LineaModels> lista = new List<LineaModels>();
                //SqlConnection cnn = con.abrirConexion();
                SqlConnection cnn = con.getConexion();
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
                SqlCommand cmd = new SqlCommand("crudlinea", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", 4);
              
                SqlDataReader Rs = cmd.ExecuteReader();

                while (Rs.Read())
                {
                    lista.Add(new LineaModels(Rs.GetInt32(0), Rs.GetString(1)));
                }
                return lista;
            }
            catch (SqlException e)
            {
                e.ToString();
            }
            finally
            {
                con.cerrarConexion();
            }
            return null;
        }


        //create - edit - delete
        //tipo 1-   2-     3

        public Boolean updateandSaveData(int tipo, int id, String linea)
        {
            try
            {
                //SqlConnection cnn = con.abrirConexion();
                SqlConnection cnn = con.getConexion();
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();

                }
                SqlCommand cmd = new SqlCommand("crudlinea", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@linea", @linea);
          

                int cont = cmd.ExecuteNonQuery();


                if (cont > 0)
                {
                    return true;
                }
            }
            catch (SqlException e)
            {
                e.ToString();
            }
            catch (ArgumentOutOfRangeException e)
            {
                e.ToString();
            }
            finally
            {
                con.cerrarConexion();
            }
            return false;
        }





    }
}