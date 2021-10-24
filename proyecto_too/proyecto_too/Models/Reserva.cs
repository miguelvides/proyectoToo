using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Reserva
    {
        public string CodigoDeReserva { get; set; }
        public string Dui { get; set; }
        public DateTime FechaAceptada { get; set; }

        public virtual Docente DuiNavigation { get; set; }
    }
}
