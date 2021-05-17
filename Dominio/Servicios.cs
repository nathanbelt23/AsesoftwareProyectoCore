using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominio
{
   public  class Servicios
   {

        [Key]
        public int id_servicio { get; set; }

        public string nom_servicio { get; set; }
        [Display(Name = "hora_apertura")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public System.TimeSpan hora_apertura { get; set; }


        [Display(Name = "hora_cierre")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public System.TimeSpan hora_cierre { get; set; }


        public int id_comercio { get; set; }
        [ForeignKey("id_comercio")]
        public Comercios Comercio { get; set; }

        public ICollection<Turnos> turno { get; set; }



    }
}
