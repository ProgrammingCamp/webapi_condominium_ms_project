//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLogic
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblHouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHouse()
        {
            this.tblHouseOwners = new HashSet<tblHouseOwner>();
            this.tblHousePayments = new HashSet<tblHousePayment>();
        }
    
        public int ID { get; set; }
        public int RegionID { get; set; }
        public int SubCityID { get; set; }
        public int WoredaID { get; set; }
        public string BlockNumber { get; set; }
        public int FloorNumber { get; set; }
        public string HouseNumber { get; set; }
        public System.DateTime GovernmentTransferedDate { get; set; }
        public string SiteName { get; set; }
    
        public virtual tblRegion tblRegion { get; set; }
        public virtual tblSubCity tblSubCity { get; set; }
        public virtual tblWoreda tblWoreda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHouseOwner> tblHouseOwners { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHousePayment> tblHousePayments { get; set; }
    }
}
