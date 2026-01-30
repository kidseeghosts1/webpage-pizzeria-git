using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static pecasPizzaApi.Models.Piola.csEstructuraPiola;

namespace pecasPizzaApi.Models.Piola
{
    public class csPiola
    {
        public responsePiola insertarPiola(int id_piola, string nombre_piola, string descp_piola, double precio)
        {
            responsePiola resultado = new responsePiola();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "INSERT INTO Piola(nombre_piola, descp_piola, precio) VALUES('" + nombre_piola + "', '" + descp_piola + "', " + precio + ")";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada con éxito";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un error en la operación. Detalle del error: " + ex.Message.ToString();
            }
            con.Close();
            return resultado;
        }

        public responsePiola actualizarPiola(int id_piola, string nombre_piola, string descp_piola, double precio)
        {
            responsePiola resultado = new responsePiola();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "UPDATE Piola SET nombre_piola='" + nombre_piola + "', descp_piola='" + descp_piola + "', precio=" + precio + " WHERE id_piola=" + id_piola + "";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada con éxito";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un error en la operación. Detalle del error: " + ex.Message.ToString();
            }
            con.Close();
            return resultado;
        }

        public responsePiola eliminarPiola(int id_piola)
        {
            responsePiola resultado = new responsePiola();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "DELETE FROM Piola WHERE id_piola=" + id_piola + "";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada con éxito";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un error en la operación. Detalle del error: " + ex.Message.ToString();
            }
            con.Close();
            return resultado;
        }

        public DataSet listarPiolas()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Piola";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de todas las Piolas disponibles";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }
            con.Close();
        }

        public DataSet listarPiolasXId(int id_piola)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Piola WHERE id_piola=" + id_piola + "";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de la Piola con ID: " + id_piola;
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