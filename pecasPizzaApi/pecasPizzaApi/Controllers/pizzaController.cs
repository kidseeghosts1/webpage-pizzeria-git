using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using pecasPizzaApi.Models.Pizza;
using static pecasPizzaApi.Models.Pizza.csEstructuraPizza;

namespace pecasPizzaApi.Controllers
{
    public class pizzaController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarPizza")]
        public IHttpActionResult insertarPizza(requestPizza model) // Estructura para insertar una nueva pizza (recibe como parametro la estructura que recibe los datos - clase - )
        {
            // Lógica para insertar la pizza en la base de datos
            return Ok(new csPizza().insertarPizza(model.nombrePizza, model.descp_pizza, model.precio));
        }
    }
}