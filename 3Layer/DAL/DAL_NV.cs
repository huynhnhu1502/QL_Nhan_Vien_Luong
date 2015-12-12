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

        //Lấy DL đổ vào gridview
        public List<NhanVien> LayDuLieuNV()
        {
            try
            {
                db = new QuanLyLuongEntities();
                List<NhanVien> list = new List<NhanVien>();
                var ds = from nv in db.NhanViens
                         join dv in db.DonVis on nv.MaDonVi equals dv.MaDonVi
                         join cv in db.ChucVus on nv.MaChucVu equals cv.MaChucVu
                         join ngach in db.NgachLuongs on nv.MaNgach equals ngach.MaNgach
                         join hs in db.HeSoLuongPhuCaps on nv.MaHeSo equals hs.MaHeSo
                         select nv;
                list = ds.ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Đổ DL vào combobox đơn vị
        public List<DonVi> LayDLDonVi()
        {
            try
            {
                List<DonVi> list = new List<DonVi>();
                var ds = from dv in db.DonVis
                         join loaidv in db.LoaiDonVis on dv.MaLoai equals loaidv.MaLoai
                         select dv;
                list = ds.ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Đổ DL vào combobox chức vụ
        public List<ChucVu> LayDLChucVu()
        {
            try
            {
                List<ChucVu> list = new List<ChucVu>();
                var dsCV = from cv in db.ChucVus
                           select cv;
                list = dsCV.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
