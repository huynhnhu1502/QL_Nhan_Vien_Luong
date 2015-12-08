using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Layer.DAL;

namespace _3Layer.BIZ
{
    public class BIZ_DonVi
    {

        DAL.DAL_DonVi _daldonvi = new DAL.DAL_DonVi();
        DonVi _donvi = new DonVi();
        public List<DonVi> DSDonVi()
        {
            return DAL_DonVi.listall();
        }
        public List<LoaiDonVi> BIZLayLoai()
        {
            return _daldonvi.LayLoai();
        }
        public List<DonVi> BIZTimKiem(string ma ,string ten ,string loai)
        {
            return _daldonvi.TimKiem(ma,ten,loai);
        }
        public bool themDonVi(DonVi donvi)
        {
            return _daldonvi.themDonVi(donvi);
        }
        public bool SuaDonVi(DonVi donvi)
        {
            return _daldonvi.Suadonvi(donvi);
        }
    }
}
