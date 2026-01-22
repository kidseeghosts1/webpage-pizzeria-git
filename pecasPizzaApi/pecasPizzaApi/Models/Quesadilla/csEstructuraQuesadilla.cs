using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pecasPizzaApi.Models.Quesadilla
{
    public class csEstructuraQuesadilla
    {
        public class requestQuesadilla
        {
            public int id_quesadilla { get; set; }
            public string nombre_quesadilla { get; set; }
            public string descp_quesadilla { get; set; }
            public double precio { get; set; }
        }
        public class responseQuesadilla
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarQuesadilla
        {
            public int id_quesadilla { get; set; }
        }
    }
}