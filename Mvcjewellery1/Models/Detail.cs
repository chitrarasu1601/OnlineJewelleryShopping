//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvcjewellery1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Detail()
        {
            this.MyOrders = new HashSet<MyOrder>();
            this.Payment_Details = new HashSet<Payment_Details>();
        }
    
        public int ID { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> discount { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<int> Product_ID { get; set; }
    
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyOrder> MyOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment_Details> Payment_Details { get; set; }
    }
}
