//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFoundation.Data.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class fUser
    {
        public int us_id { get; set; }
        public int us_type { get; set; }
        public string us_loginName { get; set; }
        public string us_loginPass { get; set; }
        public Nullable<System.DateTime> us_lastLoginTime { get; set; }
        public Nullable<System.DateTime> us_lastLogoutTime { get; set; }
        public Nullable<int> us_count { get; set; }
        public System.DateTime us_staDate { get; set; }
        public Nullable<System.DateTime> us_endDate { get; set; }
        public int us_passLength { get; set; }
        public int us_passLife { get; set; }
        public Nullable<System.DateTime> us_lastPassChange { get; set; }
        public int us_accessTeaching { get; set; }
        public int us_accessAdmin { get; set; }
        public System.DateTime us_createDate { get; set; }
        public int us_createdBy { get; set; }
        public System.DateTime us_modifyDate { get; set; }
        public int us_modifiedBy { get; set; }
        public int us_status { get; set; }
        public int us_accessHR { get; set; }
        public int us_accessStudent { get; set; }
        public int us_accessAccounting { get; set; }
        public int us_accessOffice { get; set; }
        public int us_earlyRenew { get; set; }
        public int us_forceChange { get; set; }
    }
}
