using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static pecasPizzaApi.Models.Quesadilla.csEstructuraQuesadilla;

namespace pecasPizzaApi.Models.Quesadilla
{
    public class csQuesadilla
    {
        public responseQuesadilla insertarQuesadilla(int id_quesadilla, string nombre_quesadilla, string descp_quesadilla, double precio)
        {
            responseQuesadilla resultado = new responseQuesadilla();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "INSERT INTO Quesadilla(nombre_quesadilla, descp_quesadilla, precio) VALUES('" + nombre_quesadilla + "', '" + descp_quesadilla + "', " + precio + ") ";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrio un error al realizar la operación. Descripción del error: " + ex.Message.ToString();
            }

            con.Close();
            return resultado;
        }
        public responseQuesadilla actualizarQuesadilla(int id_quesadilla, string nombre_quesadilla, string descp_quesadilla, double precio)
        {
            responseQuesadilla resultado = new responseQuesadilla();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "UPDATE Quesadilla SET nombre_quesadilla='" + nombre_quesadilla + "', descp_quesadilla='" + descp_quesadilla + "', precio=" + precio + " WHERE id_quesadilla=" + id_quesadilla + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrio un error al realizar la operación. Descripción del error: " + ex.Message.ToString();
            }

            con.Close();
            return resultado;
        }
        public responseQuesadilla eliminarQuesadilla(int id_quesadilla)
        {
            responseQuesadilla resultado = new responseQuesadilla();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "DELETE FROM Quesadilla WHERE id_quesadilla=" + id_quesadilla + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrio un error al realizar la operación. Descripción del error: " + ex.Message.ToString();
            }

            con.Close();
            return resultado;
        }
        public DataSet listarQuesadillas()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Quesadilla";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de todas las Quesadillas disponibles";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }
            con.Close();
        }
        public DataSet listarQuesadillasXId(int id_quesadilla)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Quesadilla WHERE id_quesadilla=" + id_quesadilla + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado la quesadilla con ID: " + id_quesadilla;
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