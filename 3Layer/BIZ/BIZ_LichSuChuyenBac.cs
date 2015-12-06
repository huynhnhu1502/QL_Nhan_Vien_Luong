using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Layer.DAL;

namespace _3Layer.BIZ
{
  public  class BIZ_LichSuChuyenBac

    {
        DAL_LichSuChuyenBac _dallscb = new DAL_LichSuChuyenBac();
        LichSuChuyenBac _lscb = new LichSuChuyenBac();
        public bool ThemLichSu(LichSuChuyenBac lscb)
        {
            return _dallscb.themchuyenbac(lscb);
        }

        public List<LichSuChuyenBac> BIZTimLSChuyenBac(string tim, string tungay, string denngay)
        {
            return _dallscb.timkiem(tim, tungay, denngay);
        }

        public List<LichSuChuyenBac> BIZLayDS()
        {
            return DAL_LichSuChuyenBac.listall();
        }
        public List<NgachLuong> BIZLayNgach()
        {
            return _dallscb.LayNgach();
        }
    }
}
