//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ChiTietDichVu
    {
        public string MaChiTietDichVu { get; set; }
        public string MaDichVu { get; set; }
        public string MaPhongTro { get; set; }
        public double ChiSoCu { get; set; }
        public double ChiSoMoi { get; set; }
        public string ThoiGian { get; set; }
    
        public virtual DichVu DichVu { get; set; }
        public virtual PhongTro PhongTro { get; set; }
    }
}
