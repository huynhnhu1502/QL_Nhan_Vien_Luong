using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{

    public class DAL_NV
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        NhanVien _nhanvien = new NhanVien();
        public bool Create(NhanVien nv)
        {
            try
            {
                var them = new NhanVien
                {
                    MaNV = nv.MaNV,
                    MaChucVu = nv.MaChucVu,
                    MaDonVi = nv.MaDonVi,
                    HoTen = nv.HoTen,
                    DanToc = nv.DanToc,
                    GioiTinh = nv.GioiTinh,
                    DiaChi = nv.DiaChi,
                    HinhAnh = nv.HinhAnh,
                    NgayBatDau = nv.NgayBatDau,
                    NgayHuu = nv.NgayHuu,
                    NgayNghi = nv.NgayNghi,
                    NgaySinh = nv.NgaySinh,
                    MaNgach = nv.MaNgach,
                    CMND = nv.CMND
                };
                db.NhanViens.Add(them);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi: "+ ex);
                return false;
            }
        }
        public bool Search(NhanVien nv)
        {
            var search = db.NhanViens.FirstOrDefault(a=> a.MaNV == nv.MaNV || a.HoTen == nv.HoTen || a.MaDonVi == nv.MaDonVi || a.MaChucVu == nv.MaChucVu);
            if (search != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
