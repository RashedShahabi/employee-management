//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactProject_DataLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactTransactions
    {
        public string ID { get; set; }
        public string ContactID { get; set; }
        public decimal Value { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsPayment { get; set; }
    
        public virtual Contact Contact { get; set; }
    }
}