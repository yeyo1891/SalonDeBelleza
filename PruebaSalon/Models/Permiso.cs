using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Permiso
    {
        public Permiso()
        {
            GrupoUsuario = new HashSet<GrupoUsuario>();
        }

        public int IdPermiso { get; set; }
        public string Permiso1 { get; set; }

        public virtual ICollection<GrupoUsuario> GrupoUsuario { get; set; }
    }
}
