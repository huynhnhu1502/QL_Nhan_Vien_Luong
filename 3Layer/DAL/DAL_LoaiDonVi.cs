using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{
    class DAL_LoaiDonVi
    {
        QuanLyLuongEntities _db = new QuanLyLuongEntities();
        LoaiDonVi _loaidonvi = new LoaiDonVi();

        public  List<LoaiDonVi> listall()
        {
            QuanLyLuongEntities model = new QuanLyLuongEntities();
            List<LoaiDonVi> list = new List<LoaiDonVi>();
            list = (from n in model.LoaiDonVis select n).ToList();
            return list;

        }
        public List<LoaiDonVi> TimKiem(string ma, string ten)
        {
            QuanLyLuongEntities db = new QuanLyLuongEntities();
            List<LoaiDonVi> KQTim = new List<LoaiDonVi>();
            try
            {
                if (ma != "" && ten != "" )
                {
                    KQTim = (from ldv in db.LoaiDonVis.ToList()
                             where ldv.MaLoai.Contains(ma) && ldv.TenLoai.Contains(ten) 

                             select ldv).ToList();
                }
                else if (ma == "" && ten != "")
                {
                    KQTim = (from ldv in db.LoaiDonVis.ToList()
                             where ldv.TenLoai.Contains(ten) 

                             select ldv).ToList();
                }

                else if (ma != "" && ten == "" )
                {
                    KQTim = (from ldv in db.LoaiDonVis.ToList()
                             where ldv.MaLoai.Contains(ma) 

                             select ldv).ToList();
                }
                else if (ma == "" && ten == "")
                {
                    KQTim = (from ldv in db.LoaiDonVis.ToList()
                             select ldv).ToList();
                }
              

                return KQTim;
            }
            catch (Exception)
            {

                throw;
            }



        }
        public bool ThemLoai(LoaiDonVi loaidonvi)
        {
            try
            {
                var them = new LoaiDonVi { MaLoai = loaidonvi.MaLoai, TenLoai = loaidonvi.TenLoai, MoTa = loaidonvi.MoTa };
                _db.LoaiDonVis.Add(them);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaLoai(LoaiDonVi loaidv)
        {
            try
            {
                var sua = _db.LoaiDonVis.FirstOrDefault(a => a.MaLoai == loaidv.MaLoai);
                if (sua != null)
                {
                    sua.TenLoai = loaidv.TenLoai;
                    sua.MoTa = loaidv.MoTa;
                    _db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
