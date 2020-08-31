using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class DetalleProducto
    {
        public int IdDetalle { get; set; }
        public int? Disponibilidad { get; set; }
        public decimal? Valor { get; set; }
        public string Descripcion { get; set; }
        public int? IdProducto { get; set; }
        public int? IdProveedor { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Proveedor IdProveedorNavigation { get; set; }
    }
}
