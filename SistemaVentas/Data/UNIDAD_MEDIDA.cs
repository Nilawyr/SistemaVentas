//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaVentas.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UNIDAD_MEDIDA
    {
        public short UMCODIGO { get; set; }
        public string UMNOMBRE { get; set; }
    
        public virtual UNIDAD_MEDIDA UNIDAD_MEDIDA1 { get; set; }
        public virtual UNIDAD_MEDIDA UNIDAD_MEDIDA2 { get; set; }
    }
}