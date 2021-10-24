using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Escuela
    {
        public Escuela()
        {
            Asignaturas = new HashSet<Asignatura>();
        }

        public string CodEscuela { get; set; }
        public string NombreEscuela { get; set; }

        public virtual ICollection<Asignatura> Asignaturas { get; set; }
    }
}
