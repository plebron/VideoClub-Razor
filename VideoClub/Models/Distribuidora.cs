//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoClub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Distribuidora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Distribuidora()
        {
            this.Peliculas = new HashSet<Pelicula>();
        }
    
        public string DistribuidoraId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string URL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}