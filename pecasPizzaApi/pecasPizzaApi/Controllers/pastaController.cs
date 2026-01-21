using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using pecasPizzaApi.Models.Pizza;
using static pecasPizzaApi.Models.Pizza.csEstructuraPasta;

namespace pecasPizzaApi.Controllers
{
    public class pastaController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarPasta")]
        public IHttpActionResult insertarPasta(requestPasta model)
        {
            return Ok(new csPasta().insertarPasta(model.id_pasta, model.nombre_pasta, model.descp_pasta, model.precio));
        }

        [HttpPost]
        [Route("rest/api/actualizarPasta")]
        public IHttpActionResult actualizarPasta(requestPasta model)
        {
            return Ok(new csPasta().actualizarPasta(model.id_pasta, model.nombre_pasta, model.descp_pasta, model.precio));
        }

        [HttpPost]
        [Route("rest/api/eliminarPasta")]
        public IHttpActionResult eliminarPasta(requestPasta model)
        {
            return Ok(new csPasta().eliminarPasta(model.id_pasta));
        }

        [HttpGet]
        [Route("rest/api/listarPastas")]
        public IHttpActionResult listarPastas()
        {
            return Ok(new csPasta().listarPastas());
        }

        [HttpGet]
        [Route("rest/api/listarPastaXId")]
        public IHttpActionResult listarPastaXId(int id_pasta)
        {
            return Ok(new csPasta().listarPastaXid(id_pasta));
;        }
    }
}