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
    
    public partial class Narudzba_has_Roba
    {
        public int Narudzba_idNarudzba { get; set; }
        public int Roba_idRoba { get; set; }
        public int kolicina { get; set; }
    
        public virtual Narudzba Narudzba { get; set; }
        public virtual Roba Roba { get; set; }
    }
}
