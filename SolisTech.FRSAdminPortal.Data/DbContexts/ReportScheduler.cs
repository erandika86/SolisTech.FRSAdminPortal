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
    
    public partial class ReportScheduler
    {
        public int id { get; set; }
        public int ReportType { get; set; }
        public System.DateTime UTC_StartDate { get; set; }
        public int frequency { get; set; }
        public System.DateTime UTC_StartTime { get; set; }
        public System.DateTime UTC_LastCalled { get; set; }
        public string ftp_Directory { get; set; }
        public int delivery_type { get; set; }
        public string email { get; set; }
        public int userid { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> RunDate { get; set; }
        public Nullable<System.DateTime> RunTime { get; set; }
    }
}
