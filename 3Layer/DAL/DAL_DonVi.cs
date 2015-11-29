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
        public bool TimKiem(DonVi donvi)
        {
            var search = db.DonVis.FirstOrDefault(a => a.MaDonVi == donvi.MaDonVi || a.TenDonVi == donvi.TenDonVi || a.MaLoai == donvi.MaLoai);
            if (search != null)
            {
                return true;
            }
            return false;
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
    }
}
