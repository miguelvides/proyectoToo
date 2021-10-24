using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Asignatura
    {
        public string CodigoMateria { get; set; }
        public string CodigoCarrera { get; set; }
        public string CodEscuela { get; set; }
        public int? Id { get; set; }
        public int CorrelativoMateria { get; set; }
        public string NombreMateria { get; set; }
        public int UnidadValorativa { get; set; }
        public string TipoMateria { get; set; }
        public int PreRequisito { get; set; }
        public string Ciclo { get; set; }

        public virtual Escuela CodEscuelaNavigation { get; set; }
        public virtual Carrera CodigoCarreraNavigation { get; set; }
        public virtual Horario IdNavigation { get; set; }
    }
}
