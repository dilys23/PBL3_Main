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
    
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            this.ChiTietTaiKhoanChuTro = new HashSet<ChiTietTaiKhoanChuTro>();
            this.ChiTietTaiKhoanPhongTro = new HashSet<ChiTietTaiKhoanPhongTro>();
            this.VaiTro = new HashSet<VaiTro>();
        }
    
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaTaiKhoan { get; set; }
        public Nullable<bool> TonTai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTaiKhoanChuTro> ChiTietTaiKhoanChuTro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTaiKhoanPhongTro> ChiTietTaiKhoanPhongTro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaiTro> VaiTro { get; set; }
    }
}
