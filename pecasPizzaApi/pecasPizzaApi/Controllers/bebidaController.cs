using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using pecasPizzaApi.Models.Bebidas;
using static pecasPizzaApi.Models.Bebidas.csEstructuraBebida;

namespace pecasPizzaApi.Controllers
{
    public class bebidaController : ApiController
    {
        // Aquí irán los métodos para manejar las solicitudes HTTP relacionadas con las bebidas
        [HttpPost]
        [Route("rest/api/insertarBebida")]
        public IHttpActionResult insertarBebida(requestBebida model)
        {
            return Ok(new csBebida().insertarBebida(model.id_bebida, model.nombre_bebida, model.descp_bebida, model.precio));
        }

        [HttpPost]
        [Route("rest/api/actualizarBebida")]
        public IHttpActionResult actualizarBebida(requestBebida model)
        {
            return Ok(new csBebida().actualizarBebida(model.id_bebida, model.nombre_bebida, model.descp_bebida, model.precio));
        }

        [HttpPost]
        [Route("rest/api/eliminarBebida")]
        public IHttpActionResult eliminarBebida(requestEliminarBebida model)
        {
            return Ok(new csBebida().eliminarBebida(model.id_bebida));
        }

        [HttpGet]
        [Route("rest/api/listarBebidas")]
        public IHttpActionResult listarBebidas()
        {
            return Ok(new csBebida().listarBebidas());
        }

        [HttpGet]
        [Route("rest/api/listarBebidasXId")]
        public IHttpActionResult listarBebidaXId(int id_bebida)
        {
            return Ok(new csBebida().listarBebidaXId(id_bebida));
        }
    }
}