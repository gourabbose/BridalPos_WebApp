//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BridalPOS.Model.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCashDrawer
    {
        public int Id { get; set; }
        public short TransactionTypeId { get; set; }
        public short PaymentTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public System.DateTime PostDate { get; set; }
        public bool IsArchive { get; set; }
    
        public virtual tblPaymentType tblPaymentType { get; set; }
        public virtual tblTransactionType tblTransactionType { get; set; }
    }
}
