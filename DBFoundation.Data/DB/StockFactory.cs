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
    
    public partial class StockFactory
    {
        public string Items { get; set; }
        public string Type { get; set; }
        public double Qty { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
