using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Dominio;

namespace Persistencia.DapperConexion.Turno
{
    public class TurnoRepositorio :ITurno
    {


        private readonly IFactoryConnection _factoryConnection;

        public TurnoRepositorio(IFactoryConnection factoryConnection)
        {
            _factoryConnection = factoryConnection;
        }

        public async Task<IEnumerable<TurnoModel>> ConsultarTurnos()
        {
            IEnumerable<TurnoModel> instructorList = null;
            var storeProcedure = "PC_V_Turno";
            try
            {
                var connection = _factoryConnection.GetConnection();
                instructorList = await connection.QueryAsync<TurnoModel>(storeProcedure, null, commandType: CommandType.StoredProcedure);

            }
            catch (Exception e)
            {
                throw new Exception("Error en la consulta de datos", e);
            }
            finally
            {
                _factoryConnection.CloseConnection();
            }
            return instructorList;
        }

        public async Task<ResponseOperations> CrearTurno(int id_servicio, DateTime fecha_inicio, DateTime fecha_fin)
        {

            ResponseOperations instructorList = null;
            var storeProcedure = "PC_I_Turno";
            try
            {
                var connection = _factoryConnection.GetConnection();
                instructorList = await connection.QueryFirstAsync<ResponseOperations>(storeProcedure,
                       new
                       {
                           Id_Servicio = id_servicio,
                           Fecha_Inicio= fecha_inicio,
                           Fecha_Fin = fecha_fin
                       }
                    , commandType: CommandType.StoredProcedure);

            }
            catch (Exception e)
            {
                throw new Exception("Error en la insercion de datos", e);
            }
            finally
            {
                _factoryConnection.CloseConnection();
            }
            return instructorList;

        }

      
    }
}
