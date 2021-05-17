using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio
{
    public  class Comercios
    {

        [Key]
        public int id_comercio { get; set; }
        public string non_comercio { get; set; }
        public int num_aforo { get; set; }
      
        public ICollection<Servicios> Servicio { get; set; }
    }
}
