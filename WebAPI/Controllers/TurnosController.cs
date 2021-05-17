using Aplicacion.AppTurnos;
using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistencia.DapperConexion.Turno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnosController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TurnoModel>>> ObtenerTurnos()
        {
            return await Mediator.Send(new ConsultarTurnos.Lista());
        }


        [HttpPost]
        public async Task<ActionResult<ResponseOperations>> CrearTurno(CrearTurnos.CrearTurnosParametros data)
        {
            return await Mediator.Send(data);
        }

    }
}