using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer.DAL
{
    public class DAL_TinhLuong
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        NhanVien _nhanvien = new NhanVien();
        public bool TinhLuong(string Manv)
        {
            int countmanv = (from u in db.LuongThucTes where u.MaNV.Equals(Manv) select u).Count();
            try
            {
                if (countmanv != 0)
                {
                    double hesotinhluong;
                    var result = db.NhanViens.FirstOrDefault(a => a.MaNV.Equals(Manv));
                    double xuatLuong;
                    double luongCoBantruoc = double.Parse(db.LuongThucTes.Where(a => a.MaNV.Equals(Manv)).OrderByDescending(a => a.id).Select(a => a.LuongCoBan).FirstOrDefault().ToString());
                    string TrangThaiLuong;
                    string maxmaheso = db.LichSuChuyenBacs.Where(a => a.MaNV.Equals(Manv)).OrderByDescending(a => a.id).Select(a => a.MaHeSo).FirstOrDefault();
                    string maxmahesotrongbangluong = db.LuongThucTes.Where(a => a.MaNV.Equals(Manv)).OrderByDescending(a => a.id).Select(a => a.MaHeSo).FirstOrDefault();
                    if (luongCoBantruoc == null)
                        luongCoBantruoc = 720000;
                    if (result != null)
                    {
                        var heso = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo.Equals(maxmaheso));
                        var hesochucvu = db.ChucVus.FirstOrDefault(a => a.MaChucVu.Equals(result.MaChucVu));
                        if (hesochucvu.HeSoCV != 0)
                        {
                            hesotinhluong = heso.HeSo + hesochucvu.HeSoCV;
                        }
                        else
                        {
                            hesotinhluong = heso.HeSo;
                        }
                        double LuongCoBan = 720000;
                        var hesovuotkhung5 = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo == "HS0008" || a.MaHeSo == "HS0016" || a.MaHeSo == "HS0024" || a.MaHeSo == "HS0032");
                        double tinhhesovuotkhung5 = hesovuotkhung5.HeSo + 1;
                        var hesovuotkhung7 = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo == "HS0038" || a.MaHeSo == "HS0046" || a.MaHeSo == "HS0054");
                        double tinhhesovuotkhung7 = hesovuotkhung7.HeSo + 1;
                        var hesovuotkhung9 = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo == "HS0039" || a.MaHeSo == "HS0047" || a.MaHeSo == "HS0055");
                        double tinhhesovuotkhung9 = hesovuotkhung9.HeSo + 1;
                        var hesovuotkhung11 = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo == "HS0040" || a.MaHeSo == "HS0048" || a.MaHeSo == "HS0056");
                        double tinhhesovuotkhung11 = hesovuotkhung11.HeSo + 1;
                        if (maxmaheso == "HS0008" || maxmaheso == "HS0016" || maxmaheso == "HS0024" || maxmaheso == "HS0032")
                        {
                            xuatLuong = luongCoBantruoc * tinhhesovuotkhung5;
                            TrangThaiLuong = "Vượt khung 5";
                        }
                        else if (maxmaheso == "HS0038" || maxmaheso == "HS0046" || maxmaheso == "HS0054")
                        {
                            xuatLuong = luongCoBantruoc * tinhhesovuotkhung7;
                            TrangThaiLuong = "Vượt khung 7";
                        }
                        else if (maxmaheso == "HS0039" || maxmaheso == "HS0047" || maxmaheso == "HS0055")
                        {
                            xuatLuong = luongCoBantruoc * tinhhesovuotkhung9;
                            TrangThaiLuong = "Vượt khung 9";
                        }
                        else if (maxmaheso == "HS0040" || maxmaheso == "HS0048" || maxmaheso == "HS0056")
                        {
                            xuatLuong = luongCoBantruoc * tinhhesovuotkhung11;
                            TrangThaiLuong = "Vượt khung 11";
                        }
                        else
                        {
                            xuatLuong = hesotinhluong * LuongCoBan;
                            TrangThaiLuong = "Không có gì";
                        }
                        decimal floatLuongcoban = decimal.Parse(xuatLuong.ToString());
                        if (maxmaheso != maxmahesotrongbangluong)
                        {
                            var themvaoluong = new LuongThucTe { MaLuong = automaluong(), MaNV = result.MaNV, NgayLap = DateTime.Now, HeSoLuong = hesotinhluong, LuongCoBan = floatLuongcoban, LuongThucTe1 = floatLuongcoban, TrangThai = TrangThaiLuong, MaHeSo = maxmaheso };
                            db.LuongThucTes.Add(themvaoluong);
                            db.SaveChanges();
                        }
                        else
                        {
                            var capnhatngaythang = db.LuongThucTes.Where(a => a.MaNV.Equals(Manv)).OrderByDescending(a => a.id).FirstOrDefault();
                            capnhatngaythang.NgayLap = DateTime.Now;
                            db.SaveChanges();
                        }
                    }
                }
                else
                {
                    double hesotinhluong;
                    var result = db.NhanViens.FirstOrDefault(a => a.MaNV.Equals(Manv));
                    double xuatLuong;
                    double luongCoBantruoc = 720000;
                    string TrangThaiLuong;
                    string maxmaheso = db.LichSuChuyenBacs.Where(a => a.MaNV.Equals(Manv)).OrderByDescending(a => a.id).Select(a => a.MaHeSo).FirstOrDefault();
                    if (result != null)
                    {
                        var heso = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo.Equals(maxmaheso));
                        var hesochucvu = db.ChucVus.FirstOrDefault(a => a.MaChucVu.Equals(result.MaChucVu));
                        if (hesochucvu.HeSoCV != 0)
                        {
                            hesotinhluong = heso.HeSo + hesochucvu.HeSoCV;
                        }
                        else
                        {
                            hesotinhluong = heso.HeSo;
                        }
                        double LuongCoBan = 720000;
                        var hesovuotkhung5 = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo == "HS0008" || a.MaHeSo == "HS0016" || a.MaHeSo == "HS0024" || a.MaHeSo == "HS0032");
                        double tinhhesovuotkhung5 = hesovuotkhung5.HeSo + 1;
                        var hesovuotkhung7 = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo == "HS0038" || a.MaHeSo == "HS0046" || a.MaHeSo == "HS0054");
                        double tinhhesovuotkhung7 = hesovuotkhung7.HeSo + 1;
                        var hesovuotkhung9 = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo == "HS0039" || a.MaHeSo == "HS0047" || a.MaHeSo == "HS0055");
                        double tinhhesovuotkhung9 = hesovuotkhung9.HeSo + 1;
                        var hesovuotkhung11 = db.HeSoLuongPhuCaps.FirstOrDefault(a => a.MaHeSo == "HS0040" || a.MaHeSo == "HS0048" || a.MaHeSo == "HS0056");
                        double tinhhesovuotkhung11 = hesovuotkhung11.HeSo + 1;
                        if (maxmaheso == "HS0008" || maxmaheso == "HS0016" || maxmaheso == "HS0024" || maxmaheso == "HS0032")
                        {
                            xuatLuong = luongCoBantruoc * tinhhesovuotkhung5;
                            TrangThaiLuong = "Vượt khung 5";
                        }
                        else if (maxmaheso == "HS0038" || maxmaheso == "HS0046" || maxmaheso == "HS0054")
                        {
                            xuatLuong = luongCoBantruoc * tinhhesovuotkhung7;
                            TrangThaiLuong = "Vượt khung 7";
                        }
                        else if (maxmaheso == "HS0039" || maxmaheso == "HS0047" || maxmaheso == "HS0055")
                        {
                            xuatLuong = luongCoBantruoc * tinhhesovuotkhung9;
                            TrangThaiLuong = "Vượt khung 9";
                        }
                        else if (maxmaheso == "HS0040" || maxmaheso == "HS0048" || maxmaheso == "HS0056")
                        {
                            xuatLuong = luongCoBantruoc * tinhhesovuotkhung11;
                            TrangThaiLuong = "Vượt khung 11";
                        }
                        else
                        {
                            xuatLuong = hesotinhluong * LuongCoBan;
                            TrangThaiLuong = "Không có gì";
                        }
                        decimal floatLuongcoban = decimal.Parse(xuatLuong.ToString());
                        var themvaoluong = new LuongThucTe { MaLuong = automaluong(), MaNV = result.MaNV, NgayLap = DateTime.Now, HeSoLuong = hesotinhluong, LuongCoBan = floatLuongcoban, LuongThucTe1 = floatLuongcoban, TrangThai = TrangThaiLuong, MaHeSo = maxmaheso };
                        db.LuongThucTes.Add(themvaoluong);
                        db.SaveChanges();
                    }
                }
                return true;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex);
                return false;
            }
        }
        public string automaluong()
        {
            string MaLuong;
            int countid = (from u in db.LuongThucTes select u).Count();
            if (countid == 0)
            {
                 MaLuong = "ML00" + 1;
            }
            else
            {
                int idluonghientai = db.LuongThucTes.Max(a => a.id);
                int idketiep = idluonghientai + 1;
                MaLuong = "ML00" + idketiep;
            }
            return MaLuong;
        }
        public List<LuongThucTe> ThongKeLuong(string MaDonVi, string thang, string nam)
        {
            var result = (from o in db.LuongThucTes
                          from e in db.NhanViens
                          where e.MaDonVi == MaDonVi && e.MaNV == o.MaNV
                          select o).OrderByDescending(a => a.NgayLap);
            if (!String.IsNullOrEmpty(thang) && !String.IsNullOrEmpty(nam))
            {
                int thang1 = int.Parse(thang);
                int nam1 = int.Parse(nam);
                result = (from o in db.LuongThucTes
                          from e in db.NhanViens
                          where e.MaDonVi == MaDonVi && e.MaNV == o.MaNV && o.NgayLap.Month == thang1 && o.NgayLap.Year == nam1
                          select o).OrderByDescending(a => a.NgayLap);
                if (result == null)
                {
                    Console.Write("Không tìm thấy");
                }
            }
            return result.ToList();
        }
        public List<DonVi> XuatThongKeLuongTheoDonVi()
        {
            var result = (from u in db.DonVis select u);
            return result.ToList();
        }
        public List<NhanVien> XuatThucHienTinhLuong(string MaNV)
        {
            var nhanvien = (from u in db.NhanViens
                            join donvi in db.DonVis on u.MaDonVi equals donvi.MaDonVi
                            join chucvu in db.ChucVus on u.MaChucVu equals chucvu.MaChucVu
                            join ngach in db.NgachLuongs on u.MaNgach equals ngach.MaNgach
                            where u.MaNV.Equals(MaNV)
                            select u);
            return nhanvien.ToList();
        }
        public List<NhanVien> XuatTinhLuong(string Hoten)
        {
            var nhanvien = (from u in db.NhanViens
                            select u);
            if (!String.IsNullOrEmpty(Hoten))
            {
                nhanvien = db.NhanViens.Where(a => a.HoTen.Contains(Hoten));
            }
            return nhanvien.ToList();
        }
    }
}
