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
    
    public partial class usuarioParticipaEnSubasta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarioParticipaEnSubasta()
        {
            this.ganadorDeSubastas = new HashSet<ganadorDeSubasta>();
        }
    
        public int id { get; set; }
        public decimal monto { get; set; }
        public string idPersona { get; set; }
        public int idSubasta { get; set; }
    
        public virtual subasta subasta { get; set; }
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ganadorDeSubasta> ganadorDeSubastas { get; set; }
    }
}
