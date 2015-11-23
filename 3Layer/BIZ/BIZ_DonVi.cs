using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.BIZ
{
    public class BIZ_DonVi
    {
        DAL.DAL_DonVi _daldonvi = new DAL.DAL_DonVi();
        DonVi _donvi = new DonVi();
        public bool TimKiem(DonVi donvi)
        {
            return _daldonvi.TimKiem(donvi);
        }
        public bool themDonVi(DonVi donvi)
        {
            return _daldonvi.themDonVi(donvi);
        }
    }
}
