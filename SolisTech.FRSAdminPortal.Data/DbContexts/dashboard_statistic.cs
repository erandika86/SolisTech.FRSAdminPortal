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
    
    public partial class dashboard_statistic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dashboard_statistic()
        {
            this.dashboard_statfilter = new HashSet<dashboard_statfilter>();
            this.dashboard_statheading = new HashSet<dashboard_statheading>();
        }
    
        public int id { get; set; }
        public int dashboardid { get; set; }
        public bool row { get; set; }
        public int sequence { get; set; }
        public bool computed { get; set; }
        public int basis { get; set; }
        public Nullable<int> daterangetype { get; set; }
        public Nullable<System.DateTime> fromdate { get; set; }
        public Nullable<System.DateTime> todate { get; set; }
        public string tablename { get; set; }
        public int calctype { get; set; }
        public string expression { get; set; }
        public Nullable<bool> lastvalue { get; set; }
        public string format { get; set; }
        public string destination { get; set; }
        public bool redirect { get; set; }
    
        public virtual dashboard dashboard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dashboard_statfilter> dashboard_statfilter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dashboard_statheading> dashboard_statheading { get; set; }
    }
}