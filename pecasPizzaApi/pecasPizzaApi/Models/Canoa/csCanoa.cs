using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static pecasPizzaApi.Models.Canoa.csEstructuraCanoa;

namespace pecasPizzaApi.Models.Canoa
{
    public class csCanoa
    {
        public responseCanoa insertarCanoa(int id_canoas, string nombre_canoa, string descp_canoa, double precio)
        {
            responseCanoa resultado = new responseCanoa();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "INSERT INTO Canoa(nombre_canoa, descp_canoa, precio) VALUES ('" + nombre_canoa + "', '" + descp_canoa + "', " + precio + ") ";
                SqlCommand cmd = new SqlCommand(cadena, con);
                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un error al realizar la operación. Descripción del error: " + ex.Message.ToString();
            }
            con.Close();
            return resultado;
        }
        public responseCanoa actualizarCanoa(int id_canoas, string nombre_canoa, string descp_canoa, double precio)
        {
            responseCanoa resultado = new responseCanoa();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "UPDATE Canoa SET nombre_canoa='" + nombre_canoa + "', descp_canoa='" + descp_canoa + "', precio=" + precio + " WHERE id_canoas=" + id_canoas + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);
                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un error al realizar la operación. Descripción del error: " + ex.Message.ToString();
            }
            con.Close();
            return resultado;
        }
        public responseCanoa eliminarCanoa(int id_canoas)
        {
            responseCanoa resultado = new responseCanoa();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "DELETE FROM Canoa WHERE id_canoas=" + id_canoas + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);
                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un error al realizar la operación. Descripción del error: " + ex.Message.ToString();
            }
            con.Close();
            return resultado;
        }
        public DataSet listarCanoas()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Canoa";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de todas las canoas disponibles";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }

            con.Close();
        }
        public DataSet listarCanoasXId(int id_canoas)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Canoa WHERE id_canoas=" + id_canoas + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de la canoa con ID: " + id_canoas;
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