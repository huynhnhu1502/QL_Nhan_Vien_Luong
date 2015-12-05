using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{
    public class DAL_ChucVu
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities() ;
        //Load danh sách
        public static List<ChucVu> listall()
        {
            QuanLyLuongEntities model = new QuanLyLuongEntities();
            List<ChucVu> list = new List<ChucVu>();
            list = (from n in model.ChucVus select n).ToList();
            return list;
           
        }

        //Tim chuc vu
        public bool TimKiem(ChucVu chucvu)
        {
            var search = db.ChucVus.Where(a => a.MaChucVu.Contains(chucvu.MaChucVu) &&  a.TenChucVu.Contains(chucvu.TenChucVu) && a.HeSoCV == chucvu.HeSoCV).ToList();
            if (search != null)
            {
                return true;
            }
            return false;
        }

        public bool themChucVu(ChucVu chucvu)
        {
            try
            {
                ChucVu cv = new ChucVu {MaChucVu = chucvu.MaChucVu, TenChucVu = chucvu.TenChucVu, HeSoCV = chucvu.HeSoCV};
                db.ChucVus.Add(cv);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;

        }


    }
}
