using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Cita = new HashSet<Cita>();
            Factura = new HashSet<Factura>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Dpi { get; set; }
        public string Nit { get; set; }
        public DateTime? FechaNac { get; set; }
        public string Correo { get; set; }
        public int IdTipoCliente { get; set; }

        public virtual TipoCliente IdTipoClienteNavigation { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
