using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistencia.DapperConexion.Turno;
using System.Linq;
using Dominio;
using System;
using FluentValidation;

namespace Aplicacion.AppTurnos
{
    public class CrearTurnos
    {

        public class CrearTurnosParametros : IRequest<ResponseOperations>
        {

            public DateTime Fecha_Inicio { get; set; }
            public DateTime Fecha_Fin { get; set; }
            public int Servicio { get; set; }


        }


        public class EjecutaValidacion : AbstractValidator<CrearTurnosParametros>
        {
            public EjecutaValidacion()
            {
                RuleFor(x => x.Fecha_Inicio).Must(p => !(p == DateTime.MinValue))
                .WithMessage("DateTime not null");
                RuleFor(x => x.Fecha_Inicio.Date).Must(x => (x >= DateTime.Now.Date)).WithMessage("xx -La fecha de debe ser mayor a la  actual");
               
                RuleFor(x => x.Fecha_Fin).Must(p => !(p == DateTime.MinValue))
                .WithMessage("DateTime not null");
                RuleFor(x => x.Fecha_Fin)
              .GreaterThanOrEqualTo(x => x.Fecha_Inicio)
              .WithMessage("la fecha final debe ser mayor que la inicial");
                RuleFor(x => x.Servicio).GreaterThanOrEqualTo(1);
            }
        }


        public class Manejador : IRequestHandler<CrearTurnosParametros, ResponseOperations>
        {

            private readonly ITurno _turnorRepository;
            public Manejador(ITurno turnorRepository)
            {
                _turnorRepository = turnorRepository;
            }
            public async Task<ResponseOperations> Handle(CrearTurnosParametros request, CancellationToken cancellationToken)
            {
                return await _turnorRepository.CrearTurno(request.Servicio, request.Fecha_Inicio, request.Fecha_Fin);
            }
        }

    }
}
