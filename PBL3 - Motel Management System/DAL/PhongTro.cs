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
    
    public partial class PhongTro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongTro()
        {
            this.ChiTietDichVu = new HashSet<ChiTietDichVu>();
            this.ChiTietThietBi = new HashSet<ChiTietThietBi>();
            this.HopDong = new HashSet<HopDong>();
            this.ThanhVienTrongPhong = new HashSet<ThanhVienTrongPhong>();
        }
    
        public string MaPhongTro { get; set; }
        public string TenPhongTro { get; set; }
        public double GiaTien { get; set; }
        public double DienTich { get; set; }
        public bool TinhTrang { get; set; }
        public string MaDayTro { get; set; }
        public Nullable<int> ToiDa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDichVu> ChiTietDichVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThietBi> ChiTietThietBi { get; set; }
        public virtual DayTro DayTro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhVienTrongPhong> ThanhVienTrongPhong { get; set; }
    }
}
