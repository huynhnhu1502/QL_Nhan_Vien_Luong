using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{
    class DAL_HeSoLuong
    {
        QuanLyLuongEntities entity = new QuanLyLuongEntities();

        //Lấy DL đổ vào grid
        public List<HeSoLuongPhuCap> LayDuLieu()
        {
            try
            {
                entity = new QuanLyLuongEntities();
                List<HeSoLuongPhuCap> list = new List<HeSoLuongPhuCap>();
                var ds = from hsl in entity.HeSoLuongPhuCaps
                         join ngach in entity.NgachLuongs on hsl.MaNgach equals ngach.MaNgach
                         select hsl;
                list = ds.ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Lấy DL ngạch lương đổ vào combobox
        public List<NgachLuong> LayDLNgach()
        {
            try
            {
                List<NgachLuong> ngach = new List<NgachLuong>();
                //var ds = from ngachLuong in entity.NgachLuongs
                //         join 
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
