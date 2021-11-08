using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace proyecto_too.Models
{
    public class Usuario2
    {
        public int IdUsuario
        {
            get; set;
        }

        [Required(ErrorMessage = "Este Campo {0} es requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo {0} es requerido")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Este Campo {0} es requerido")]
        public string Pasword { get; set; }
        [Required(ErrorMessage = "Este Campo password es requerido")]
        public string Pasword2 { get; set; }
    }
}
