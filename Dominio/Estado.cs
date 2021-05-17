using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio
{
     public class Estado
    {

        [Key]
        public int id_estado { get; set; }
        public string nombre_estado { get; set; }

        public ICollection<Turnos> Turno { get; set; }
    }
}
