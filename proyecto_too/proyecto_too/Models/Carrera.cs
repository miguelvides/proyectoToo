using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            Asignaturas = new HashSet<Asignatura>();
        }

        public string CodigoCarrera { get; set; }
        public string NombreCarrera { get; set; }

        public virtual ICollection<Asignatura> Asignaturas { get; set; }
    }
}
