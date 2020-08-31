using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Factura
    {
        public Factura()
        {
            DetalleFactura = new HashSet<DetalleFactura>();
        }

        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public string NumeroFactura { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
    }
}
