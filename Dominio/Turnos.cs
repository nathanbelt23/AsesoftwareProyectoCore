using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominio
{
    public class Turnos
    {

        [Key]
        public int id_turno { get; set; }


        public DateTime fecha_turno { get; set; }



        [Display(Name = "hora_inicio")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime hora_inicio { get; set; }

        [Display(Name = "hora_fin")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime hora_fin { get; set; }




        public int id_estado { get; set; }
        [ForeignKey("id_estado")]
        public  Estado Estado { get; set; }

        public int id_servicio { get; set; }
        [ForeignKey("id_servicio")]
        public Servicios Servicio { get; set; }

    }
}
