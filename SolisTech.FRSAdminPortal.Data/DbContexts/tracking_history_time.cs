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
    
    public partial class tracking_history_time
    {
        public int id { get; set; }
        public System.DateTime datetimestamp { get; set; }
        public int clientid { get; set; }
        public int regionid { get; set; }
        public int districtid { get; set; }
        public int userid { get; set; }
        public int cardid { get; set; }
        public System.DateTime starttime { get; set; }
        public Nullable<System.DateTime> endtime { get; set; }
        public int msginid { get; set; }
        public int teamid { get; set; }
        public int territoryid { get; set; }
    }
}
