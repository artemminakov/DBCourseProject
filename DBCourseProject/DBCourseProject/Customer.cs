//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBCourseProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Contracts = new ObservableListSource<Contract>();
        }
    
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string NumberTel { get; set; }
        public string Address { get; set; }
        public string CreditCardNumber { get; set; }
        public Nullable<System.DateTime> DateIssuanceRights { get; set; }
        public string Characteristics { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Contract> Contracts { get; set; }
    }
}
