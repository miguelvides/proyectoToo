using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class SolicitudReserva
    {
        public int IdSolucitud { get; set; }
        public string Dui { get; set; }
        public string CodigoLocal { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public bool? Aprobado { get; set; }

        public virtual Local CodigoLocalNavigation { get; set; }
        public virtual Docente DuiNavigation { get; set; }
    }
}
