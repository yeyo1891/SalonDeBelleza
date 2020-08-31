using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Cita
    {
        public int IdCitas { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdCliente { get; set; }
        public int? IdSucursal { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Sucursal IdSucursalNavigation { get; set; }
    }
}
