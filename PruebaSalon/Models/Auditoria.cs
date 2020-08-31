using System;
using System.Collections.Generic;

namespace PruebaSalon.Models
{
    public partial class Auditoria
    {
        public int IdAuditoria { get; set; }
        public int? IdUsuario { get; set; }
        public string Tabla { get; set; }
        public string Evento { get; set; }
        public DateTime? Fechahora { get; set; }
        public string Observaciones { get; set; }
    }
}
