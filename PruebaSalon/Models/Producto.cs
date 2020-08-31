using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleCompra = new HashSet<DetalleCompra>();
            DetalleFactura = new HashSet<DetalleFactura>();
            DetalleProducto = new HashSet<DetalleProducto>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int? IdTipoProducto { get; set; }

        public virtual TipoProducto IdTipoProductoNavigation { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
        public virtual ICollection<DetalleProducto> DetalleProducto { get; set; }
    }
}
