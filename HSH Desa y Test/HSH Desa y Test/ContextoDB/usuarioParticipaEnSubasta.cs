//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HSH_Desa_y_Test.ContextoDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarioParticipaEnSubasta
    {
        public int id { get; set; }
        public decimal monto { get; set; }
        public string idPersona { get; set; }
        public int idSubasta { get; set; }
    
        public virtual subasta subasta { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
