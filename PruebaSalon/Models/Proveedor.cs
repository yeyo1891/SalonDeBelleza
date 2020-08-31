using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            DetalleProducto = new HashSet<DetalleProducto>();
        }

        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int? Telefono { get; set; }
        public string Email { get; set; }

        public virtual ICollection<DetalleProducto> DetalleProducto { get; set; }
    }
}
