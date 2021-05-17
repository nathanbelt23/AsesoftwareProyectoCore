using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.AppServicios
{
    public class ConsultarServicios
    {

        public class ListaServicios : IRequest<List<Servicios>> { }

        public class Manejador : IRequestHandler<ListaServicios, List<Servicios>>
        {
            private readonly AsesoftwareContext _context;
            
            public Manejador(AsesoftwareContext context)
            {
                _context = context;
         
            }

            public async Task<List<Servicios>> Handle(ListaServicios request, CancellationToken cancellationToken)
            {
                var servicios = await _context.Servicios
                .ToListAsync();
                return servicios;
            }
        }

    }
}
