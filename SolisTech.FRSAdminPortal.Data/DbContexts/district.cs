//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolisTech.FRSAdminPortal.Data.DbContexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class district
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public district()
        {
            this.permissions = new HashSet<permission>();
        }
    
        public int id { get; set; }
        public int regionid { get; set; }
        public string district1 { get; set; }
        public decimal quota { get; set; }
        public byte qsun { get; set; }
        public byte qmon { get; set; }
        public byte qtue { get; set; }
        public byte qwed { get; set; }
        public byte qthu { get; set; }
        public byte qfri { get; set; }
        public byte qsat { get; set; }
        public int territoryid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permission> permissions { get; set; }
    }
}