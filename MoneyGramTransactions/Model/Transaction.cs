//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    
    using System;
    using System.Collections.Generic;
    
    [System.Runtime.Serialization.DataContract]
    public partial class Transaction
    {
        [System.Runtime.Serialization.DataMember]public int TransactionID { get; set; }
        [System.Runtime.Serialization.DataMember]public int CurrencyID { get; set; }
        [System.Runtime.Serialization.DataMember]public int CustomerID { get; set; }
        [System.Runtime.Serialization.DataMember]public decimal Amount { get; set; }
        [System.Runtime.Serialization.DataMember]public System.DateTime Date { get; set; }
        [System.Runtime.Serialization.DataMember]public string Code { get; set; }
    
        [System.Runtime.Serialization.DataMember]public virtual Currency Currency { get; set; }
        [System.Runtime.Serialization.DataMember]public virtual Customer Customer { get; set; }
    }
}
