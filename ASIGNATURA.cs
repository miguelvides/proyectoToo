//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoToo
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASIGNATURA
    {
        public string CODIGO_MATERIA { get; set; }
        public string CODIGO_CARRERA { get; set; }
        public string COD__ESCUELA { get; set; }
        public Nullable<int> ID { get; set; }
        public int CORRELATIVO_MATERIA { get; set; }
        public string NOMBRE_MATERIA { get; set; }
        public int UNIDAD_VALORATIVA { get; set; }
        public string TIPO_MATERIA { get; set; }
        public int PRE_REQUISITO { get; set; }
        public string CICLO { get; set; }
    
        public virtual CARRERA CARRERA { get; set; }
        public virtual ESCUELA ESCUELA { get; set; }
        public virtual HORARIO HORARIO { get; set; }
    }
}
