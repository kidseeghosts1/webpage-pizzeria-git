using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using pecasPizzaApi.Models.Piola;
using static pecasPizzaApi.Models.Piola.csEstructuraPiola;

namespace pecasPizzaApi.Controllers
{
    public class piolaController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarPiola")]
        public IHttpActionResult insertarPiola(requestPiola model)
        {
            return Ok(new csPiola().insertarPiola(model.id_piola, model.nombre_piola, model.descp_piola, model.precio));
        }

        [HttpPost]
        [Route("rest/api/actualizarPiola")]
        public IHttpActionResult actualizarPiola(requestPiola model)
        {
            return Ok(new csPiola().actualizarPiola(model.id_piola, model.nombre_piola, model.descp_piola, model.precio));
        }

        [HttpPost]
        [Route("rest/api/eliminarPiola")]
        public IHttpActionResult eliminarPiola(requestEliminarPiola model)
        {
            return Ok(new csPiola().eliminarPiola(model.id_piola));
        }

        [HttpGet]
        [Route("rest/api/listarPiolas")]
        public IHttpActionResult listarPiolas()
        {
            return Ok(new csPiola().listarPiolas());
        }

        [HttpGet]
        [Route("rest/api/listarPiolasXId")]
        public IHttpActionResult listarPiolasXId(int id_piola)
        {
            return Ok(new csPiola().listarPiolasXId(id_piola));
        }
    }
}