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
    
    public partial class report_column
    {
        public int reportid { get; set; }
        public int sequence { get; set; }
        public int sourceid { get; set; }
    
        public virtual report report { get; set; }
        public virtual report_columnsource report_columnsource { get; set; }
    }
}
