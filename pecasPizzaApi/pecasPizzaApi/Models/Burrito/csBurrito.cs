using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using static pecasPizzaApi.Models.Burrito.csEstructuraBurrito;

namespace pecasPizzaApi.Models.Burrito
{
    public class csBurrito
    {
        public responseBurrito insertarBurrito( int id_burrito, string nombre_burrito, string descp_burrito, double precio )
        {
            responseBurrito resultado = new responseBurrito();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "INSERT INTO Burrito(nombre_burrito, descp_burrito, precio) VALUES('" + nombre_burrito + "', '" + descp_burrito + "', " + precio + ")";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada con éxito.";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un error con la operación. Descripción del error: " + ex.Message.ToString();
            }

            return resultado;
            con.Close();
        }

        public responseBurrito actualizarBurrito(int id_burrito, string nombre_burrito, string descp_burrito, double precio)
        {
            responseBurrito resultado = new responseBurrito();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "UPDATE Burrito SET nombre_burrito='" + nombre_burrito + "', descp_burrito='" + descp_burrito + "', precio=" + precio + " WHERE id_burrito=" + id_burrito + "";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada con éxito";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un error con la operación. Descripción del error: " + ex.Message.ToString();
            }

            return resultado;
            con.Close();
        }

        public responseBurrito eliminarBurrito(int id_burrito)
        {
            responseBurrito resultado = new responseBurrito();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "DELETE FROM Burrito WHERE id_burrito=" + id_burrito + "";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada con éxito";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un error con la operación. Descripción del error: " + ex.Message.ToString();
            }

            return resultado;
            con.Close();
        }

        public DataSet listarBurritos()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Burrito";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de todos los burritos";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }

            con.Close();
        }

        public DataSet listarBurritosXId(int id_burrito)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Burrito WHERE id_burrito=" + id_burrito + "";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado del burrito con ID: " + id_burrito;
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }

            con.Close();
        }
    }
}