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
    
    public partial class caColumnAccess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public caColumnAccess()
        {
            this.caColumnAccess_questions = new HashSet<caColumnAccess_questions>();
            this.caColumnAccess_messageQuestions = new HashSet<caColumnAccess_messageQuestions>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public bool clientImportid { get; set; }
        public bool clientNumber { get; set; }
        public bool clientName { get; set; }
        public bool clientRegion { get; set; }
        public bool clientDistrict { get; set; }
        public bool clientUser { get; set; }
        public bool clientWebsite { get; set; }
        public bool clientType { get; set; }
        public bool clientMsgcnt { get; set; }
        public bool clientLastmsg { get; set; }
        public bool clientAlert { get; set; }
        public bool clientAlertassigned { get; set; }
        public bool clientAlertDays { get; set; }
        public bool clientTotalsales { get; set; }
        public bool clientTotalSalesdate { get; set; }
        public bool clientForecastamount { get; set; }
        public bool clientforecastdate { get; set; }
        public bool clientValuelastyear { get; set; }
        public bool clientValuecurrent { get; set; }
        public bool clientValuecompetitive { get; set; }
        public bool clientNumber2 { get; set; }
        public bool clientCategory { get; set; }
        public bool clientPrevioussale { get; set; }
        public bool clientPrevioussaledate { get; set; }
        public bool clientCurrentsale { get; set; }
        public bool clientCurrentsaledate { get; set; }
        public bool clientGroup { get; set; }
        public bool clientCard { get; set; }
        public bool submittedUserUsername { get; set; }
        public bool submittedUserEmail { get; set; }
        public bool submittedUserMobilenumber { get; set; }
        public bool submittedUserRegion { get; set; }
        public bool submittedUserDistrict { get; set; }
        public bool submittedUserRepcode { get; set; }
        public bool clientUserUsername { get; set; }
        public bool clientUserEmail { get; set; }
        public bool clientUserMobilenumber { get; set; }
        public bool clientUserRegion { get; set; }
        public bool clientUserDistrict { get; set; }
        public bool clientUserRepcode { get; set; }
        public bool clientPrimaryStreet { get; set; }
        public bool clientPrimaryCity { get; set; }
        public bool clientPrimaryState { get; set; }
        public bool clientPrimaryPhone { get; set; }
        public bool clientContactFirstname { get; set; }
        public bool clientContactLastname { get; set; }
        public bool clientContactStreet { get; set; }
        public bool clientContactCity { get; set; }
        public bool clientContactState { get; set; }
        public bool clientContactPhone { get; set; }
        public bool messageDatetimestamp { get; set; }
        public bool messageMobileNumber { get; set; }
        public bool messageUsername { get; set; }
        public bool messageMessage { get; set; }
        public bool messageClientName { get; set; }
        public bool messageSource { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<caColumnAccess_questions> caColumnAccess_questions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<caColumnAccess_messageQuestions> caColumnAccess_messageQuestions { get; set; }
    }
}
