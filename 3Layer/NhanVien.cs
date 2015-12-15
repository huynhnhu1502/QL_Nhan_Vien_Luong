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
    
    public partial class NhanVien
    {
        public NhanVien()
        {
            this.LichSuChuyenBacs = new HashSet<LichSuChuyenBac>();
            this.LichSuCongTacs = new HashSet<LichSuCongTac>();
            this.LuongThucTes = new HashSet<LuongThucTe>();
        }

        public int id { get; set; }
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string MaNgach { get; set; }
        public string MaHeSo { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string DanToc { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayNghi { get; set; }
        public Nullable<System.DateTime> NgayHuu { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
        public virtual DonVi DonVi { get; set; }
        public virtual HeSoLuongPhuCap HeSoLuongPhuCap { get; set; }
        public virtual ICollection<LichSuChuyenBac> LichSuChuyenBacs { get; set; }
        public virtual ICollection<LichSuCongTac> LichSuCongTacs { get; set; }
        public virtual ICollection<LuongThucTe> LuongThucTes { get; set; }
        public virtual NgachLuong NgachLuong { get; set; }
    }
}
