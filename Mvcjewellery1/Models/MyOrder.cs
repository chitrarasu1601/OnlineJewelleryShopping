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
    
    public partial class MyOrder
    {
        public int ID { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public Nullable<int> Category_ID { get; set; }
        public Nullable<int> Details_ID { get; set; }
        public Nullable<int> Payment_ID { get; set; }
        public Nullable<int> Customer_ID { get; set; }
        public Nullable<double> Amount { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Detail Detail { get; set; }
        public virtual Payment_Details Payment_Details { get; set; }
        public virtual Product Product { get; set; }
    }
}
