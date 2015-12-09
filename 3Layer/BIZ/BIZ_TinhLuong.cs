using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.BIZ
{
    public class BIZ_TinhLuong
    {
        NhanVien nv = new NhanVien();
        DAL.DAL_TinhLuong _dalTinhLuong = new DAL.DAL_TinhLuong();
        public bool TinhLuong(string Manv)
        {
            return _dalTinhLuong.TinhLuong(Manv);
        }
    }
}
