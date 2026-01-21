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
            return Ok(new csPizza().insertarPizza(model.nombre_pizza, model.descp_pizza, model.precio));
        }

        [HttpPost]
        [Route("rest/api/actualizarPizza")]
        public IHttpActionResult actualizarPizza(requestPizza model)
        {
            return Ok(new csPizza().actualizarPizza(model.id_pizza, model.nombre_pizza, model.descp_pizza, model.precio));
        }

        [HttpPost]
        [Route("rest/api/eliminarPizza")]
        public IHttpActionResult eliminarPizza(requestEliminarPizza model)
        {
            return Ok(new csPizza().eliminarPizza(model.id_pizza));
        }
        [HttpGet]
        [Route("rest/api/listarPizzas")]
        public IHttpActionResult listarPizzas()
        {
            return Ok(new csPizza().listarPizzas());
        }
        [HttpGet]
        [Route("rest/api/listarPizzasID")]
        public IHttpActionResult listarPizzasID(int id_pizza)
        {
            return Ok(new csPizza().listarPizzasID(id_pizza));
        }
    }
}