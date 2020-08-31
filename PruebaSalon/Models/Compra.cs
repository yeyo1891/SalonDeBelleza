using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Compra
    {
        public Compra()
        {
            DetalleCompra = new HashSet<DetalleCompra>();
        }

        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
    }
}
