using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Catalogo
    {
        public int IdCatalogo { get; set; }
        public int? Id { get; set; }
        public string CodigoLocal { get; set; }

        public virtual Local CodigoLocalNavigation { get; set; }
        public virtual Horario IdNavigation { get; set; }
    }
}
