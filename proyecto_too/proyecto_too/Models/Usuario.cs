using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Pasword { get; set; }
    }
}
