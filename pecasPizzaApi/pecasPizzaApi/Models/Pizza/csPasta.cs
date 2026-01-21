using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static pecasPizzaApi.Models.Pizza.csEstructuraPasta;

namespace pecasPizzaApi.Models.Pizza
{
    public class csPasta
    {
        public responsePasta insertarPasta(int id_pasta, string nombre_pasta, string descp_pasta, double precio)
        {
            responsePasta resultado = new responsePasta();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "INSERT INTO Pasta(nombre_pasta, descp_pasta, precio) VALUES ('" + nombre_pasta + "', '" + descp_pasta + "', " + precio + " ) ";

                SqlCommand cmd = new SqlCommand(cadena, con);
                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un problema al realizar la operación, descripción de la respuesta: " + ex.Message.ToString();
            }

            con.Close();
            return resultado;

        }
        public responsePasta actualizarPasta(int id_pasta, string nombre_pasta, string descp_pasta, double precio)
        {
            responsePasta resultado = new responsePasta();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "UPDATE Pasta SET nombre_pasta= '" + nombre_pasta + "', descp_pasta= '" + descp_pasta + "', precio= " + precio + " WHERE id_pasta= " + id_pasta + " ";
                SqlCommand cmd = new SqlCommand(cadena, con);
                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrió un problema al realizar la operación, descripcion de la respuesta: " + ex.Message.ToString();
            }

            con.Close();
            return resultado;
        }
        public responsePasta eliminarPasta(int id_pasta)
        {
            responsePasta resultado = new responsePasta();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();

                string cadena = "DELETE FROM ¨Pasta WHERE id_pasta= '" + id_pasta + "' ";
                SqlCommand cmd = new SqlCommand(cadena, con);
                resultado.respuesta = cmd.ExecuteNonQuery();
                resultado.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0;
                resultado.descripcion_respuesta = "Ocurrio un problema al realizar la operación, descripción de la respuesta: " + ex.Message.ToString();
            }

            con.Close();
            return resultado;
        }
        public DataSet listarPastas()
        {
            DataSet dsi = new DataSet();                
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Pasta";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de todas las pastas disponibles";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }

            con.Close();
        }
        public DataSet listarPastaXid(int id_pasta)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Pasta WHERE id_pasta= '" + id_pasta + "' ";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de la pasta con id: '" + id_pasta + "' ";
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