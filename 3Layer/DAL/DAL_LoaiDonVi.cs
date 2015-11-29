using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{
    class DAL_LoaiDonVi
    {
        QuanLyLuongEntities _db = new QuanLyLuongEntities();
        LoaiDonVi _loaidonvi = new LoaiDonVi();
        public bool TimKiem(LoaiDonVi loaidonvi)
        {
            var search = _db.LoaiDonVis.Where(a => a.MaLoai == loaidonvi.MaLoai || a.TenLoai == loaidonvi.TenLoai);
            if (search != null)
            {
                return true;
            }
            return false;
        }
        public bool ThemLoai(LoaiDonVi loaidonvi)
        {
            try
            {
                var them = new LoaiDonVi { MaLoai = loaidonvi.MaLoai, TenLoai = loaidonvi.TenLoai, MoTa = loaidonvi.MoTa };
                _db.LoaiDonVis.Add(them);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaLoai(LoaiDonVi loaidv)
        {
            try
            {
                var sua = _db.LoaiDonVis.FirstOrDefault(a => a.MaLoai == loaidv.MaLoai);
                if (sua != null)
                {
                    sua.TenLoai = loaidv.TenLoai;
                    sua.MoTa = loaidv.MoTa;
                    _db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
