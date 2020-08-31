﻿using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Total { get; set; }
        public int? IdFactura { get; set; }
        public int? IdProducto { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
