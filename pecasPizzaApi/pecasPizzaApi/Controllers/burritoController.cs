using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Http;
using pecasPizzaApi.Models.Burrito;
using static pecasPizzaApi.Models.Burrito.csEstructuraBurrito;

namespace pecasPizzaApi.Controllers
{
    public class burritoController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarBurrito")]
        public IHttpActionResult insertarBurrito(requestBurrito model)
        {
            return Ok(new csBurrito().insertarBurrito(model.id_burrito, model.nombre_burrito, model.descp_burrito, model.precio));
        }

        [HttpPost]
        [Route("rest/api/actualizarBurrito")]
        public IHttpActionResult actualizarBurrito(requestBurrito model)
        {
            return Ok(new csBurrito().actualizarBurrito(model.id_burrito, model.nombre_burrito, model.descp_burrito, model.precio));
        }

        [HttpGet]
        [Route("rest/api/eliminarBurrito")]
        public IHttpActionResult eliminarBurrito(requestEliminarBurrito model)
        {
            return Ok(new csBurrito().eliminarBurrito(model.id_burrito));
        }

        [HttpGet]
        [Route("rest/api/listarBurritos")]
        public IHttpActionResult listarBurritos()
        {
            return Ok(new csBurrito().listarBurritos());
        }

        [HttpGet]
        [Route("rest/api/listarBurritosXId")]
        public IHttpActionResult listarBurritosXId(int id_burrito)
        {
            return Ok(new csBurrito().listarBurritosXId(id_burrito));
        }
    }
}