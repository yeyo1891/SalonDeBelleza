using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Compra = new HashSet<Compra>();
            GrupoUsuario = new HashSet<GrupoUsuario>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Usuario1 { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<GrupoUsuario> GrupoUsuario { get; set; }
    }
}
