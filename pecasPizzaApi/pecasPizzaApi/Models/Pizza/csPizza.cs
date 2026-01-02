using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using static pecasPizzaApi.Models.Pizza.csEstructuraPizza;

namespace pecasPizzaApi.Models.Pizza
{
    public class csPizza
    {
        public responsePizza insertarPizza(string nombre_pizza, string descp_pizza, double precio) // Se creó una clase de tipo responsePizza para devolver la respuesta del servicio (devuelve 2 valores)
        {
            responsePizza resultado = new responsePizza(); // Se instancia la clase responsePizza
            string conexion = "";
            SqlConnection cn = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString; // Cadena de conexión a la base de datos desde el archivo Web.config
                cn = new SqlConnection(conexion);  // Se instancia una conexion de tipo SqlConnection y se le pasa la cadena de conexión
                cn.Open(); // Se abre la conexión a la base de datos

                string cadena = "INSERT INTO Pizza(nombre_pizza, descp_pizza, precio) values " +
                    "('" + nombre_pizza + "', '" + descp_pizza + "', " + precio + ")"; // Sentencia SQL para insertar una nueva pizza en la tabla Pizza

                SqlCommand cmd = new SqlCommand(cadena, cn); // Se instancia un comando SQL y se le pasa la sentencia SQL y la conexión
                resultado.respuesta = cmd.ExecuteNonQuery(); // Se ejecuta el comando SQL y se almacena el resultado en la variable respuesta de la clase responsePizza
                resultado.descripcion_respuesta = "Operación realizada exitosamente"; // Se asigna un mensaje de éxito a la variable descripcion_respuesta de la clase responsePizza
            }
            catch(Exception ex)
            {
                resultado.respuesta = 0; // En caso de error, se asigna 0 a la variable respuesta de la clase responsePizza
                resultado.descripcion_respuesta = "Ocurrió un error al realizar la operación, descripción del error: " + ex.Message.ToString(); // Se asigna un mensaje de error a la variable descripcion_respuesta de la clase responsePizza
            }

            cn.Close(); // Se cierra la conexión a la base de datos
            return resultado; // Se devuelve el resultado de la operación

        }
        public responsePizza actualizarPizza(int id_pizza, string nombre_pizza, string descp_pizza, double precio) // Se creó una clase de tipo responsePizza para devolver la respuesta del servicio (devuelve 2 valores)
        {
            responsePizza resultado = new responsePizza(); // Se instancia la clase responsePizza
            string conexion = "";
            SqlConnection cn = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString; // Cadena de conexión a la base de datos desde el archivo Web.config
                cn = new SqlConnection(conexion);  // Se instancia una conexion de tipo SqlConnection y se le pasa la cadena de conexión
                cn.Open(); // Se abre la conexión a la base de datos

                string cadena = "UPDATE Pizza SET nombre_pizza= '" + nombre_pizza + "', descp_pizza= '" + descp_pizza + "', precio= " + precio + " " +
                    "WHERE id_pizza= " + id_pizza + " "; // Sentencia SQL para actualizar una pizza en la tabla Pizza

                SqlCommand cmd = new SqlCommand(cadena, cn); // Se instancia un comando SQL y se le pasa la sentencia SQL y la conexión
                resultado.respuesta = cmd.ExecuteNonQuery(); // Se ejecuta el comando SQL y se almacena el resultado en la variable respuesta de la clase responsePizza
                resultado.descripcion_respuesta = "Operación realizada exitosamente"; // Se asigna un mensaje de éxito a la variable descripcion_respuesta de la clase responsePizza
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0; // En caso de error, se asigna 0 a la variable respuesta de la clase responsePizza
                resultado.descripcion_respuesta = "Ocurrió un error al realizar la operación, descripción del error: " + ex.Message.ToString(); // Se asigna un mensaje de error a la variable descripcion_respuesta de la clase responsePizza
            }

            cn.Close(); // Se cierra la conexión a la base de datos
            return resultado; // Se devuelve el resultado de la operación

        }
        public responsePizza eliminarPizza(int id_pizza) // Se creó una clase de tipo responsePizza para devolver la respuesta del servicio (devuelve 2 valores)
        {
            responsePizza resultado = new responsePizza(); // Se instancia la clase responsePizza
            string conexion = "";
            SqlConnection cn = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString; // Cadena de conexión a la base de datos desde el archivo Web.config
                cn = new SqlConnection(conexion);  // Se instancia una conexion de tipo SqlConnection y se le pasa la cadena de conexión
                cn.Open(); // Se abre la conexión a la base de datos

                string cadena = "DELETE FROM Pizza WHERE id_pizza= " + id_pizza + " "; // Sentencia SQL para actualizar una pizza en la tabla Pizza

                SqlCommand cmd = new SqlCommand(cadena, cn); // Se instancia un comando SQL y se le pasa la sentencia SQL y la conexión
                resultado.respuesta = cmd.ExecuteNonQuery(); // Se ejecuta el comando SQL y se almacena el resultado en la variable respuesta de la clase responsePizza
                resultado.descripcion_respuesta = "Operación realizada exitosamente"; // Se asigna un mensaje de éxito a la variable descripcion_respuesta de la clase responsePizza
            }
            catch (Exception ex)
            {
                resultado.respuesta = 0; // En caso de error, se asigna 0 a la variable respuesta de la clase responsePizza
                resultado.descripcion_respuesta = "Ocurrió un error al realizar la operación, descripción del error: " + ex.Message.ToString(); // Se asigna un mensaje de error a la variable descripcion_respuesta de la clase responsePizza
            }

            cn.Close(); // Se cierra la conexión a la base de datos
            return resultado; // Se devuelve el resultado de la operación

        }
        public DataSet listarPizzas()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try {
                string cadena = "SELECT * FROM Pizza"; // Sentencia SQL para listar todas las pizzas en la tabla Pizza
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Listado de todas las pizzas disponibles";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataSet listarPizzasID(int id_pizza)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "SELECT * FROM Pizza WHERE id_pizza= " + id_pizza + " "; // Sentencia SQL para listar todas las pizzas en la tabla Pizza
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Pizza:";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}