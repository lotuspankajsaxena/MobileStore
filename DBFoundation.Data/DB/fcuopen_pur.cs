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
    
    public partial class fcuopen_pur
    {
        public Nullable<int> fCuopId { get; set; }
        public Nullable<decimal> fCuopCred { get; set; }
        public Nullable<decimal> fCuoprece { get; set; }
        public Nullable<decimal> fCuopbala { get; set; }
        public Nullable<System.DateTime> fCuopDt { get; set; }
        public string fCuopDate { get; set; }
        public string fPartyname { get; set; }
        public string fChno { get; set; }
        public string fRemark { get; set; }
        public string fBillNo { get; set; }
        public int fcuoppid { get; set; }
        public string fBilltype { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual fPartyPurch fPartyPurch { get; set; }
    }
}
