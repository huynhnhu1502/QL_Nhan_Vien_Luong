using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Layer.DAL;

namespace _3Layer.BIZ
{
    public class BIZ_LoaiDonVi
    {
        LoaiDonVi _loaidonvi = new LoaiDonVi();
        DAL.DAL_LoaiDonVi _dalloaidv = new DAL.DAL_LoaiDonVi();

        public List<LoaiDonVi> DSLoaidv()
        {
            return _dalloaidv.listall();
        }
        public List<LoaiDonVi> BIZTimKiem(string ma , string ten)
        {
            return _dalloaidv.TimKiem(ma, ten );
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
