using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Layer.DAL;

namespace _3Layer.BIZ
{
    public class BIZ_ChucVu
    {
        DAL_ChucVu _dalchucvu = new DAL_ChucVu();
        ChucVu _chucvu = new ChucVu();
        public List<ChucVu> TimKiem(string ma, string ten, string heso)
        {
            return _dalchucvu.TimKiem(ma,ten,heso);
        }

        public bool ThemCV(ChucVu chucvu)
        {
            return _dalchucvu.themChucVu(chucvu);
        }

        public List<ChucVu> DSChucVu()
        {
            return DAL_ChucVu.listall();
        }
        public bool BizTimKiem(ChucVu chucvu)
        {
            return _dalchucvu.Suachucvu(chucvu);
        }
    }
}
