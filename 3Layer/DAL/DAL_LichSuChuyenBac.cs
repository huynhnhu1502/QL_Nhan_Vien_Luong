using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{
    public class DAL_LichSuChuyenBac
    {
        public DAL_LichSuChuyenBac() { }

        public static List<LichSuChuyenBac> listall()
        {
            QuanLyLuongEntities db = new QuanLyLuongEntities();
            List<LichSuChuyenBac> list = new List<LichSuChuyenBac>();
            list = ((from lscb in db.LichSuChuyenBacs.ToList()
                     from hslpc in db.HeSoLuongPhuCaps.ToList()
                     from ngach in db.NgachLuongs.ToList()
                     from nv in db.NhanViens.ToList()
                     where lscb.MaNV == nv.MaNV && lscb.MaHeSo == hslpc.MaHeSo && hslpc.MaNgach == ngach.MaNgach
                     select new LichSuChuyenBac()
                     {                         
                         id = lscb.id,
                         MaNV = nv.MaNV,
                         TenNV = nv.HoTen,
                         MaHeSo = hslpc.MaHeSo,
                         Tenheso = hslpc.TenHeSo,
                         Mangach = ngach.MaNgach,
                         Tenngach = ngach.TenNgach,
                         NienHan = ngach.NienHan,
                         Heso = hslpc.HeSo,
                         NgayChuyen = lscb.NgayChuyen

                     }).ToList());

            return list;

        }

        public List<LichSuChuyenBac> timkiem(string tim, string tungay, string denngay)
        {
            QuanLyLuongEntities db = new QuanLyLuongEntities();
            List<LichSuChuyenBac> KQTim = new List<LichSuChuyenBac>();
            try
            {
                if (tim != "")
                {
                    DateTime ngaytu = Convert.ToDateTime(tungay);
                    DateTime ngayden = Convert.ToDateTime(denngay);

                    KQTim = ((from lscb in db.LichSuChuyenBacs.ToList()
                              from hslpc in db.HeSoLuongPhuCaps.ToList()
                              from ngach in db.NgachLuongs.ToList()
                              from nv in db.NhanViens.ToList()
                              where lscb.MaNV == nv.MaNV && lscb.MaHeSo == hslpc.MaHeSo && hslpc.MaNgach == ngach.MaNgach && nv.MaNV.Contains(tim) && ngaytu <= lscb.NgayChuyen && lscb.NgayChuyen <= ngayden
                              select new LichSuChuyenBac()
                              {
                                  id = lscb.id,
                                  MaNV = nv.MaNV,
                                  TenNV = nv.HoTen,
                                  MaHeSo = hslpc.MaHeSo,
                                  Tenheso = hslpc.TenHeSo,
                                  Mangach = ngach.MaNgach,
                                  Tenngach = ngach.TenNgach,
                                  NienHan = ngach.NienHan,
                                  Heso = hslpc.HeSo,
                                  NgayChuyen = lscb.NgayChuyen

                              }).ToList());

                }
                else if (tim == "")
                {

                    DateTime ngaytu = Convert.ToDateTime(tungay);
                    DateTime ngayden = Convert.ToDateTime(denngay);

                    KQTim = ((from lscb in db.LichSuChuyenBacs.ToList()
                              from hslpc in db.HeSoLuongPhuCaps.ToList()
                              from ngach in db.NgachLuongs.ToList()
                              from nv in db.NhanViens.ToList()
                              where lscb.MaNV == nv.MaNV && lscb.MaHeSo == hslpc.MaHeSo && hslpc.MaNgach == ngach.MaNgach && ngaytu <= lscb.NgayChuyen && lscb.NgayChuyen <= ngayden
                              select new LichSuChuyenBac()
                              {
                                  id = lscb.id,
                                  MaNV = nv.MaNV,
                                  TenNV = nv.HoTen,
                                  MaHeSo = hslpc.MaHeSo,
                                  Tenheso = hslpc.TenHeSo,
                                  Mangach = ngach.MaNgach,
                                  Tenngach = ngach.TenNgach,
                                  NienHan = ngach.NienHan,
                                  Heso = hslpc.HeSo,
                                  NgayChuyen = lscb.NgayChuyen

                              }).ToList());

                }

                return KQTim;
            }
            catch (Exception)
            {

                throw;
            }



        }
        public bool themchuyenbac(LichSuChuyenBac lichsuchuyenbac)
        {
            QuanLyLuongEntities db = new QuanLyLuongEntities();
            try
            {
                LichSuChuyenBac lscb = new LichSuChuyenBac { MaNV = lichsuchuyenbac.MaNV, MaHeSo = lichsuchuyenbac.MaHeSo, Mangach = lichsuchuyenbac.Mangach, NgayChuyen = lichsuchuyenbac.NgayChuyen };
                db.LichSuChuyenBacs.Add(lscb);
                db.SaveChanges();

                var nhanvien = from p in db.NhanViens
                               where p.MaNV == lichsuchuyenbac.MaNV
                               select p;
                foreach (NhanVien nv in nhanvien)
                {
                    nv.MaHeSo = lichsuchuyenbac.MaHeSo;
                    nv.MaNgach = lichsuchuyenbac.Mangach;
                }
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suachuyenbac(LichSuChuyenBac lichsuchuyenbac)
        {
            QuanLyLuongEntities csdl = new QuanLyLuongEntities();
            try
            {

                LichSuChuyenBac ls = csdl.LichSuChuyenBacs.SingleOrDefault(n => n.id == lichsuchuyenbac.id );
                ls.MaHeSo = lichsuchuyenbac.MaHeSo;
                ls.NgayChuyen = lichsuchuyenbac.NgayChuyen;

                csdl.SaveChanges();
                var nhanvien = from p in csdl.NhanViens
                               where p.MaNV == lichsuchuyenbac.MaNV
                               select p;
                foreach (NhanVien nv in nhanvien)
                {
                    nv.MaHeSo = lichsuchuyenbac.MaHeSo;
                    nv.MaNgach = lichsuchuyenbac.Mangach;
                }
                csdl.SaveChanges();

            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<NgachLuong> LayNgach()
        {
            QuanLyLuongEntities db = new QuanLyLuongEntities();
            try
            {
                List<NgachLuong> list = new List<NgachLuong>();
                var ds = from nl in db.NgachLuongs
                         join ngach in db.NgachLuongs on nl.MaNgach equals ngach.MaNgach
                         select nl;
                list = ds.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
 
    }
}
