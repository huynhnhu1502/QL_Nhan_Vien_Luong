using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{
    class DAL_NgachLuong
    {
        QuanLyLuongEntities entity = new QuanLyLuongEntities();

        //đổ DL vào gridview
        public List<NgachLuong> LayDuLieuNgach()
        {
            try
            {
                List<NgachLuong> list = new List<NgachLuong>();
                var ds = from ngach in entity.NgachLuongs
                         select ngach;
                list = ds.ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Tìm
        public List<NgachLuong> TimNgachLuong(string maTim, string tenTim)
        {
            try
            {
                List<NgachLuong> list = new List<NgachLuong>();
                var dsTim = from ngach in entity.NgachLuongs
                            select ngach;
                if(maTim != "")
                {
                    dsTim = dsTim.Where(s => s.MaNgach.Equals(maTim));
                }
                if(tenTim != "")
                {
                    dsTim = dsTim.Where(s => s.TenNgach.Contains(tenTim));
                }
                list = dsTim.ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
