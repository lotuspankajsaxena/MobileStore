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
    
    public partial class Item
    {
        public int id { get; set; }
        public string items { get; set; }
        public decimal cost { get; set; }
        public string code { get; set; }
        public string group_items { get; set; }
        public string TyreType { get; set; }
        public Nullable<double> TaxPer { get; set; }
        public Nullable<decimal> TBPrice { get; set; }
        public string PurParty { get; set; }
        public string HSNCODE { get; set; }
        public string UQC { get; set; }
    
        public virtual BILLCOST BILLCOST { get; set; }
        public virtual StockFactory StockFactory { get; set; }
        public virtual StockGodown StockGodown { get; set; }
    }
}
