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
    
    public partial class dashboardstring
    {
        public int dashboardid { get; set; }
        public int languageid { get; set; }
        public string text { get; set; }
    
        public virtual dashboard dashboard { get; set; }
        public virtual language language { get; set; }
    }
}
