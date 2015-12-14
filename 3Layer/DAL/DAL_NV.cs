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
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex);
                return false;
            }
        }
        public bool Search(NhanVien nv)
        {
            var search = db.NhanViens.FirstOrDefault(a => a.MaNV == nv.MaNV || a.HoTen == nv.HoTen || a.MaDonVi == nv.MaDonVi || a.MaChucVu == nv.MaChucVu);
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
                list = db.NhanViens.SqlQuery("select * from dbo.Nhanvien nv" +
                                                " left join dbo.Chucvu cv on nv.machucvu=cv.machucvu" +
                                                " left join dbo.Donvi dv on nv.madonvi=dv.madonvi" +
                                                " left join dbo.NgachLuong ngach on nv.mangach=ngach.mangach").ToList();
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

        //Tìm nhân viên
        public List<NhanVien> TimNhanVien(string maNV, string tenNV, string donVi, string chucVu)
        {
            try
            {
                List<NhanVien> list = new List<NhanVien>();
                string cauTruyVan = "select * from dbo.Nhanvien nv" +
                                            " left join dbo.Chucvu cv on nv.machucvu=cv.machucvu" +
                                            " left join dbo.Donvi dv on nv.madonvi=dv.madonvi" +
                                            " left join dbo.NgachLuong ngach on nv.mangach=ngach.mangach ";
                
                if (maNV != "")
                {
                    cauTruyVan += " where nv.maNV = '" + maNV + "'";
                }
                if (tenNV != "")
                {
                    cauTruyVan += " where nv.maNV like '%" + tenNV + "%'";
                }
                if (donVi != "----Tất cả----")
                {
                    cauTruyVan += " where nv.maDonVi = '" + donVi + "'";
                }
                if (chucVu != "----Tất cả----")
                {
                    cauTruyVan += " where nv.maChucVu = '" + chucVu + "'";
                }

                list = db.NhanViens.SqlQuery(cauTruyVan).ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Thêm nhân viên
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Tạo mã tự động
        public string TaoMaNV()
        {
            try
            {
                var ma = from nv in db.NhanViens
                         orderby nv.MaNV descending
                         select nv.MaNV;

                string maNV = ma.First().ToString();
                int so = int.Parse(maNV.Substring(2));
                int soTang = so + 1;
                string kq = "";
                if(ma.Count() == 0)
                {
                    kq = "NV0001";
                }
                if (soTang < 10)
                {
                    kq = "NV000" + soTang.ToString();
                }
                else if (soTang < 100)
                {
                    kq = "NV00" + soTang.ToString();
                }
                else if (soTang < 1000)
                {
                    kq = "NV0" + soTang.ToString();
                }
                else
                {
                    kq = "NV" + soTang.ToString();
                }
                return kq;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //đổ DL vào combobox Ngạch lương
        public List<NgachLuong> LayDLNgachLuong()
        {
            try
            {
                List<NgachLuong> list = new List<NgachLuong>();
                var dsNgach = from ngach in db.NgachLuongs
                              select ngach;
                list = dsNgach.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Sửa thông tin nhân viên
        public bool SuaNhanVien(NhanVien nvSua)
        {
            try
            {
                db.NhanViens.Attach(nvSua);
                var nhanvien = db.Entry(nvSua);
                nhanvien.Property(s => s.HoTen).IsModified = true;
                //nhanvien.Property(s => s.MaNgach).IsModified = true;
                //nhanvien.Property(s => s.MaHeSo).IsModified = true;
                nhanvien.Property(s => s.NgaySinh).IsModified = true;
                nhanvien.Property(s => s.DanToc).IsModified = true;
                nhanvien.Property(s => s.GioiTinh).IsModified = true;
                nhanvien.Property(s => s.CMND).IsModified = true;
                nhanvien.Property(s => s.DiaChi).IsModified = true;
                nhanvien.Property(s => s.HinhAnh).IsModified = true;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Lấy hệ số lương theo mã ngạch==> đổ vào cb
        public List<HeSoLuongPhuCap> LayHeSoTheoMaNgach(string maNgach)
        {
            try
            {
                var query = from hs in db.HeSoLuongPhuCaps
                            where hs.MaNgach == maNgach
                            select hs;
                List<HeSoLuongPhuCap> list = new List<HeSoLuongPhuCap>();
                list = query.ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Xoá nhân viên
        public bool XoaNhanVien(string maXoa)
        {
            try
            {
                NhanVien nvXoa = (NhanVien)db.NhanViens.Where(s => s.MaNV == maXoa).First();
                db.NhanViens.Remove(nvXoa);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //tìm  nhân viên theo mã
        public NhanVien TimNhanVienTheoMa(string maNV)
        {
            try
            {
                var query = db.NhanViens.SqlQuery("select * from dbo.Nhanvien nv" +
                                                " left join dbo.Chucvu cv on nv.machucvu=cv.machucvu" +
                                                " left join dbo.Donvi dv on nv.madonvi=dv.madonvi" +
                                                " left join dbo.NgachLuong ngach on nv.mangach=ngach.mangach where nv.maNV='"+maNV+"'");
                NhanVien nhanVien = query.FirstOrDefault();
                return nhanVien;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
