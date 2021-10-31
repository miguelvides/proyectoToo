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
        public byte[] Pasword { get; set; }
        public byte[] KeY { get; set; }
        public byte[] Vi { get; set; }
    }
}
