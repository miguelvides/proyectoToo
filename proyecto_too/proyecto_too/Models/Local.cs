using System;
using System.Collections.Generic;

#nullable disable

namespace proyecto_too.Models
{
    public partial class Local
    {
        public Local()
        {
            Catalogos = new HashSet<Catalogo>();
            SolicitudReservas = new HashSet<SolicitudReserva>();
        }

        public string CodigoLocal { get; set; }
        public int? Id { get; set; }
        public string Edificio { get; set; }
        public string Planta { get; set; }
        public string Ubicacion { get; set; }

        public virtual Galerium IdNavigation { get; set; }
        public virtual ICollection<Catalogo> Catalogos { get; set; }
        public virtual ICollection<SolicitudReserva> SolicitudReservas { get; set; }
    }
}
