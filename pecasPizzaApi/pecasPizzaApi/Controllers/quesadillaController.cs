using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using pecasPizzaApi.Models.Quesadilla;
using static pecasPizzaApi.Models.Quesadilla.csEstructuraQuesadilla;

namespace pecasPizzaApi.Controllers
{
    public class quesadillaController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarQuesadilla")]
        public IHttpActionResult insertarQuesadilla(requestQuesadilla model)
        {
            return Ok(new csQuesadilla().insertarQuesadilla(model.id_quesadilla, model.nombre_quesadilla, model.descp_quesadilla, model.precio));
        }

        [HttpPost]
        [Route("rest/api/actualizarQuesadilla")]
        public IHttpActionResult actualizarQuesadilla(requestQuesadilla model)
        {
            return Ok(new csQuesadilla().actualizarQuesadilla(model.id_quesadilla, model.nombre_quesadilla, model.descp_quesadilla, model.precio));
        }

        [HttpPost]
        [Route("rest/api/eliminarQuesadilla")]
        public IHttpActionResult eliminarQuesadilla(requestEliminarQuesadilla model)
        {
            return Ok(new csQuesadilla().eliminarQuesadilla(model.id_quesadilla));
        }

        [HttpGet]
        [Route("rest/api/listarQuesadillas")]
        public IHttpActionResult listarQuesadillas()
        {
            return Ok(new csQuesadilla().listarQuesadillas());
        }

        [HttpGet]
        [Route("rest/api/listarQuesadillasXId")]
        public IHttpActionResult listarQuesadillasXId(int id_quesadilla)
        {
            return Ok(new csQuesadilla().listarQuesadillasXId(id_quesadilla));
        }
    }
}