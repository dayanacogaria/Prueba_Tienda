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
    public class FiltroServices
    {

        ConexionDB con = new ConexionDB();
        //listar lineas tipi 4
        public List<FiltroModels> listsublineas(int idsublinea)
        {
            try
            {
                List<FiltroModels> lista = new List<FiltroModels>();
                //SqlConnection cnn = con.abrirConexion();
                SqlConnection cnn = con.getConexion();
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
                SqlCommand cmd = new SqlCommand("select sublinea,categoria,producto from [Tienda].[dbo].[sublinea] s inner join categoria c on s.id_sublinea = c.id_sublinea  inner join Producto p on p.id_categoria = c.id_categoria  where s.id_sublinea = @id", cnn);
               
                cmd.Parameters.AddWithValue("@id", idsublinea);

                SqlDataReader Rs = cmd.ExecuteReader();

                while (Rs.Read())
                {
                    lista.Add(new FiltroModels( Rs.GetString(0), Rs.GetString(1), Rs.GetString(2)));
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




        public List<FiltroModels> listlineas(int idlinea)
        {
            try
            {
                List<FiltroModels> lista = new List<FiltroModels>();
                //SqlConnection cnn = con.abrirConexion();
                SqlConnection cnn = con.getConexion();
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
                SqlCommand cmd = new SqlCommand(" SELECT linea, sublinea,ISNULL( categoria, 'No tiene Categoria') as categoria,ISNULL( producto,'No Tiene Productos') as producto  FROM[Tienda].[dbo].[sublinea] s left join Linea l on s.id_linea = l.id_linea left join categoria c on s.id_sublinea = c.id_sublinea  left join Producto p on p.id_categoria = c.id_categoria  where l.id_linea = @id", cnn);

                cmd.Parameters.AddWithValue("@id", idlinea);

                SqlDataReader Rs = cmd.ExecuteReader();

                while (Rs.Read())
                {
                    lista.Add(new FiltroModels(Rs.GetString(0), Rs.GetString(1), Rs.GetString(2), Rs.GetString(3)));
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


    }
}