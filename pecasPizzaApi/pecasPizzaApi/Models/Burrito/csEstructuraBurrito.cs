using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pecasPizzaApi.Models.Burrito
{
    public class csEstructuraBurrito
    {
        public class requestBurrito
        {
            public int id_burrito { get; set; }
            public string nombre_burrito { get; set; }
            public string descp_burrito { get; set; }
            public double precio { get; set; }
        }
        public class responseBurrito
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarBurrito 
        {
            public int id_burrito { get; set; }      
        }
    }
}