//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TBP_Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zaposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenik()
        {
            this.Narudzba = new HashSet<Narudzba>();
            this.Radni_nalog = new HashSet<Radni_nalog>();
        }
    
        public int idZaposlenik { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string pozicija { get; set; }
        public int lozinka { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Narudzba> Narudzba { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Radni_nalog> Radni_nalog { get; set; }
    }
}
