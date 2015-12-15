using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{
    class DAL_LichSuCongTac
    {
        QuanLyLuongEntities entity = new QuanLyLuongEntities();
        //đổ DL vào gridview
        public List<LichSuCongTac> LayDuLieu()
        {
            try
            {
                List<LichSuCongTac> list = new List<LichSuCongTac>();
                var ds = from lsct in entity.LichSuCongTacs
                         join dv in entity.DonVis on lsct.MaDonVi equals dv.MaDonVi
                         join nv in entity.NhanViens on lsct.MaNV equals nv.MaNV
                         join cv in entity.ChucVus on lsct.MaChucVu equals cv.MaChucVu
                         join ngach in entity.NgachLuongs on lsct.MaNgach equals ngach.MaNgach
                         select lsct;
                list = ds.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }            
        }

        //đổ DL vào combobox đơn vị
        public List<DonVi> LayDLDonVi()
        {
            try
            {
                List<DonVi> list = new List<DonVi>();
                var ds = from dv in entity.DonVis
                         join loaidv in entity.LoaiDonVis on dv.MaLoai equals loaidv.MaLoai
                         select dv;
                list = ds.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //đổ DL vào combobox chức vụ
        public List<ChucVu> LayDLChucVu()
        {
            try
            {
                List<ChucVu> list = new List<ChucVu>();
                var dsCV = from cv in entity.ChucVus
                           select cv;
                list = dsCV.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Tìm
        public List<LichSuCongTac> TimLSCongTac(string maNV, string tenNV, string donVi, string chucVu)
        {
            try
            {
                List<LichSuCongTac> list = new List<LichSuCongTac>();
                var dsTim = from lsct in entity.LichSuCongTacs
                            join nv in entity.NhanViens on lsct.MaNV equals nv.MaNV
                            join dv in entity.DonVis on lsct.MaDonVi equals dv.MaDonVi
                            join cv in entity.ChucVus on lsct.MaChucVu equals cv.MaChucVu
                            join ngach in entity.NgachLuongs on lsct.MaNgach equals ngach.MaNgach
                            select lsct;
                if(maNV != "")
                {
                    dsTim = dsTim.Where(s => s.MaNV.Equals(maNV));
                }
                if(tenNV != "")
                {
                    dsTim = dsTim.Where(s => s.NhanVien.HoTen.Contains(tenNV));
                }
                if(donVi != "----Tất cả----")
                {
                    dsTim = dsTim.Where(s => s.MaDonVi.Equals(donVi));
                }
                if (chucVu != "----Tất cả----")
                {
                    dsTim = dsTim.Where(s => s.MaChucVu.Equals(chucVu));
                }
                list = dsTim.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Thêm LS công tác
        public bool ThemLSCongTac(LichSuCongTac lsct)
        {
            try
            {
                entity.LichSuCongTacs.Add(lsct);
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //đổ DL vào combobox Ngạch lương
        public List<NgachLuong> LayDLNgachLuong()
        {
            try
            {
                List<NgachLuong> list = new List<NgachLuong>();
                var dsNgach = from ngach in entity.NgachLuongs
                           select ngach;
                list = dsNgach.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //hàm tạo mã tự động 
        public string TaoMaLSCongTac()
        {
            try
            {
                var ma = from lsct in entity.LichSuCongTacs
                         orderby lsct.MaCongTac descending
                         select lsct.MaCongTac;
                string maCongTac = ma.First().ToString();
                int so = int.Parse(maCongTac.Substring(2));
                int soTang = so + 1;
                string kq = "";
                if(ma.Count() == 0)
                {
                    kq = "CT0001";
                }
                if (soTang < 10)
                {
                    kq = "CT000" + soTang.ToString();
                }
                else if(soTang < 100)
                {
                    kq = "CT00" + soTang.ToString();
                }
                else if(soTang <1000)
                {
                    kq = "CT0" + soTang.ToString();
                }
                else
                {
                    kq = "CT" + soTang.ToString();
                }
                return kq;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //kiểm tra mã nhân viên có tồn tại không
        public bool KiemTraMaNV(string maNhap)
        {
            try
            {
                var maTim = from nv in entity.NhanViens
                            where nv.MaNV == maNhap
                            select nv.MaNV;        
                if(maTim.Count() > 0)
                {
                    return true;
                }      
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<LichSuCongTac> XuatChiTietCongTac(string MaNV)
        {
            List<LichSuCongTac> congtac = new List<LichSuCongTac>();
            congtac = ((from u in entity.LichSuCongTacs.ToList()
                        from t in entity.DonVis.ToList()
                        from e in entity.ChucVus.ToList()
                        from p in entity.NgachLuongs.ToList()
                        where u.MaNV.Equals(MaNV) && u.MaDonVi == t.MaDonVi && u.MaChucVu == e.MaChucVu && u.MaNgach == p.MaNgach
                        select new LichSuCongTac()
                        {
                            MaCongTac = u.MaCongTac,
                            TenDonVi = t.TenDonVi,
                            TenChucVu = e.TenChucVu,
                            TenNgach = p.TenNgach,
                            NgayLam = u.NgayLam,
                            NgayChuyen = u.NgayChuyen
                        }).ToList());
            return congtac;
        }

        public List<NhanVien> XuatThongKeLichSuCongTac(string HoTen)
        {
            var nhanvien = (from u in entity.NhanViens select u);
            if (!String.IsNullOrEmpty(HoTen))
            {
                nhanvien = nhanvien.Where(c => c.HoTen.Contains(HoTen));
            }
            return nhanvien.ToList();
        }

        //Tìm nhân viên theo mã
        public NhanVien TimNhanVien(string maTim)
        {
            try
            {
                var list = (from nv in entity.NhanViens
                            join dv in entity.DonVis on nv.MaDonVi equals dv.MaDonVi
                            join cv in entity.ChucVus on nv.MaChucVu equals cv.MaChucVu
                            join ngach in entity.NgachLuongs on nv.MaNgach equals ngach.MaNgach
                            where nv.MaNV == maTim
                            select nv).ToList();
                if (list.Count() > 0)
                {
                    NhanVien nVien = list[0];
                    return nVien;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Cập nhật nhân viên
        public bool CapNhatNhanVien(NhanVien nhanVienMoi)
        {
            try
            {
                entity.NhanViens.Attach(nhanVienMoi);
                var muc = entity.Entry(nhanVienMoi);

                //đổi thuộc tính nào trong csdl thì lấy thuộc tính đó .IsModified = true 
                muc.Property(s => s.MaDonVi).IsModified = true;
                muc.Property(s => s.MaChucVu).IsModified = true;
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Xoá
        public bool XoaLichSuCongTac(string maXoa)
        {
            try
            {
                LichSuCongTac lsct = (LichSuCongTac)entity.LichSuCongTacs.Where(b => b.MaCongTac == maXoa).First();
                entity.LichSuCongTacs.Remove(lsct);
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        //Sửa LS công tác (cập nhật ngày chuyển)
        public bool SuaLichSuCongTac(LichSuCongTac moi)
        {
            try
            {
                entity.LichSuCongTacs.Attach(moi);
                var lsct = entity.Entry(moi);
                lsct.Property(s => s.NgayChuyen).IsModified = true;
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Tìm LS công tác theo mã công tác (để đổ DL vào form sửa)
        public LichSuCongTac TimLSCongTacTheoMa(string maCongTac)
        {
            try
            {
                var dsTim = (from lsct in entity.LichSuCongTacs
                             join nv in entity.NhanViens on lsct.MaNV equals nv.MaNV
                             join dv in entity.DonVis on lsct.MaDonVi equals dv.MaDonVi
                             join cv in entity.ChucVus on lsct.MaChucVu equals cv.MaChucVu
                             join ngach in entity.NgachLuongs on lsct.MaNgach equals ngach.MaNgach
                             where lsct.MaCongTac == maCongTac
                             select lsct).ToList();
                if (dsTim.Count() > 0)
                {
                    LichSuCongTac lichSu = dsTim[0];
                    return lichSu;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
