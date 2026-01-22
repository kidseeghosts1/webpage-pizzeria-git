using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using pecasPizzaApi.Models.Bebidas;
using static pecasPizzaApi.Models.Bebidas.csEstructuraBebida;

namespace pecasPizzaApi.Models.Bebidas
{
    public class csBebida
    {
        public responseBebida insertarBebida(int id_bebida, string nombre_bebida, string descp_bebida, double precio)
        {
            responseBebida resultado = new responseBebida();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "INSERT INTO Bebida(nombre_bebida, descp_bebida, precio) VALUES ('" + nombre_bebida + "', '" + descp_bebida + "', " + precio + ") ";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un problema al realizar la operación. Descripción del error: " + ex.Message.ToString();
            }

            con.Close();
            return resultado;
        }
        public responseBebida actualizarBebida(int id_bebida, string nombre_bebida, string descp_bebida, double precio)
        {
            responseBebida resultado = new responseBebida();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "UPDATE Bebida SET nombre_bebida='" + nombre_bebida + "', descp_bebida='" + descp_bebida + "', precio=" + precio + " WHERE id_bebida=" + id_bebida + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch(Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrio un error al realizar la operación. Descripción del error: " + ex.Message.ToString();
            }

            con.Close();
            return resultado;
        }
        public responseBebida eliminarBebida(int id_bebida)
        {
            responseBebida resultado = new responseBebida();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "DELETE FROM Bebida WHERE id_bebida= " + id_bebida + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);

                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operacion realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrio un problema al realizar la operación. Descripción del error: " + ex.Message.ToString();
            }

            con.Close();
            return resultado;
        }
        public DataSet listarBebidas()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Bebida";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de todas las bebidas disponibles";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }

            con.Close();
        }
        public DataSet listarBebidaXId(int id_bebida)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Bebida WHERE id_bebida= " + id_bebida + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de la bebida con ID: " + id_bebida + " ";

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