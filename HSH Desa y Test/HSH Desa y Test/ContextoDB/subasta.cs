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
    
    public partial class subasta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public subasta()
        {
            this.usuarioParticipaEnSubastas = new HashSet<usuarioParticipaEnSubasta>();
        }
    
        public int semana_de_subasta { get; set; }
        public System.DateTime fecha_inicio { get; set; }
        public System.DateTime fecha_fin { get; set; }
        public decimal monto_inicial { get; set; }
        public int id { get; set; }
        public int id_propiedad_subastada { get; set; }
    
        public virtual Propiedad Propiedad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuarioParticipaEnSubasta> usuarioParticipaEnSubastas { get; set; }
    }
}