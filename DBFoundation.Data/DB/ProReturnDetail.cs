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
    
    public partial class ProReturnDetail
    {
        public int PrtID { get; set; }
        public Nullable<int> PrtBillNo { get; set; }
        public string PrtPartyName { get; set; }
        public Nullable<int> PrtProId { get; set; }
        public string PrtProName { get; set; }
        public string PrtType { get; set; }
        public Nullable<int> PrtQty { get; set; }
        public Nullable<decimal> PrtRate { get; set; }
        public Nullable<int> PrtRetQty { get; set; }
        public Nullable<decimal> PrtRetCost { get; set; }
        public string PrtRemark { get; set; }
        public Nullable<System.DateTime> PrtDt { get; set; }
        public string PrtDtVar { get; set; }
    }
}
