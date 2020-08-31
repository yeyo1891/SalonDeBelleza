using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            DetallePago = new HashSet<DetallePago>();
        }

        public int IdTipoPago { get; set; }
        public string Nombre { get; set; }
        public string Decripcion { get; set; }

        public virtual ICollection<DetallePago> DetallePago { get; set; }
    }
}
