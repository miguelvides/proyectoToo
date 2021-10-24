using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Horario
    {
        public Horario()
        {
            Asignaturas = new HashSet<Asignatura>();
            Catalogos = new HashSet<Catalogo>();
        }

        public int Id { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Dia { get; set; }

        public virtual ICollection<Asignatura> Asignaturas { get; set; }
        public virtual ICollection<Catalogo> Catalogos { get; set; }
    }
}
