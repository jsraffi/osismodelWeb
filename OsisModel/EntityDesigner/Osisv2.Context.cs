﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OsisModel.EntityDesigner
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OsisEntities : DbContext
    {
        public OsisEntities()
            : base("name=OsisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicYear> AcademicYears { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<SchoolClass> SchoolClasses { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<StudentCurrentYear> StudentCurrentYears { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<UserPreference> UserPreferences { get; set; }
    }
}
