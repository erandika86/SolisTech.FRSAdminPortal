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
    
    public partial class card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public card()
        {
            this.caColumnAccess_messageQuestions = new HashSet<caColumnAccess_messageQuestions>();
            this.userdashboards = new HashSet<userdashboard>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
        public System.DateTime datecreated { get; set; }
        public System.DateTime datemodified { get; set; }
        public int linkid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<caColumnAccess_messageQuestions> caColumnAccess_messageQuestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userdashboard> userdashboards { get; set; }
    }
}
