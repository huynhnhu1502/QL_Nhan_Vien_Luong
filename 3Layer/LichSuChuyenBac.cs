//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class LichSuChuyenBac
    {
        public int id { get; set; }
        public string MaNV { get; set; }
        public string MaHeSo { get; set; }
        public System.DateTime NgayChuyen { get; set; }
    
        public virtual HeSoLuongPhuCap HeSoLuongPhuCap { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
