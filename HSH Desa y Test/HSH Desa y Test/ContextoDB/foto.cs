//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HSH_Desa_y_Test.ContextoDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class foto
    {
        public int id { get; set; }
        public int idPropiedad { get; set; }
        public byte[] foto1 { get; set; }
    
        public virtual Propiedad Propiedad { get; set; }
    }
}