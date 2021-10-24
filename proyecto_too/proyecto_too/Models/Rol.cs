using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Rol
    {
        public int RolId { get; set; }
        public string NombreRol { get; set; }
        public string SlugRol { get; set; }
        public string Descripcion { get; set; }
    }
}
