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
    public partial class Log
    {
        [System.Runtime.Serialization.DataMember]public long LogID { get; set; }
        [System.Runtime.Serialization.DataMember]public System.DateTime DateCreated { get; set; }
        [System.Runtime.Serialization.DataMember]public int CustomerID { get; set; }
        [System.Runtime.Serialization.DataMember]public int TransactionID { get; set; }
        [System.Runtime.Serialization.DataMember]public int CurrencyID { get; set; }
        [System.Runtime.Serialization.DataMember]public decimal Amount { get; set; }
        [System.Runtime.Serialization.DataMember]public string Description { get; set; }
        [System.Runtime.Serialization.DataMember]public bool IsSuccess { get; set; }
    }
}
