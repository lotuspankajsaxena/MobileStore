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
    
    public partial class fParty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fParty()
        {
            this.fcuopen99 = new HashSet<fcuopen99>();
        }
    
        public int fpid { get; set; }
        public string fpn { get; set; }
        public string fpadd { get; set; }
        public string fpsta { get; set; }
        public string fpcity { get; set; }
        public string fpmobi { get; set; }
        public Nullable<double> fpopn { get; set; }
        public Nullable<double> fpbal { get; set; }
        public string FPFARMN { get; set; }
        public string FPGSTIN { get; set; }
        public string FPPDLN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fcuopen99> fcuopen99 { get; set; }
    }
}
