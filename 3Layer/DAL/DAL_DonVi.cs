using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{
    class DAL_DonVi
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        DonVi _donvi = new DonVi();
        public static List<DonVi> listall()
        {
            QuanLyLuongEntities model = new QuanLyLuongEntities();
            List<DonVi> list = new List<DonVi>();
            list = (from n in model.DonVis select n).ToList();
            return list;

        }

        public List<DonVi> TimKiem(string ma , string ten , string loai)
        {
            QuanLyLuongEntities db = new QuanLyLuongEntities();
            List<DonVi> KQTim = new List<DonVi>();
            try
            {
                if (ma != "" && ten != "" && loai != "")
                {
                    KQTim = (from dv in db.DonVis.ToList()
                              where dv.MaDonVi.Contains(ma) && dv.TenDonVi.Contains(ten) && dv.MaLoai == loai

                             select dv).ToList() ;
                }
                else if(ma == "" && ten != "" && loai != "")
                {
                    KQTim = (from dv in db.DonVis.ToList()
                             where  dv.TenDonVi.Contains(ten) && dv.MaLoai == loai

                             select dv).ToList();
                }

                else if (ma != "" && ten == "" && loai != "")
                {
                    KQTim = (from dv in db.DonVis.ToList()
                             where dv.MaDonVi.Contains(ma) &&  dv.MaLoai == loai

                             select dv).ToList();
                }
                else if (ma != "" && ten != "" && loai == "")
                {
                    KQTim = (from dv in db.DonVis.ToList()
                             where dv.MaDonVi.Contains(ma) && dv.TenDonVi.Contains(ten) 

                             select dv).ToList();
                }
                else if (ma != "" && ten == "" && loai == "")
                {
                    KQTim = (from dv in db.DonVis.ToList()
                             where dv.MaDonVi.Contains(ma) 

                             select dv).ToList();
                }
                else if (ma == "" && ten != "" && loai == "")
                {
                    KQTim = (from dv in db.DonVis.ToList()
                             where  dv.TenDonVi.Contains(ten) 

                             select dv).ToList();
                }
                else if (ma == "" && ten == "" && loai != "")
                {
                    KQTim = (from dv in db.DonVis.ToList()
                             where  dv.MaLoai == loai

                             select dv).ToList();
                }


                return KQTim;
            }
            catch (Exception)
            {

                throw;
            }



        }
        public bool themDonVi(DonVi donvi)
        {
            try
            {
                DonVi dv = new DonVi { MaDonVi = donvi.MaDonVi, TenDonVi = donvi.TenDonVi, MaLoai = donvi.MaLoai, DiaChi = donvi.DiaChi, DienThoai = donvi.DienThoai, NamThanhLap = donvi.NamThanhLap, ChucNang = donvi.ChucNang, NhiemVu = donvi.NhiemVu };
                db.DonVis.Add(dv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LoaiDonVi> LayLoai()
        {
            QuanLyLuongEntities db = new QuanLyLuongEntities();
        
            try
            {
                List<LoaiDonVi> list = new List<LoaiDonVi>();
                var ds = from dv in db.LoaiDonVis
                         join loaidv in db.LoaiDonVis on dv.MaLoai equals loaidv.MaLoai
                         select dv;
                list = ds.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Suadonvi(DonVi donvi)
        {
            QuanLyLuongEntities csdl = new QuanLyLuongEntities();
            try
            {

                DonVi dv = csdl.DonVis.SingleOrDefault(n => n.MaDonVi == donvi.MaDonVi);
                dv.TenDonVi = donvi.TenDonVi;
                dv.MaLoai = donvi.MaLoai;
                dv.DienThoai = donvi.DienThoai;
                dv.DiaChi = donvi.DiaChi;
                dv.ChucNang = donvi.ChucNang;
                dv.NhiemVu = donvi.NhiemVu;
                dv.NamThanhLap = dv.NamThanhLap;
                csdl.SaveChanges();
               

            }
            catch
            {
                return false;
            }
            return true;
        }
        public List<NhanVien> XuatDSNVTrongDonVi(string MaDonVi)
        {
            List<NhanVien> result = new List<NhanVien>();
            result = ((from u in db.NhanViens.ToList()
                       from e in db.DonVis.ToList()
                       from t in db.ChucVus.ToList()
                       where u.MaDonVi == MaDonVi && u.MaDonVi == e.MaDonVi && u.MaChucVu == t.MaChucVu
                       select new NhanVien()
                       {
                           MaNV = u.MaNV,
                           HoTen = u.HoTen,
                           NgaySinh = u.NgaySinh,
                           DanToc = u.DanToc,
                           GioiTinh = u.GioiTinh,
                           CMND = u.CMND,
                           DiaChi = u.DiaChi,
                           HinhAnh = u.HinhAnh
                       }).ToList());
            result = db.NhanViens.SqlQuery("select * from dbo.Nhanvien nv" +
                                                " left join dbo.Chucvu cv on nv.machucvu=cv.machucvu" +
                                                " left join dbo.Donvi dv on nv.madonvi=dv.madonvi" +
                                                " left join dbo.NgachLuong ngach on nv.mangach=ngach.mangach where nv.maDonVi = '"+MaDonVi+"'").ToList();
            return result;
        }
        public List<NhanVien> ExportDataNVTrongDV(string maDonVi)
        {
            List<NhanVien> result111 = new List<NhanVien>();
            result111 = ((from u in db.NhanViens.ToList()
                         from e in db.ChucVus.ToList()
                         where u.MaDonVi == maDonVi && u.MaChucVu == e.MaChucVu
                         select new NhanVien() { MaNV = u.MaNV, HoTen = u.HoTen,  NgaySinh = u.NgaySinh, DanToc = u.DanToc, GioiTinh = u.GioiTinh, CMND = u.CMND, DiaChi = u.DiaChi }).ToList());
            return result111;
        }

    }
}

