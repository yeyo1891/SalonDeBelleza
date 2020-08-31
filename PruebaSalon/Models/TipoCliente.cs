using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class TipoCliente
    {
        public TipoCliente()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int IdTipoCliente { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
