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
    
    public partial class client_tasks
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int AssignedToUserId { get; set; }
        public int CreatedByUserId { get; set; }
        public System.DateTime DateTimeStamp { get; set; }
        public System.DateTime DueDate { get; set; }
        public string Description { get; set; }
    }
}
