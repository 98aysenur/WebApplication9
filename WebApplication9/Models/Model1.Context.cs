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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdminLoginEntities2 : DbContext
    {
        public AdminLoginEntities2()
            : base("name=AdminLoginEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Ders> Ders { get; set; }
        public virtual DbSet<Ogrenci> Ogrenci { get; set; }
        public virtual DbSet<Ogretmen3> Ogretmen3 { get; set; }
        public virtual DbSet<Secim> Secim { get; set; }
        public virtual DbSet<Sınıf> Sınıf { get; set; }
        public virtual DbSet<TeacherDers> TeacherDers { get; set; }
    }
}
