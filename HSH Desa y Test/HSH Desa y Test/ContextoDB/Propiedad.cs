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
    
    public partial class Propiedad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Propiedad()
        {
            this.subastas = new HashSet<subasta>();
            this.ReservaDirectas = new HashSet<ReservaDirecta>();
            this.fotos = new HashSet<foto>();
            this.HotSales = new HashSet<HotSale>();
        }
    
        public int id { get; set; }
        public string tipo { get; set; }
        public string ubicaciòn { get; set; }
        public int habitaciones { get; set; }
        public string adminQueDioDeAltaProp { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public string adminQueDIoDeBajaProp { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public string ciudad { get; set; }
        public string nombre { get; set; }
        public string provincia { get; set; }
        public string pais { get; set; }
        public decimal montoReserva { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual admin admin1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<subasta> subastas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaDirecta> ReservaDirectas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<foto> fotos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotSale> HotSales { get; set; }
    }
}
