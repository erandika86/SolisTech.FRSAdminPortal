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
    
    public partial class dashboard_statfilter
    {
        public int id { get; set; }
        public int statid { get; set; }
        public int type { get; set; }
        public string tablename { get; set; }
        public string columnname { get; set; }
        public Nullable<bool> lastvalue { get; set; }
        public Nullable<System.DateTime> mindate { get; set; }
        public Nullable<System.DateTime> maxdate { get; set; }
        public Nullable<int> minint { get; set; }
        public Nullable<int> maxint { get; set; }
        public string minstring { get; set; }
        public string maxstring { get; set; }
    
        public virtual dashboard_statistic dashboard_statistic { get; set; }
    }
}