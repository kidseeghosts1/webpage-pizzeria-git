using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pecasPizzaApi.Models.Pizza
{
    public class csEstructuraPizza
    {
        public class requestPizza // Estructura para recibir datos de una nueva pizza
        {
            public int id_pizza { get; set; }
            public string nombre_pizza { get; set; }
            public string descp_pizza { get; set; }
            public double precio { get; set; }
        }

        public class responsePizza
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }

        public class requestEliminarPizza
        {
            public int id_pizza { get; set; }
        }
    }
}