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
    
    public partial class userdashboard
    {
        public int dashboardid { get; set; }
        public Nullable<int> cardid { get; set; }
        public Nullable<int> userlevel { get; set; }
        public Nullable<int> userid { get; set; }
        public int sequence { get; set; }
    
        public virtual card card { get; set; }
        public virtual dashboard dashboard { get; set; }
        public virtual user user { get; set; }
    }
}