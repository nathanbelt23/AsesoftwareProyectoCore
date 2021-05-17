using Aplicacion.AppServicios;
using Aplicacion.AppComercio;
using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferencialController : MiControllerBase
    {

        [HttpGet("servicios")]
        public async Task<ActionResult<List<Servicios>>> ObtenerTurnos()
        {
            return await Mediator.Send(new ConsultarServicios.ListaServicios());
        }


        [HttpGet("comercios")]
        public async Task<ActionResult<List<Comercios>>> ObtenerComercios()
        {
            return await Mediator.Send(new ConsultarComercios.ListaComercios());
        }

    }
}
