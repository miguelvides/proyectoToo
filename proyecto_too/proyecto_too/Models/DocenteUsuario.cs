using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class DocenteUsuario
    {
        public string Dui { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Docente DuiNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
