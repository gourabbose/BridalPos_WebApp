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
    
    public partial class tblEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<short> TypeId { get; set; }
        public Nullable<short> ConsultantId { get; set; }
        public Nullable<short> BM { get; set; }
        public Nullable<short> GM { get; set; }
        public Nullable<short> FG { get; set; }
        public int MemberId { get; set; }
        public bool IsCancelled { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
    
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblEventType tblEventType { get; set; }
        public virtual tblMember tblMember { get; set; }
    }
}
