using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pecasPizzaApi.Models.Canoa
{
    public class csEstructuraCanoa
    {
        public class requestCanoa
        {
            public int id_canoas { get; set; }
            public string nombre_canoa { get; set; }
            public string descp_canoa { get; set; }
            public double precio { get; set; }
        }
        public class responseCanoa
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarCanoa
        {
            public int id_canoas { get; set; }
        }
    }
}