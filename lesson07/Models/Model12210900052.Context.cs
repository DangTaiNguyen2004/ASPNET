﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dtnBaiKiemTraGK.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DtnK22CNT4Lesson07DfEntities : DbContext
    {
        public DtnK22CNT4Lesson07DfEntities()
            : base("name=DtnK22CNT4Lesson07DfEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DtnKhoa> DtnKhoa { get; set; }
        public virtual DbSet<DtnSinhVien> DtnSinhVien { get; set; }
    }
}
