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
        public List<ChucVu> TimKiem(string ma, string ten, string heso)
        {
            QuanLyLuongEntities db = new QuanLyLuongEntities();
            List<ChucVu> KQTim = new List<ChucVu>();
            try
            {
                double hesotim;
                if (ma != "" && ten != "" && heso != "")
                {
                    hesotim = Convert.ToDouble(heso);
                    KQTim = (from dv in db.ChucVus.ToList()
                             where dv.MaChucVu.Contains(ma) && dv.TenChucVu.Contains(ten) && dv.HeSoCV == hesotim

                             select dv).ToList();
                }
                else if (ma == "" && ten != "" && heso != "")
                {
                    hesotim = Convert.ToDouble(heso);
                    KQTim = (from dv in db.ChucVus.ToList()
                             where dv.TenChucVu.Contains(ten) && dv.HeSoCV == hesotim

                             select dv).ToList();
                }

                else if (ma != "" && ten == "" && heso != "")
                {
                    hesotim = Convert.ToDouble(heso);
                    KQTim = (from dv in db.ChucVus.ToList()
                             where dv.MaChucVu.Contains(ma) && dv.HeSoCV == hesotim

                             select dv).ToList();
                }
                else if (ma != "" && ten != "" && heso == "")
                {
                    KQTim = (from dv in db.ChucVus.ToList()
                             where dv.MaChucVu.Contains(ma) && dv.TenChucVu.Contains(ten)

                             select dv).ToList();
                }
                else if (ma != "" && ten == "" && heso == "")
                {
                    KQTim = (from dv in db.ChucVus.ToList()
                             where dv.MaChucVu.Contains(ma)

                             select dv).ToList();
                }
                else if (ma == "" && ten != "" && heso == "")
                {
                    KQTim = (from dv in db.ChucVus.ToList()
                             where dv.TenChucVu.Contains(ten)

                             select dv).ToList();
                }
                else if (ma == "" && ten == "" && heso != "")
                {
                    hesotim = Convert.ToDouble(heso);
                    KQTim = (from dv in db.ChucVus.ToList()
                             where dv.HeSoCV == hesotim

                             select dv).ToList();
                }


                return KQTim;
            }
            catch (Exception)
            {

                throw;
            }



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

        public bool Suachucvu(ChucVu chucvu)
        {
            QuanLyLuongEntities csdl = new QuanLyLuongEntities();
            try
            {

                ChucVu cv = csdl.ChucVus.SingleOrDefault(n => n.MaChucVu == chucvu.MaChucVu);
                cv.TenChucVu = chucvu.TenChucVu;
                cv.HeSoCV = chucvu.HeSoCV;
                csdl.SaveChanges();


            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
