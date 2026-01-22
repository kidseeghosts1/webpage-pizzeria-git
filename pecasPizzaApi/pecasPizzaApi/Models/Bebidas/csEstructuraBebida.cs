using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pecasPizzaApi.Models.Bebidas
{
    public class csEstructuraBebida
    {
        public class requestBebida
        {
            public int id_bebida { get; set; }
            public string nombre_bebida { get; set; }
            public string descp_bebida { get; set; }
            public double precio { get; set; }
        }
        public class responseBebida
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarBebida
        {
            public int id_bebida { get; set; }
        }
    }
}