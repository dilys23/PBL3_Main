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
    
    public partial class DayTro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DayTro()
        {
            this.PhongTro = new HashSet<PhongTro>();
        }
    
        public string MaDayTro { get; set; }
        public string TenDayTro { get; set; }
        public string TenDuong { get; set; }
        public string TenHuyen { get; set; }
        public string TenThanhPho { get; set; }
        public string MaChuTro { get; set; }
        public byte[] HinhAnh { get; set; }
    
        public virtual Nguoi Nguoi { get; set; }
        public virtual Nguoi Nguoi1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongTro> PhongTro { get; set; }
    }
}
