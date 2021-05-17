using Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace Persistencia.DapperConexion.Turno
{
    public interface ITurno
    {

        Task<ResponseOperations> CrearTurno(int id_servicio, DateTime fecha_inicio, DateTime fecha_fin);

        Task<IEnumerable<TurnoModel>> ConsultarTurnos();



    }
}
