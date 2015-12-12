using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.BIZ
{
    public class BIZ_TinhLuong
    {
        NhanVien nv = new NhanVien();
        DAL.DAL_TinhLuong _dalTinhLuong = new DAL.DAL_TinhLuong();
        public bool TinhLuong(string Manv)
        {
            return _dalTinhLuong.TinhLuong(Manv);
        }
        public List<LuongThucTe> ThongKeLuong(string MaDonVi, string thang, string nam)
        {
            return _dalTinhLuong.ThongKeLuong(MaDonVi, thang, nam);
        }
        public List<NhanVien> XuatThucHienTinhLuong(string MaNV)
        {
            return _dalTinhLuong.XuatThucHienTinhLuong(MaNV);
        }
        public List<NhanVien> XuatTinhLuong(string Hoten)
        {
            return _dalTinhLuong.XuatTinhLuong(Hoten);
        }
    }
}
