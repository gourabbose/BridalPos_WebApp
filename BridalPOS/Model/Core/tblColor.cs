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
    
    public partial class tblColor
    {
        public tblColor()
        {
            this.tblFavorites = new HashSet<tblFavorite>();
            this.tblInventories = new HashSet<tblInventory>();
        }
    
        public short Id { get; set; }
        public string Name { get; set; }
        public string ColorCode { get; set; }
    
        public virtual ICollection<tblFavorite> tblFavorites { get; set; }
        public virtual ICollection<tblInventory> tblInventories { get; set; }
    }
}
