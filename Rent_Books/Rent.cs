//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rent_Books
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rent
    {
        public int Id { get; set; }
        public System.DateTime DateStart { get; set; }
        public int User_id { get; set; }
        public int Book_Id { get; set; }
        public bool State { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
    
        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
    }
}
