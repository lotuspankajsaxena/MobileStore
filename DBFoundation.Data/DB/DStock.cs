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
    
    public partial class DStock
    {
        public decimal Opening { get; set; }
        public decimal Curr_Pur { get; set; }
        public decimal Curr_Sale { get; set; }
        public decimal Closing { get; set; }
        public string Dated { get; set; }
        public System.DateTime Dd { get; set; }
        public string Item_Name { get; set; }
        public Nullable<decimal> SaleValue { get; set; }
        public Nullable<decimal> PurRet { get; set; }
        public Nullable<decimal> SaleRet { get; set; }
    }
}