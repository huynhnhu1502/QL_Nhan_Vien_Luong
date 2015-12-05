using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.BIZ
{
    public class BIZ_ChucVu
    {
        DAL.DAL_ChucVu _dalchucvu = new DAL.DAL_ChucVu();
        ChucVu _chucvu = new ChucVu();
        public bool TimKiem(ChucVu chucvu)
        {
            return _dalchucvu.TimKiem(chucvu);
        }

        public bool ThemCV(ChucVu chucvu)
        {
            return _dalchucvu.themChucVu(chucvu);
        }

       
    }
}
