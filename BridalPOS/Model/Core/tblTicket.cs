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
    
    public partial class tblTicket
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public decimal Total { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal Balance { get; set; }
    
        public virtual tblMember tblMember { get; set; }
    }
}
