using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pecasPizzaApi.Models.Pizza
{
    public class csEstructuraPasta
    {
        public class requestPasta // Estructura para recibir datos de una nueva pasta
        {
            public int id_pasta { get; set; }
            public string nombre_pasta { get; set; }
            public string descp_pasta { get; set; } 
            public double precio { get; set; }

        }
        public class responsePasta
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }

        }
        public class requestEliminarPasta
        {
            public int id_pasta { get; set; }
        }
    }
}