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
    
    public partial class contact_address
    {
        public int contactid { get; set; }
        public int addressid { get; set; }
        public int relationshipid { get; set; }
    
        public virtual address address { get; set; }
        public virtual contact contact { get; set; }
        public virtual contact_address_relationship contact_address_relationship { get; set; }
    }
}
