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
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.client_documents = new HashSet<client_documents>();
            this.reports = new HashSet<report>();
            this.targetvalues = new HashSet<targetvalue>();
            this.userDevices = new HashSet<userDevice>();
            this.UserNotifications = new HashSet<UserNotification>();
            this.UserNotifications1 = new HashSet<UserNotification>();
            this.userdashboards = new HashSet<userdashboard>();
            this.UsersMileages = new HashSet<UsersMileage>();
        }
    
        public int id { get; set; }
        public byte active { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string mobilenumber { get; set; }
        public byte allowsms { get; set; }
        public int providerid { get; set; }
        public short userlevel { get; set; }
        public int regionid { get; set; }
        public int districtid { get; set; }
        public System.DateTime lastmessagein { get; set; }
        public string rssfeed { get; set; }
        public string securityquestion { get; set; }
        public string securityanswer { get; set; }
        public int cardid { get; set; }
        public int timezoneshift { get; set; }
        public int defaultchart { get; set; }
        public string reportstart { get; set; }
        public System.DateTime lastlogin { get; set; }
        public System.DateTime hiredate { get; set; }
        public string termcp { get; set; }
        public string termq2 { get; set; }
        public string termq3 { get; set; }
        public string termq4 { get; set; }
        public int smsauthorized { get; set; }
        public string startcode { get; set; }
        public decimal forecast { get; set; }
        public int teamid { get; set; }
        public int startview { get; set; }
        public string lastsessionid { get; set; }
        public string repcode { get; set; }
        public string startaddress { get; set; }
        public int languageid { get; set; }
        public string timezoneinfoid { get; set; }
        public Nullable<int> holidaygroupid { get; set; }
        public int permissionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<client_documents> client_documents { get; set; }
        public virtual holidaygroup holidaygroup { get; set; }
        public virtual permission permission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<report> reports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<targetvalue> targetvalues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userDevice> userDevices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserNotification> UserNotifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserNotification> UserNotifications1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userdashboard> userdashboards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersMileage> UsersMileages { get; set; }
    }
}
