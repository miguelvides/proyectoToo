using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Docente
    {
        public Docente()
        {
            Reservas = new HashSet<Reserva>();
            SolicitudReservas = new HashSet<SolicitudReserva>();
        }

        public string Dui { get; set; }
        public string NombreDocente { get; set; }
        public string ApellidoDocente { get; set; }
        public string Nit { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoActividad { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
        public virtual ICollection<SolicitudReserva> SolicitudReservas { get; set; }
    }
}
