using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class DetallePago
    {
        public int IdPago { get; set; }
        public int IdFactura { get; set; }
        public decimal Cantidad { get; set; }
        public int IdTipoPago { get; set; }

        public virtual TipoPago IdTipoPagoNavigation { get; set; }
    }
}
