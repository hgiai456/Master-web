//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCoffee.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.CHITIET_HOADON = new HashSet<CHITIET_HOADON>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int GiaSP { get; set; }
        public Nullable<int> SoLuongSP { get; set; }
        public string MaLoaiSP { get; set; }
        public Nullable<System.DateTime> NgaySX { get; set; }
        public string Image1 { get; set; }
        public Nullable<int> MaMau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HOADON> CHITIET_HOADON { get; set; }
        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
        public virtual MAU MAU { get; set; }
    }
}
