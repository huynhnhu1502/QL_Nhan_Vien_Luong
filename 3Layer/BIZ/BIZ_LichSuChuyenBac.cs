using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.BIZ
{
  public  class BIZ_LichSuChuyenBac

    {
        DAL.DAL_LichSuChuyenBac _dallscb = new DAL.DAL_LichSuChuyenBac();
        LichSuChuyenBac _lscb = new LichSuChuyenBac();
        public bool ThemLichSu(LichSuChuyenBac lscb)
        {
            return _dallscb.themchuyenbac(lscb);
        }

    }
}
