using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class RolUsuario
    {
        public int? IdUsuario { get; set; }
        public int? RolId { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
