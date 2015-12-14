using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.BIZ
{
    public class BIZ_NV
    {
        NhanVien nv = new NhanVien();
        DAL.DAL_NV dal = new DAL.DAL_NV();
        public bool Create(NhanVien nv)
        {
            return dal.Create(nv);
        }
        public bool Search(NhanVien nv)
        {
            return dal.Search(nv);
        }

        public List<NhanVien> BIZ_LayDuLieuNV()
        {
            return dal.LayDuLieuNV();
        }

        public List<DonVi> BIZ_LayDLDonVi()
        {
            return dal.LayDLDonVi();
        }

        public List<ChucVu> BIZ_LayDLChucVu()
        {
            return dal.LayDLChucVu();
        }

        public List<NhanVien> BIZ_TimNhanVien(string maNV, string tenNV, string donVi, string chucVu)
        {
            return dal.TimNhanVien(maNV, tenNV, donVi, chucVu);
        }

        public bool BIZ_ThemNhanVien(NhanVien nv)
        {
            return dal.ThemNhanVien(nv);
        }

        public string BIZ_TaoMaNV()
        {
            return dal.TaoMaNV();
        }

        public List<NgachLuong> BIZ_LayDLNgachLuong()
        {
            return dal.LayDLNgachLuong();
        }

        public DateTime? BIZ_TinhNgayHuu(DateTime ngaySinh, string gioiTinh)
        {
            try
            {
                DateTime ngayHuu;
                int nam;
                if (gioiTinh == "Nữ")
                {
                    nam = ngaySinh.Year + 55;
                }
                else
                {
                    nam = ngaySinh.Year + 60;
                }
                ngayHuu = new DateTime(nam, ngaySinh.Month, ngaySinh.Day);
                return ngayHuu;
            }
            catch (Exception ex)
            {                
                return null;
            }
        }

        public List<HeSoLuongPhuCap> BIZ_LayHeSoTheoMaNgach(string maNgach)
        {
            return dal.LayHeSoTheoMaNgach(maNgach);
        }

        public bool BIZ_XoaNhanVien(string maXoa)
        {
            return dal.XoaNhanVien(maXoa);
        }

        public NhanVien BIZ_TimNhanVienTheoMa(string maNV)
        {
            return dal.TimNhanVienTheoMa(maNV);
        }

        public bool BIZ_SuaNhanVien(NhanVien nvSua)
        {
            return dal.SuaNhanVien(nvSua);
        }

        public List<NhanVien> BIZ_ThongKeNhanVienVeHuu(string tuNgay, string denNgay)
        {
            return dal.ThongKeNhanVienVeHuu(tuNgay, denNgay);
        }
    }
}
