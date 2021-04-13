
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
    public class SublineaServices
    {
        ConexionDB con = new ConexionDB();
        //listar lineas tipi 4
        public List<SublineaModels> listsublineas()
        {
            try
            {
                List<SublineaModels> lista = new List<SublineaModels>();
                //SqlConnection cnn = con.abrirConexion();
                SqlConnection cnn = con.getConexion();
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
                SqlCommand cmd = new SqlCommand("crudsublinea", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", 4);

                SqlDataReader Rs = cmd.ExecuteReader();

                while (Rs.Read())
                {
                    lista.Add(new SublineaModels(Rs.GetInt32(0), Rs.GetString(1),Rs.GetInt32(2), Rs.GetString(3)));
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

        public Boolean updateandSaveData(int tipo, int id, String sublinea, int idlinea)
        {
            try
            {
                //SqlConnection cnn = con.abrirConexion();
                SqlConnection cnn = con.getConexion();
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();

                }
                SqlCommand cmd = new SqlCommand("crudsublinea", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@sublinea", sublinea);
                cmd.Parameters.AddWithValue("@idlinea", idlinea);


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