//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeacherDers
    {
        public int TeacherDersID { get; set; }
        public int OgretmenID { get; set; }
        public Nullable<int> DersID { get; set; }
    
        public virtual Ders Ders { get; set; }
        public virtual Ogretmen3 Ogretmen3 { get; set; }
    }
}
