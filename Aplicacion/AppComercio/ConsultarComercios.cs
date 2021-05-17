using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
namespace Aplicacion.AppComercio
{
    public class ConsultarComercios
    {
        public class ListaComercios : IRequest<List<Comercios>> { }

        public class Manejador : IRequestHandler<ListaComercios, List<Comercios>>
        {
            private readonly AsesoftwareContext _context;

            public Manejador(AsesoftwareContext context)
            {
                _context = context;

            }

            public async Task<List<Comercios>> Handle(ListaComercios request, CancellationToken cancellationToken)
            {
                var Comercios = await _context.Comercio
                .ToListAsync();
                return Comercios;
            }
        }


    }
}
