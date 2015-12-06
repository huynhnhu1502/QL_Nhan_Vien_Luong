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
        public bool TimKiem(ChucVu chucvu)
        {
            return _dalchucvu.TimKiem(chucvu);
        }

        public bool ThemCV(ChucVu chucvu)
        {
            return _dalchucvu.themChucVu(chucvu);
        }

        public List<ChucVu> DSChucVu()
        {
            return DAL_ChucVu.listall();
        }

    }
}
