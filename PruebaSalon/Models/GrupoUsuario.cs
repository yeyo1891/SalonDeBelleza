using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class GrupoUsuario
    {
        public int IdGrupoUsuario { get; set; }
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }

        public virtual Permiso IdPermisoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
