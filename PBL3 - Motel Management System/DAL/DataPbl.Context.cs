﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3___Motel_Management_System.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataPbl : DbContext
    {
        public DataPbl()
            : base("name=DataPbl")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietDichVu> ChiTietDichVu { get; set; }
        public virtual DbSet<ChiTietThietBi> ChiTietThietBi { get; set; }
        public virtual DbSet<DayTro> DayTro { get; set; }
        public virtual DbSet<DichVu> DichVu { get; set; }
        public virtual DbSet<HopDong> HopDong { get; set; }
        public virtual DbSet<Nguoi> Nguoi { get; set; }
        public virtual DbSet<PhongTro> PhongTro { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<ThanhVienTrongPhong> ThanhVienTrongPhong { get; set; }
        public virtual DbSet<ThietBi> ThietBi { get; set; }
        public virtual DbSet<VaiTro> VaiTro { get; set; }
    }
}
