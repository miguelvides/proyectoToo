using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Galerium
    {
        public Galerium()
        {
            Locals = new HashSet<Local>();
        }

        public int Id { get; set; }
        public string NombreFoto { get; set; }

        public virtual ICollection<Local> Locals { get; set; }
    }
}
