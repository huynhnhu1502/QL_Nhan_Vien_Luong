using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.BIZ
{
    public class BIZ_NV
    {
        NhanVien nv = new NhanVien();
        DAL.DAL_NV dal = new DAL.DAL_NV();
        public bool Create(NhanVien nv)
        {
            return dal.Create(nv);
        }
        public bool Search(NhanVien nv)
        {
            return dal.Search(nv);
        }

        public List<NhanVien> BIZ_LayDuLieuNV()
        {
            return dal.LayDuLieuNV();
        }

        public List<DonVi> BIZ_LayDLDonVi()
        {
            return dal.LayDLDonVi();
        }

        public List<ChucVu> BIZ_LayDLChucVu()
        {
            return dal.LayDLChucVu();
        }
    }
}
