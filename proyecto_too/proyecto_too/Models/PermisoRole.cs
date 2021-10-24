using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class PermisoRole
    {
        public int? RolId { get; set; }
        public int? IdPermiso { get; set; }

        public virtual Permiso IdPermisoNavigation { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
