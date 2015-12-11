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
                List<NgachLuong> list = new List<NgachLuong>();
                var ds = from ngachLuong in entity.NgachLuongs
                         select ngachLuong;
                list = ds.ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Tìm hệ số lương theo tên ngạch, hệ số
        public List<HeSoLuongPhuCap> TimHeSoLuong(string maNgach, double heSo)
        {
            try
            {
                List<HeSoLuongPhuCap> list = new List<HeSoLuongPhuCap>();
                var dsTim = from hs in entity.HeSoLuongPhuCaps
                            join ngach in entity.NgachLuongs on hs.MaNgach equals ngach.MaNgach
                            select hs;
                if(maNgach != "------Tất cả------")
                {
                    dsTim = dsTim.Where(s => s.NgachLuong.MaNgach.Equals(maNgach));
                }
                if(heSo != -1)
                {
                    dsTim = dsTim.Where(s => s.HeSo.Equals(heSo));
                }
                list = dsTim.ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Thêm hệ số lương
        public bool ThemHeSoLuong(HeSoLuongPhuCap heSo)
        {
            try
            {
                entity.HeSoLuongPhuCaps.Add(heSo);
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Tạo mã hệ số lương
        public string TaoMaHeSoLuong()
        {
            try
            {
                string kq = "";
                var ma = from hs in entity.HeSoLuongPhuCaps
                         orderby hs.MaHeSo descending
                         select hs.MaHeSo;
                if(ma.Count() == 0)
                {
                    kq = "0001";
                }
                else
                {
                    string maHeSo = ma.First().ToString();
                    int so = int.Parse(maHeSo.Substring(2));
                    int soTang = so + 1;

                    if(soTang < 0)
                    {
                        kq = "HS000" + soTang.ToString();
                    }
                    else if(soTang < 10)
                    {
                        kq = "HS00" + soTang.ToString();
                    }
                    else if(soTang < 100)
                    {
                        kq = "HS0" + soTang.ToString();
                    }
                    else
                    {
                        kq = "HS" + soTang.ToString();
                    }
                }
                return kq;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Sửa hệ số lương
        public bool SuaHeSoLuong(HeSoLuongPhuCap heSoSua)
        {
            try
            {
                entity.HeSoLuongPhuCaps.Attach(heSoSua);
                var heSo = entity.Entry(heSoSua);
                heSo.Property(s => s.TenHeSo).IsModified = true;
                heSo.Property(s => s.HeSo).IsModified = true;
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Tìm hệ số lương theo mã để đổ DL vào form sửa
        public HeSoLuongPhuCap TimHeSoTheoMa(string maHeSo)
        {
            try
            {
                var dsTim = (from heso in entity.HeSoLuongPhuCaps
                             join ngach in entity.NgachLuongs on heso.MaNgach equals ngach.MaNgach
                             where heso.MaHeSo == maHeSo
                             select heso).ToList();
                if(dsTim.Count > 0)
                {
                    HeSoLuongPhuCap hs = dsTim[0];
                    return hs;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Kiểm tra tên hệ số trong ngạch có trùng không
        public bool KiemTraTenHeSo(string maNgach, string tenHeSo)
        {
            try
            {
                var item = from heso in entity.HeSoLuongPhuCaps
                           where heso.MaNgach == maNgach && heso.TenHeSo == tenHeSo
                           select heso;
                if(item.Count() > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Xoá hệ số lương
        public bool XoaHeSoLuong(string maXoa)
        {
            try
            {
                HeSoLuongPhuCap heSo = (HeSoLuongPhuCap)entity.HeSoLuongPhuCaps.Where(s => s.MaHeSo == maXoa).First();
                entity.HeSoLuongPhuCaps.Remove(heSo);
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
