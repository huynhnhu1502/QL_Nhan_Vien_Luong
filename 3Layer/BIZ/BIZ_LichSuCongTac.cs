using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Layer.DAL;

namespace _3Layer.BIZ
{
    public class BIZ_LichSuCongTac
    {
        DAL_LichSuCongTac dalLSCongTac = new DAL_LichSuCongTac();
        public List<LichSuCongTac> BIZLayDuLieu()
        {
            return dalLSCongTac.LayDuLieu();
        }

        public List<DonVi> BIZLayDLDonVi()
        {
            return dalLSCongTac.LayDLDonVi();
        }

        public List<ChucVu> BIZLayDLChucVu()
        {
            return dalLSCongTac.LayDLChucVu();
        }

        public List<LichSuCongTac> BIZTimLSCongTac(string maNV, string tenNV, string donVi, string chucVu)
        {
            return dalLSCongTac.TimLSCongTac(maNV, tenNV,donVi, chucVu);
        }

        public bool BIZThemLSCongTac(LichSuCongTac lsct)
        {
            return dalLSCongTac.ThemLSCongTac(lsct);
        }

        public List<NgachLuong> BIZLayDLNgachLuong()
        {
            return dalLSCongTac.LayDLNgachLuong();
        }

        public string BIZTaoMaLSCongTac()
        {
            return dalLSCongTac.TaoMaLSCongTac();
        }

        public bool BIZKiemTraMaNV(string maNhap)
        {
            return dalLSCongTac.KiemTraMaNV(maNhap);
        }

        public NhanVien BIZTimNhanVien(string maTim)
        {
            return dalLSCongTac.TimNhanVien(maTim);
        }

        public bool BIZCapNhatNhanVien(NhanVien nhanVienMoi)
        {
            return dalLSCongTac.CapNhatNhanVien(nhanVienMoi);
        }

        public bool BIZXoaLichSuCongTac(string maXoa)
        {
            return dalLSCongTac.XoaLichSuCongTac(maXoa);
        }

        public bool BIZSuaLichSuCongTac(LichSuCongTac moi)
        {
            return dalLSCongTac.SuaLichSuCongTac(moi);
        }

        public LichSuCongTac BIZTimLSCongTacTheoMa(string maCongTac)
        {
            return dalLSCongTac.TimLSCongTacTheoMa(maCongTac);
        }
    }
}
