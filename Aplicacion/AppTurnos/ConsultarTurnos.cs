using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistencia.DapperConexion.Turno;
using System.Linq;
using Dominio;

namespace Aplicacion.AppTurnos
{
  public  class ConsultarTurnos
    {

        public class Lista : IRequest<List<TurnoModel>> { }

        public class Manejador : IRequestHandler<Lista, List<TurnoModel>>
        {
            private readonly ITurno _turnorRepository;
            public Manejador(ITurno turnorRepository)
            {
                _turnorRepository = turnorRepository;
            }
            public async Task<List<TurnoModel>> Handle(Lista request, CancellationToken cancellationToken)
            {
                var resultado = await _turnorRepository.ConsultarTurnos();
                return resultado.ToList();

            }
        }

    }
}
