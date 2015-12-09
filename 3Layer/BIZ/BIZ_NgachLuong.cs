using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Layer.DAL;

namespace _3Layer.BIZ
{
    public class BIZ_NgachLuong
    {
        DAL_NgachLuong dalNgach = new DAL_NgachLuong();
        
        public List<NgachLuong> BIZ_LayDuLieuNgach()
        {
            return dalNgach.LayDuLieuNgach();
        }

        public List<NgachLuong> BIZ_TimNgachLuong(string maTim, string tenTim)
        {
            return dalNgach.TimNgachLuong(maTim, tenTim);
        }

        public bool BIZ_ThemNgachLuong(NgachLuong ngach)
        {
            return dalNgach.ThemNgachLuong(ngach);
        }

        public bool BIZ_XoaNgachLuong(string maXoa)
        {
            return dalNgach.XoaNgachLuong(maXoa);
        }

        public string BIZ_TaoMaNgachLuong()
        {
            return dalNgach.TaoMaNgachLuong();
        }

        public bool BIZ_SuaNgachLuong(NgachLuong ngachSua)
        {
            return dalNgach.SuaNgachLuong(ngachSua);
        }

        public NgachLuong BIZ_TimNgachLuongTheoMa(string maTim)
        {
            return dalNgach.TimNgachLuongTheoMa(maTim);
        }
    }
}
