using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using pecasPizzaApi.Models.Canoa;
using static pecasPizzaApi.Models.Canoa.csEstructuraCanoa;

namespace pecasPizzaApi.Controllers
{
    public class canoaController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarCanoa")]
        public IHttpActionResult insertarCanoa(requestCanoa model)
        {
            return Ok(new csCanoa().insertarCanoa(model.id_canoas, model.nombre_canoa, model.descp_canoa, model.precio));
        }

        [HttpPost]
        [Route("rest/api/actualizarCanoa")]
        public IHttpActionResult actualizarCanoa(requestCanoa model)
        {
            return Ok(new csCanoa().actualizarCanoa(model.id_canoas, model.nombre_canoa, model.descp_canoa, model.precio));
        }

        [HttpPost]
        [Route("rest/api/eliminarCanoa")]
        public IHttpActionResult eliminarCanoa(requestEliminarCanoa model)
        {
            return Ok(new csCanoa().eliminarCanoa(model.id_canoas));
        }

        [HttpGet]
        [Route("rest/api/listarCanoas")]
        public IHttpActionResult listarCanoas()
        {
            return Ok(new csCanoa().listarCanoas());
        }

        [HttpGet]
        [Route("rest/api/listarCanoasXId")]
        public IHttpActionResult listarCanoasXId(int id_canoas)
        {
            return Ok(new csCanoa().listarCanoasXId(id_canoas));
        }
    }
}