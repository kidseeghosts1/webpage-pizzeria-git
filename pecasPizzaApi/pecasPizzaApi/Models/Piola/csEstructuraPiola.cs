using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pecasPizzaApi.Models.Piola
{
    public class csEstructuraPiola
    {
        public class requestPiola
        {
            public int id_piola { get; set; }
            public string nombre_piola { get; set; }
            public string descp_piola { get; set; }
            public double precio { get; set; }
        }
        public class responsePiola
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarPiola
        {
            public int id_piola { get; set; }
        }
    }
}