using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.DapperConexion.Turno
{
   public class TurnoModel
    {
        public int id_turno { get; set; }
        public DateTime fecha_turno { get; set; }
        public DateTime hora_inicio { get; set; }
        public DateTime hora_fin { get; set; }
        public int id_estado { get; set; }
        public string nombre_estado { get; set; }
        public int id_servicio { get; set; }
        public  string nom_servicio { get; set; }
        public int id_comercio { get; set; }
        public string non_comercio { get; set; }
   


    }
}
