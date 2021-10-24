using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Permiso
    {
        public int IdPermiso { get; set; }
        public string NamePermiso { get; set; }
        public string SlugPermiso { get; set; }
        public string DescripcionPermiso { get; set; }
    }
}
