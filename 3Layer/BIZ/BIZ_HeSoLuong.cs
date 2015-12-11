using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Layer.DAL;

namespace _3Layer.BIZ
{
    public class BIZ_HeSoLuong
    {
        DAL_HeSoLuong dalHeSo = new DAL_HeSoLuong();

        public List<HeSoLuongPhuCap> BIZ_LayDuLieu()
        {
            return dalHeSo.LayDuLieu();
        }

        public List<NgachLuong> BIZ_LayDLNgach()
        {
            return dalHeSo.LayDLNgach();
        }

        public List<HeSoLuongPhuCap> BIZ_TimHeSoLuong(string tenNgach, double heSo)
        {
            return dalHeSo.TimHeSoLuong(tenNgach, heSo);
        }

        public bool BIZ_ThemHeSoLuong(HeSoLuongPhuCap heSo)
        {
            return dalHeSo.ThemHeSoLuong(heSo);
        }

        public string BIZ_TaoMaHeSoLuong()
        {
            return dalHeSo.TaoMaHeSoLuong();
        }

        public bool BIZ_SuaHeSoLuong(HeSoLuongPhuCap heSoSua)
        {
            return dalHeSo.SuaHeSoLuong(heSoSua);
        }

        public HeSoLuongPhuCap BIZ_TimHeSoTheoMa(string maHeSo)
        {
            return dalHeSo.TimHeSoTheoMa(maHeSo);
        }

        public bool BIZ_KiemTraTenHeSo(string maNgach, string tenHeSo)
        {
            return dalHeSo.KiemTraTenHeSo(maNgach, tenHeSo);
        }

        public bool BIZ_XoaHeSoLuong(string maXoa)
        {
            return dalHeSo.XoaHeSoLuong(maXoa);
        }
    }
}
