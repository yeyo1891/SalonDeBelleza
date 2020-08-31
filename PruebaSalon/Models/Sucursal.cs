using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Cita = new HashSet<Cita>();
        }

        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int? Estado { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }
    }
}
