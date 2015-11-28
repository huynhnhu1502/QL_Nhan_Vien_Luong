using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.BIZ
{
    public class BIZ_LoaiDonVi
    {
        LoaiDonVi _loaidonvi = new LoaiDonVi();
        DAL.DAL_LoaiDonVi _dalloaidv = new DAL.DAL_LoaiDonVi();
        public bool TimKiem(LoaiDonVi loaidonvi)
        {
            return _dalloaidv.TimKiem(loaidonvi);
        }
        public bool ThemLoai(LoaiDonVi loaidonvi)
        {
            return _dalloaidv.ThemLoai(loaidonvi);
        }
        public bool SuaLoai(LoaiDonVi loaidv)
        {
            return _dalloaidv.SuaLoai(loaidv);
        }
    }
}
