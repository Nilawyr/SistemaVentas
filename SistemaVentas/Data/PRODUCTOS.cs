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
    
    public partial class PRODUCTOS
    {
        public int NATSID { get; set; }
        public int CLASEID { get; set; }
        public int SUBCLAID { get; set; }
        public int PRODCODIGO { get; set; }
        public string PRODNOMBRE { get; set; }
        public Nullable<int> PRODPRECIO { get; set; }
        public string PRODCODIGOBARRA { get; set; }
        public decimal PRODSTOCKINICIAL { get; set; }
        public decimal PRODSTOCKACTUAL { get; set; }
        public bool PRODINVENTARIABLE { get; set; }
        public bool PRODCONPRECIO { get; set; }
    }
}
