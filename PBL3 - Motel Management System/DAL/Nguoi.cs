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
    
    public partial class Nguoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nguoi()
        {
            this.DayTro = new HashSet<DayTro>();
            this.HopDong = new HashSet<HopDong>();
            this.ThanhVienTrongPhong = new HashSet<ThanhVienTrongPhong>();
            this.VaiTro = new HashSet<VaiTro>();
        }
    
        public string MaNguoi { get; set; }
        public string Cccd { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string Diachi { get; set; }
        public string NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public byte[] HinhAnh { get; set; }
        public Nullable<bool> TonTai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DayTro> DayTro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhVienTrongPhong> ThanhVienTrongPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaiTro> VaiTro { get; set; }
    }
}
