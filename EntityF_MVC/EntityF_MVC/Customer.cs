//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityF_MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
