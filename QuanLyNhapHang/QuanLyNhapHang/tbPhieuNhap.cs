//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhapHang
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPhieuNhap
    {
        public string MaPhieuNhap { get; set; }
        public string MaMatHang { get; set; }
        public Nullable<int> MaDVTinh { get; set; }
        public string SoLuong { get; set; }
        public string TongHoaDon { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public string MaNguoiNhap { get; set; }
    
        public virtual DVTinh DVTinh { get; set; }
        public virtual tbUsers tbUsers { get; set; }
    }
}
